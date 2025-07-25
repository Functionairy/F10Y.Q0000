using System;
using System.Linq;

//using F10Y.L0000.Extensions;
using F10Y.L0000.Extensions.Post_NET7_0;
using F10Y.T0006;
using F10Y.T0011;


namespace F10Y.Q0000
{
    [DemonstrationsMarker]
    public partial interface IEnumerableDemonstrations :
        Q000.IEnumerableDemonstrations
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Q000.IEnumerableDemonstrations _Q000 => Q000.EnumerableDemonstrations.Instance;

#pragma warning restore IDE1006 // Naming Styles

        public void Test()
        {
            var array = Instances.Arrays.Example_Strings;

            var enumerable_Ordered = array
                .Order()
                .Order_Ascending()
                ;

            Console.Write(enumerable_Ordered);
        }
    }
}
