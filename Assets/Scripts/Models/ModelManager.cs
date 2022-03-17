using Interfaces;
using UnityEngine;

namespace Models
{
    public class ModelManager : MonoBehaviour
    {
        IBrowser<GameObject> browser;
        IRotator modelRotator;
        
        void Awake()
        {
            var modelLoader = GetComponent<ILoader<GameObject>>();
            var models = modelLoader.Load();
            browser = GetComponent<IBrowser<GameObject>>();
            browser.SetObjects(models);
            modelRotator = GetComponent<IRotator>();
            modelRotator.RotatedTransform = browser.CurrentObject.transform;

        }

        void Update()
        {
            modelRotator.Rotate();
        }

        public void Forward()
        {
            browser.Forward();
            modelRotator.RotatedTransform = browser.CurrentObject.transform;
        }

        public void Back()
        {
            browser.Back();
            modelRotator.RotatedTransform = browser.CurrentObject.transform;
        }
    }
}
