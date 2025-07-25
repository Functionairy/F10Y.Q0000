using System;


namespace F10Y.Q0000.Q001
{
    public static class Instances
    {
        public static L0000.IArrayOperator ArrayOperator => L0000.ArrayOperator.Instance;
        public static Z0011.Z001.IDirectoryNames DirectoryNames => Z0011.Z001.DirectoryNames.Instance;
        public static Z0011.Z001.IDirectoryPaths DirectoryPaths => Z0011.Z001.DirectoryPaths.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.IFileOperator FileOperator => L0000.FileOperator.Instance;
        public static L0000.ITypeNameOperator TypeNameOperator => L0000.TypeNameOperator.Instance;
    }
}