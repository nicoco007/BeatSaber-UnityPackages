using Microsoft.Build.Utilities;

namespace UnityPackages.Tasks
{
    public abstract class GetUnityPackageTask : Task
    {
        public virtual string[] ExcludeDirectories { get; set; }

        public virtual string[] IncludeExtensions { get; set; }
    }
}
