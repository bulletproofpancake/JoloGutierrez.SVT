using System.IO;
using SVT.References;
using UnityEditor;
using UnityEngine;

namespace SVT.Editor.References
{
    [CustomEditor(typeof(FilePathReference))]
    public class FilePathReferenceEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var filePathReference = target as FilePathReference;
            if (!GUILayout.Button("Create Directory")) return;
            CreateDirectory(filePathReference);
        }

        private void CreateDirectory(FilePathReference filePathReference)
        {
            if (Directory.Exists(filePathReference.DirectoryPath))
            {
                Debug.LogWarning($"{filePathReference.DirectoryPath} already exists.");
                return;
            }

            Directory.CreateDirectory(filePathReference.DirectoryPath);
            Debug.Log($"{filePathReference.DirectoryPath} created.");
            AssetDatabase.Refresh();
        }
    }
}