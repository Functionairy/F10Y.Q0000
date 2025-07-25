using System;


namespace F10Y.Q0000
{
    public class PathDemonstrations : IPathDemonstrations
    {
        #region Infrastructure

        public static IPathDemonstrations Instance { get; } = new PathDemonstrations();


        private PathDemonstrations()
        {
        }

        #endregion
    }
}
