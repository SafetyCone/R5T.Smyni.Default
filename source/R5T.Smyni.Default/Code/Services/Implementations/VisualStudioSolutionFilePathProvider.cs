using System;

using R5T.Lombardy;
using R5T.Smyni.Types;using R5T.T0064;


namespace R5T.Smyni.Default
{[ServiceImplementationMarker]
    public class VisualStudioSolutionFilePathProvider : IVisualStudioSolutionFilePathProvider,IServiceImplementation
    {
        private IFileNameOperator FileNameOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public VisualStudioSolutionFilePathProvider(IFileNameOperator fileNameOperator, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.FileNameOperator = fileNameOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetVisualStudioSolutionFilePath(string solutionDirectoryPath, string solutionName)
        {
            var solutionFileName = this.FileNameOperator.GetFileName(solutionName, FileExtensions.SolutionFileExtension);

            var solutionFilePath = this.StringlyTypedPathOperator.GetFilePath(solutionDirectoryPath, solutionFileName);
            return solutionFilePath;
        }
    }
}
