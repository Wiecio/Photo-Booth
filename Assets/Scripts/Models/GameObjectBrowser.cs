using Interfaces;
using UnityEngine;

namespace Models
{
    public class GameObjectBrowser : MonoBehaviour, IBrowser<GameObject>
    {
        GameObject[] objects;
        public GameObject CurrentObject { get; private set; }

        int currentObjectIndex;
        int CurrentObjectIndex
        {
            get => currentObjectIndex;
            set => currentObjectIndex = (int)Mathf.Repeat(value,objects.Length);
        }
    
        public void SetObjects(GameObject[] objects)
        {
            this.objects = objects;
            CurrentObjectIndex = 0;
            SetActiveObject();
        }

        public void Forward()
        {
            CurrentObjectIndex++;
            SetActiveObject();
        }

        public void Back()
        {
            CurrentObjectIndex--;
            SetActiveObject();
        }

        void SetActiveObject()
        {
            if (objects.Length == 0) return;
            if(CurrentObject != null)
                CurrentObject.SetActive(false);
            CurrentObject = objects[currentObjectIndex];
            CurrentObject.SetActive(true);
            CurrentObject.transform.rotation = Quaternion.identity;
        }
    }
}
