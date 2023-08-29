using System.IO;
using UnityEditor;
using UnityEngine;

namespace SVT.Editor.Tools
{
    public static class ToolsMenu
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            CreateFolder("_Project", "Scripts", "Art", "Scenes");
            AssetDatabase.Refresh();
        }

        public static void CreateFolder(string root, params string[] folders)
        {
            var path = Path.Combine(Application.dataPath, root);
            foreach (var directory in folders)
            {
                Directory.CreateDirectory(Path.Combine(path, directory));
                File.CreateText(Path.Combine(path, directory) + "/.gitkeep");
            }
        }
    }
}