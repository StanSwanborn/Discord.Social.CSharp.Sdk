using System.Runtime.InteropServices;

namespace Discord.Social.CSharp.Native.Sdk;

internal static class NativeString
{
    internal static DiscordString Create(string value, out nint allocation)
    {
        allocation = Marshal.StringToCoTaskMemUTF8(value);
        return new DiscordString
        {
            Ptr = allocation,
            Size = (nuint)System.Text.Encoding.UTF8.GetByteCount(value)
        };
    }

    internal static void Free(nint allocation)
    {
        Marshal.FreeCoTaskMem(allocation);
    }

    internal static string Read(DiscordString value)
    {
        if (value.Ptr == nint.Zero || value.Size == 0)
            return string.Empty;

        return Marshal.PtrToStringUTF8(value.Ptr, checked((int)value.Size));
    }
}