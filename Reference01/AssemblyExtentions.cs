using Reference02;
using System.Reflection;
using System.Runtime.Versioning;

namespace Reference01
{
    public static class AssemblyExtentions
    {
        public static string GenerateInformation(this Assembly assembly)
            => $"{GetTargetFrameworkName(assembly)} on {EnvironmentAssistant.Description}";

        public static string GetTargetFrameworkName(this Assembly assembly)
        {
            return assembly?
                .GetCustomAttribute<TargetFrameworkAttribute>()?
                .FrameworkName ?? "Unknown!";
        }
    }
}
