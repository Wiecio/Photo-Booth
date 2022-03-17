using Models;
using Photos;
using UIs;
using UnityEngine;

public class App : MonoBehaviour
{
    [SerializeField] UI ui;
    [SerializeField] ModelManager modelManager;
    [SerializeField] PhotoManager photoManager;

    void Start()
    {
        ui.ForwardButton.onClick.AddListener(modelManager.Forward);
        ui.BackButton.onClick.AddListener(modelManager.Back);
        ui.PhotoButton.onClick.AddListener(photoManager.TakeAndSavePhoto);
        
    }

    void OnDestroy()
    {
        ui.ForwardButton.onClick.RemoveListener(modelManager.Forward);
        ui.BackButton.onClick.RemoveListener(modelManager.Back);
        ui.PhotoButton.onClick.RemoveListener(photoManager.TakeAndSavePhoto);
    }
}
