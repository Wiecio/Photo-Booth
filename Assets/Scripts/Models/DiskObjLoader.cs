using System.IO;
using Dummiesman;
using Interfaces;
using UnityEngine;

namespace Models
{
    public class DiskObjLoader : MonoBehaviour, ILoader<GameObject>
    {
        static string LoadPath => Application.dataPath + "/Input/";
        
        public GameObject[] Load()
        {
            var objFiles = Directory.GetFiles(LoadPath, "*.obj");
            var models = new GameObject[objFiles.Length];
            
            for (var i = 0; i < objFiles.Length; i++)
            {
                var objFile = objFiles[i];
                var fileName = Path.GetFileNameWithoutExtension(objFile);
                models[i] = new OBJLoader().Load(objFile,LoadPath + fileName + ".mtl").transform.GetChild(0).gameObject;
                models[i].AddComponent<MeshCollider>();
                models[i].SetActive(false);
            }
            
            return models;
        }
    }
}
