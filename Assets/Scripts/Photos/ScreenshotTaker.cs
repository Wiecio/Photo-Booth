using System;
using System.Collections;
using Interfaces;
using UnityEngine;

namespace Photos
{
    public class ScreenshotTaker : MonoBehaviour, IPhotoProvider
    {
        readonly WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
        
        Action<byte[]> onGotScreenshot;
    
        public void TakePhoto(Action<byte[]> callback)
        {
            onGotScreenshot = callback;
            StartCoroutine(nameof(ScreenShotCoroutine));
        }
        
        IEnumerator ScreenShotCoroutine()
        {
            yield return waitForEndOfFrame;
            onGotScreenshot.Invoke(ReadPixelsFromCamera());
        }

        byte[] ReadPixelsFromCamera()
        {
            var screenshotTexture = new Texture2D(Screen.width, Screen.height);
            screenshotTexture.ReadPixels(
                new Rect(0, 0, Screen.width, Screen.height), 0, 0,false);
           
            return screenshotTexture.EncodeToPNG();
        }

    }
}
