using System;

using R5T.Lombardy;
using R5T.Smyni.Types;


namespace R5T.Smyni.Default
{
    public class VisualStudioSolutionFilePathProvider : IVisualStudioSolutionFilePathProvider
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
