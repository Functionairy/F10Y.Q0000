using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using F10Y.L0000.Extensions;
using F10Y.T0006;


namespace F10Y.Q0000.Q001
{
    /// <summary>
    /// Demonstrations for the <see cref="Path"/> type.
    /// </summary>
    [DemonstrationsMarker]
    public partial interface IPathDemonstrations
    {
        #region Infrastructure

        /// <summary>
        /// Provides a path for writing output text.
        /// </summary>
        public string Output_TextFilePath { get; }

        /// <summary>
        /// Provides the ability open files for display.
        /// </summary>
        /// <remarks>
        /// This would typically be a text editor like notepad, Notepad++, or VS Code.
        /// </remarks>
        public void Open(params string[] filePaths);

        /// <summary>
        /// Opens the <see cref="Output_TextFilePath"/>.
        /// </summary>
        public void Open_OutputTextFile()
            => this.Open(
                this.Output_TextFilePath);

        #endregion


        /// <summary>
        /// The <see cref="Path.Combine(string, string)"/> method has a problem:
        /// if any path part is root-indicated (starts with a directory separator), all prior path parts are discarded.
        /// <para>
        /// For example: "C:Temp" + "\Directory01" => "\Directory01".
        /// </para>
        /// This holds for both Windows and non-Windows directory separators ("\Directory01" and "/Directory01").
        /// </summary>
        public async Task Combine_FailureIfRootIndicated()
        {
            /// Inputs.
            var pathPartSets_WithComment = Instances.ArrayOperator.From(
                ((Instances.DirectoryPaths.C_Temp, Instances.DirectoryNames.Directory01), "OK"),
                ((Instances.DirectoryPaths.C_Temp, Instances.DirectoryNames.Directory01_RootIndicated_Windows), "BAD"),
                ((Instances.DirectoryPaths.C_Temp, Instances.DirectoryNames.Directory01_RootIndicated_NonWindows), "BAD"),
                ((Instances.DirectoryPaths.C_Temp_NotDirectoryIndicated, Instances.DirectoryNames.Directory01), "OK"),
                ((Instances.DirectoryPaths.C_Temp_NotDirectoryIndicated, Instances.DirectoryNames.Directory01_RootIndicated_Windows), "BAD"),
                ((Instances.DirectoryPaths.C_Temp_NotDirectoryIndicated, Instances.DirectoryNames.Directory01_RootIndicated_NonWindows), "BAD")
                );

            var output_TextFilePath = this.Output_TextFilePath;


            /// Run.
            var results = pathPartSets_WithComment
                .Select(tuple =>
                {
                    var output = Path.Combine(tuple.Item1.Item1, tuple.Item1.Item2);

                    return (Tuple: tuple.Item1, Output: output, Comment: tuple.Item2);
                })
                .ToArray();

            var lines_ForOutput = Instances.EnumerableOperator.From($"{Instances.TypeNameOperator.Get_TypeName_Full(typeof(Path))}.{nameof(Path.Combine)}() method:\n")
                .Append_Many(Instances.EnumerableOperator.From("BAD results:")
                    .Append_Many(results
                        .Where(result => result.Comment == "BAD")
                        .OrderBy(result => result.Output)
                        .Select(result => $"{result.Output} = {result.Tuple.Item1} + {result.Tuple.Item2}")
                    )
                )
                .Append("")
                .Append_Many(Instances.EnumerableOperator.From("OK results:")
                    .Append_Many(results
                        .Where(result => result.Comment == "OK")
                        .Select(result => $"{result.Output} = {result.Tuple.Item1} + {result.Tuple.Item2}")
                    )
                )
                ;
                
            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            this.Open(output_TextFilePath);
        }
    }
}
