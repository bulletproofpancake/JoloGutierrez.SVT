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
        [SerializeField] private string rootDirectory;
        [SerializeField] private bool isRootHidden;
        [SerializeField] private string endPoint;
        [SerializeField] private bool isEndpointHidden;

        public string RootDirectory => isRootHidden ? $"{rootDirectory}~" : rootDirectory;
        public string EndPoint => isEndpointHidden ? $"{endPoint}~" : endPoint;

        public string DirectoryPath
        {
            get
            {
                var isRootEmpty = string.IsNullOrEmpty(rootDirectory);
                var isEndPointEmpty = string.IsNullOrEmpty(endPoint);
                return isRootEmpty switch
                {
                    true when isEndPointEmpty => AssetPath,
                    false when isEndPointEmpty => $"{AssetPath}/{RootDirectory}",
                    true when !isEndPointEmpty => $"{AssetPath}/{EndPoint}",
                    _ => $"{AssetPath}/{RootDirectory}/{EndPoint}/"
                };
            }
        }

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
    }
}