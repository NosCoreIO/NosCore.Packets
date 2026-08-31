// netstandard2.0 has no IsExternalInit, which record positional members need.
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit
    {
    }
}
