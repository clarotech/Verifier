using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace Clarotech.Verifier.classes
{
    internal class ExampleFiles
    {
        internal List<ExampleFile> files;
    }

    internal class ExampleFile
    {
        internal string fileName;
        internal string fullFileName;
        internal string fileContents;
        internal string validationResult;
        internal string status;
        internal int countErrors;
        internal int countWarnings;
        internal int countMessages;

        internal OperationOutcome result;
    }
}
