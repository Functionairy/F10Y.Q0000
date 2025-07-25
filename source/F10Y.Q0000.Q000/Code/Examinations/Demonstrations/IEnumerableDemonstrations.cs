using System;
using System.Linq;
using System.Threading.Tasks;

using F10Y.L0000.Extensions;
using F10Y.T0006;
using F10Y.T0011;


namespace F10Y.Q0000.Q000
{
    [DemonstrationsMarker]
    public partial interface IEnumerableDemonstrations
    {
        /// <summary>
        /// What is the underlying implementation type of <see cref="IOrderedEnumerable{TElement}"/>?
        /// </summary>
        [InstanceIdentity("E9785EE9-96DA-4A90-A4BC-6D787B119E39")]
        public async Task Display_OrderedEnumerable_ImplementationType()
        {
            /// Inputs.
            var array = Instances.Arrays.Example_Strings;

            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            var enumerable_Ordered = array.Order();

            var implementationType = Instances.TypeOperator.Get_Type_ImplementationType(enumerable_Ordered);

            var implementationTypeName = Instances.TypeOperator.Get_TypeName(implementationType);

            var type = Instances.TypeOperator.Get_Type_DeclaredType(enumerable_Ordered);

            var typeName = Instances.TypeOperator.Get_TypeName(type);

            var lines_ForOutput = Instances.EnumerableOperator.From($"{implementationTypeName}\n\tImplementation type of: {typeName}");

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                lines_ForOutput);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }
    }
}
