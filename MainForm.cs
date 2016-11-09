using Clarotech.Verifier.classes;
using Clarotech.Verifier.Properties;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clarotech.Verifier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btnErrors.Tag = "OFF";
            btnWarnings.Tag = "OFF";
            btnMessages.Tag = "OFF";

            btnError_Click(btnErrors, null);
            btnWarning_Click(btnWarnings, null);
            btnMessage_Click(btnMessages, null);
            // Create a resource resolver that searches for the core resources in 'specification.zip', which comes with the .NET FHIR Specification NuGet package
            // We create a source that takes its contents from a ZIP file (in this case the default 'specification.zip'). We decorate that source by encapsulating
            // it in a CachedResolver, which speeds up access by caching conformance resources once we got them from the large files in the ZIP.
            CoreSource = new CachedResolver(ZipSource.CreateValidationSource());
        }

        internal IResourceResolver DirectorySource;
        internal IResourceResolver CoreSource;
        internal IResourceResolver CombinedSource;

        internal bool includeErrors;
        internal bool includeWarnings;
        internal bool includeMessages;

        internal ExampleFiles exampleList;

        internal ExampleFile result;

        private void refreshProfileSource()
        {
            try
            {
                var profilePath = txtProfileDirectory.Text;

                if (!String.IsNullOrEmpty(profilePath) && Directory.Exists(profilePath))
                {
                    // We not only have a source for core data, we also read data from a user-specified directory. We also cache the contents of this source, like
                    // we did with the CoreSource above.
                    DirectorySource = new CachedResolver(new DirectorySource(profilePath, includeSubdirectories: true));

                    // Finally, we combine both sources, so we will find profiles both from the core zip as well as from the directory.
                    // By mentioning the directory source first, anything in the user directory will override what is in the core zip.
                    CombinedSource = new MultiResolver(DirectorySource, CoreSource);

                }
                else
                    CombinedSource = CoreSource;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Composing the profile source failed: {e.Message}", "Profile source");
            }
        }

        private void txtProfileDirectory_TextChanged(object sender, EventArgs e)
        {
            refreshProfileSource();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            refreshProfileSource();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            refreshProfileSource();
            SizeLastColumn(listView1);
        }

        private void btnOpenProfileDir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProfileDirectory.Text))
            {
                folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.SelectedPath = txtProfileDirectory.Text;
                folderBrowserDialog.Description = "Select folder containing the profiles";

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                    txtProfileDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnOpenExampleDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = txtExampleDirectory.Text;
            folderBrowserDialog.Description = "Select folder containing the examples";

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtExampleDirectory.Text = folderBrowserDialog.SelectedPath;
                populateFileList(folderBrowserDialog.SelectedPath);
            }
        }

        private void populateFileList(string dir)
        {
            if (Directory.Exists(dir))
            {
                string[] array2 = Directory.GetFiles(dir, "*.xml");

                exampleList = new ExampleFiles();
                exampleList.files = new List<ExampleFile>();

                foreach (var item in array2)
                {
                    ExampleFile ef = new ExampleFile();
                    ef.fileName = Path.GetFileName(item);
                    ef.fullFileName = item;
                    ef.status = "Waiting..";
                    ef.validationResult = string.Empty;
                    ef.fileContents = File.ReadAllText(item);

                    exampleList.files.Add(ef);
                }
            }
            else
            {
                exampleList = null;
            }

            result = null;
            populateLog(result);

        }

        private void loadResultsList()
        {
            if (!String.IsNullOrEmpty(txtExampleDirectory.Text))
            {
                populateFileList(txtExampleDirectory.Text);
                refreshResultsUI();
            }

        }

        private void refreshResultsUI()
        {

            lvResults.Items.Clear();

            if (exampleList != null)
            {
                foreach (var item in exampleList.files)
                {
                    if (item.status == "Waiting..")
                    {
                        lvResults.Items.Add(
                                    new ListViewItem(
                                        new string[] {
                            item.fileName,
                            item.status,
                            "..",
                            "..",
                            ".."
                                        }, 4));
                    }
                    else
                    {
                        lvResults.Items.Add(
                                       new ListViewItem(
                                           new string[] {
                            item.fileName,
                            item.status,
                            item.countErrors.ToString(),
                            item.countWarnings.ToString(),
                            item.countMessages.ToString()
                                           }, 4));
                    }
                }

                lvResults.Columns[1].Width = -2;
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            // The validator generates an OperationOutcome as output;
            result = null;

            // Configure the validator based on the user's settings
            // This includes a reference to the resolver that we have constructed in previous methods
            // and which helps the validator to look for profiles
            ValidationSettings settings = ValidationSettings.Default;
            settings.EnableXsdValidation = chkXsdValidation.Checked;
            settings.Trace = chkShowTraceInfo.Checked;
            settings.ResourceResolver = this.CombinedSource;

            if (exampleList != null)
            {
                foreach (var item in exampleList.files)
                {
                    var validator = new Validator(settings);
                    var reader = SerializationUtil.XmlReaderFromXmlText(item.fileContents);
                    item.result = validator.Validate(reader);

                    item.countMessages = item.result.Issue.Count(p => p.Code.ToString() == "Informational");
                    item.countErrors = item.result.Errors;
                    item.countWarnings = item.result.Warnings;

                    if (item.result.Errors > 0)
                    {
                        item.status = "FAILURE";
                    }
                    else
                    {
                        item.status = "SUCCESS";
                    }

                    item.validationResult = $"Errors { item.countErrors } Warnings {item.countWarnings} Messages{item.countMessages}";
                }



                // Populate 
                result = exampleList.files[0];
                populateLog(result);
                refreshResultsUI();

                lvResults.Select();
                lvResults.Items[0].Selected = true;
                lvResults.Items[0].Focused = true;
            }
        }

        private void populateLog(ExampleFile res)
        {
            if (res != null && res.result != null)
            {
                txtOutcome.Text = res.result.ToString();

                var mCount = res.result.Issue.Count(p => p.Code.ToString() == "Informational");

                btnMessages.Text = mCount + " Messages";
                btnErrors.Text = res.result.Errors + " Errors";
                btnWarnings.Text = res.result.Warnings + " Warnings";



                listView1.Items.Clear();

                int img = 0;
                bool show = false;
                foreach (var item in res.result.Issue)
                {
                    var xx = item.Code.ToString();
                    show = false;

                    switch (xx)
                    {
                        case "Invalid":
                            img = 1;
                            if (includeErrors) show = true;
                            break;
                        case "Informational":
                            img = 3;
                            if (includeMessages) show = true;
                            break;
                        case "Incomplete":
                            img = 0;
                            if (includeWarnings) show = true;
                            break;
                        default:
                            img = 0;

                            break;
                    }

                    if (show)
                    {
                        listView1.Items.Add(
                            new ListViewItem(
                                new string[] {
                            "",
                            xx,
                            item.LocationElement[0].ToString(),
                            item.Details.Text
                                }, img));
                    }
                }

                listView1.Columns[0].Width = -2;
                listView1.Columns[1].Width = -2;
                listView1.Columns[2].Width = -2;
                listView1.Columns[3].Width = -2;
            }
            else
            {
                listView1.Items.Clear();
                btnMessages.Text = "0 Messages";
                btnErrors.Text = "0 Errors";
                btnWarnings.Text = "0 Warnings";
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            Button thisButton = toggle((Button)sender);

            includeErrors = (thisButton.Tag.ToString() == "ON");
            populateLog(result);
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            Button thisButton = toggle((Button)sender);

            includeWarnings = (thisButton.Tag.ToString() == "ON");
            populateLog(result);
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            Button thisButton = toggle((Button)sender);

            includeMessages = (thisButton.Tag.ToString() == "ON");
            populateLog(result);
        }

        private Button toggle(Button thisButton)
        {

            if (thisButton.Tag.ToString() == "ON")
            {
                thisButton.Tag = "OFF";
                thisButton.FlatAppearance.BorderSize = 0;
            }
            else
            {
                thisButton.Tag = "ON";
                thisButton.FlatAppearance.BorderSize = 2;
            }

            return thisButton;
        }

        private void listView1_Resize(object sender, System.EventArgs e)
        {
            SizeLastColumn((ListView)sender);
        }

        private void SizeLastColumn(ListView lv)
        {
            lv.Columns[lv.Columns.Count - 1].Width = -2;
        }

        private void txtExampleDirectory_TextChanged(object sender, EventArgs e)
        {
            string dir = ((TextBox)sender).Text;

            populateFileList(dir);
            refreshResultsUI();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            string dir = txtExampleDirectory.Text;
            populateFileList(dir);
            refreshResultsUI();

        }

        private void lvResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;


            if (lv.SelectedItems.Count > 0)
            {
                if (((ListView)sender).FocusedItem == null)
                {

                }
                else
                {
                    int sel = ((ListView)sender).FocusedItem.Index;

                    result = exampleList.files[sel];
                    populateLog(result);
                }
            }

        }
    }
}
