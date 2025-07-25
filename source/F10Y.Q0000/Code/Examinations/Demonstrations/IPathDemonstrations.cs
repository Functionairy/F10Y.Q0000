using System;
using System.IO;
using System.Threading.Tasks;

using F10Y.T0006;


namespace F10Y.Q0000
{
    [DemonstrationsMarker]
    public partial interface IPathDemonstrations :
        Q001.IPathDemonstrations
    {
        #region Infrastructure

        string Q001.IPathDemonstrations.Output_TextFilePath =>
            Instances.FilePaths.Output_TextFilePath;

        void Q001.IPathDemonstrations.Open(params string[] filePaths)
            => Instances.NotepadPlusPlusOperator.Open(filePaths);

        #endregion


        /// <summary>
        /// A space for scratch work.
        /// </summary>
        public Task Scratch()
        {
            throw new NotImplementedException();
        }
    }
}
