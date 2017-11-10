namespace Xtrf.Helper
{
    public static class DoubleExtension
    {
        internal static string ToUsNotation(this double n) => n.ToString().Replace(',', '.');
    }
}
