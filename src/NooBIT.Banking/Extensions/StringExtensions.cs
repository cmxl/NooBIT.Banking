using System.Runtime.CompilerServices;

namespace NooBIT.Banking.Extensions
{
    public static class StringExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (string left, string right) SplitAt(this string text, int index) =>
            (text.Substring(0, index), text.Substring(index));
    }
}
