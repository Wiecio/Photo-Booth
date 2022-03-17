using Interfaces;
using UnityEngine;

namespace Photos
{
    public class PhotoManager : MonoBehaviour
    {
        [SerializeField] GameObject ui;
        
        IPhotoProvider photoProvider;
        IPhotoSaver photoSaver;

        void Awake()
        {
            photoProvider = GetComponent<IPhotoProvider>();
            photoSaver = GetComponent<IPhotoSaver>();
            
        }

        public void TakeAndSavePhoto()
        {
            ui.SetActive(false);
            photoProvider.TakePhoto(photo =>
            {
                photoSaver.Save(photo);
                ui.SetActive(true);
            });
           
        }
        
        
    }
}
