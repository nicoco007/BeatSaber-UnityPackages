using Microsoft.Build.Utilities;

namespace UnityPackages.Tasks
{
    public abstract class GetUnityPackageTask : Task
    {
        protected static string[] ExcludeDirectories { get; } = ["Editor", "Samples~", "Tests", "arm32", "arm64", "android", "universalwindows"];

        protected static string[] IncludeExtensions { get; } = [".cs", "*.dll"];
    }
}
