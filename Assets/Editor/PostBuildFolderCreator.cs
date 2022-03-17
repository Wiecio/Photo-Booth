using System.IO;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Editor
{
    public class PostBuildFolderCreator : MonoBehaviour, IPostprocessBuildWithReport
    {
        public void OnPostprocessBuild(BuildReport report)
        {
            Debug.Log(report.summary.outputPath);
            var path = Path.Combine(Path.GetDirectoryName(report.summary.outputPath),
                Application.productName + "_Data/Input/");
            Directory.CreateDirectory(path);
        }

        public int callbackOrder { get; }
    }
}
