using System;
using Interfaces;
using UnityEngine;

namespace Models
{
    public class DiskAssetBundleLoader : MonoBehaviour, ILoader<GameObject>
    {
        [SerializeField] string bundlePath = "/Input/models";
        public GameObject[] Load()
        {
            var assetBundle 
                = AssetBundle.LoadFromFile(Application.streamingAssetsPath + bundlePath);
            if (assetBundle == null) {
                Debug.LogWarning("Failed to load AssetBundle!");
                return null;
            }
            var assets = assetBundle.LoadAllAssets(typeof(GameObject));
            return Array.ConvertAll(assets, item => (GameObject)item);
        }
    }
}
