using System;
using System.IO;
using Interfaces;
using UnityEngine;

namespace Photos
{
    public class PhotoDiskSaver : MonoBehaviour, IPhotoSaver
    {
        static string SavePath => Application.dataPath + "/Output/";
        static string FileName => "photo_" + DateTime.Now.ToShortDateString() + "-" + DateTime.Now.Ticks + ".png";

        public void Save(byte[] photo)
        {
            if (!Directory.Exists(SavePath))
                Directory.CreateDirectory(SavePath);
            File.WriteAllBytes(SavePath + FileName,photo);
            Debug.Log("Photo saved in: " + SavePath);
        }

    }
}
