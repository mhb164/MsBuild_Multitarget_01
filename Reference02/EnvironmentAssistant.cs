using System;

namespace Reference02
{
    public static class EnvironmentAssistant
    {
        public static string Description
            => $"{Environment.OSVersion} {(Environment.Is64BitOperatingSystem ? "x64" : "x86")} - Process is {(Environment.Is64BitProcess ? "x64" : "x86")}";
    }
}
