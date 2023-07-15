using System;
using UnityEngine;

namespace SVT.References
{
    internal enum AssetPathType
    {
        DataPath,
        PersistentDataPath,
        StreamingAssets,
        Resources
    }

    [CreateAssetMenu(menuName = "References/File Path Reference")]
    public class FilePathReference : ScriptableObject
    {
        [SerializeField] private AssetPathType assetPathType;
        [SerializeField] private string directory;

        public string AssetPath
        {
            get
            {
                return assetPathType switch
                {
                    AssetPathType.DataPath => Application.dataPath,
                    AssetPathType.PersistentDataPath => Application.persistentDataPath,
                    AssetPathType.StreamingAssets => Application.streamingAssetsPath,
                    AssetPathType.Resources => Application.dataPath + "Resources",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }

        public string DirectoryPath => string.IsNullOrEmpty(directory) ? $"{AssetPath}/" : $"{AssetPath}/{directory}/";
    }
}