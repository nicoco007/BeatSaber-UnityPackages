using GlobExpressions;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System.Linq;

namespace UnityPackages.Tasks
{
    public abstract class GetUnityPackageTask : Task
    {
        [Required]
        public string DestinationFolder { get; set; }

        [Required]
        public virtual string[] IncludeFiles { get; set; }

        [Required]
        public virtual string[] ExcludeFiles { get; set; }

        protected bool IsMatch(string filePath)
        {
            return IncludeFiles.Any(f => Glob.IsMatch(filePath, f, GlobOptions.Compiled | GlobOptions.CaseInsensitive | GlobOptions.MatchFullPath))
                && !ExcludeFiles.Any(f => Glob.IsMatch(filePath, f, GlobOptions.Compiled | GlobOptions.CaseInsensitive | GlobOptions.MatchFullPath));
        }
    }
}
