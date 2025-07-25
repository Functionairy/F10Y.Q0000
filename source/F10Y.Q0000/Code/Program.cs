using System;
using System.Threading.Tasks;


namespace F10Y.Q0000
{
    class Program
    {
        static async Task Demonstrations_Path()
        {
            await PathDemonstrations.Instance
                .Combine_FailureIfRootIndicated()
                ;
        }


        static async Task Main()
        {
            //await Program.Demonstrations_();
            //await Program.Demonstrations_Enumerable();
            await Program.Demonstrations_Path();
        }

        #region Demonstrations

        static Task Demonstrations_()
        {
            throw new NotImplementedException();
        }

        static async Task Demonstrations_Enumerable()
        {
            await Instances.EnumerableDemonstrations
                .Display_OrderedEnumerable_ImplementationType()
                ;
        }

        

        #endregion
    }
}