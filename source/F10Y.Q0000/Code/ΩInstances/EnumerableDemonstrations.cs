using System;


namespace F10Y.Q0000
{
    public class EnumerableDemonstrations : IEnumerableDemonstrations
    {
        #region Infrastructure

        public static IEnumerableDemonstrations Instance { get; } = new EnumerableDemonstrations();


        private EnumerableDemonstrations()
        {
        }

        #endregion
    }
}
