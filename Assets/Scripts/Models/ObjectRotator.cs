using Interfaces;
using UnityEngine;

namespace Models
{
    public class ObjectRotator : MonoBehaviour, IRotator
    {
        public Transform RotatedTransform { get; set; }
        Camera cam;
        Vector3 lastMousePos;

        void Awake()
        {
            cam = Camera.main;
        }
        
        public void Rotate()
        {
            if (Input.GetMouseButton(0))
            {
                var mouseDeltaPos = Input.mousePosition - lastMousePos;
                RotatedTransform.Rotate(-cam.transform.up,mouseDeltaPos.x,Space.World);
                RotatedTransform.Rotate(cam.transform.right,mouseDeltaPos.y,Space.World);
                
            }
            lastMousePos = Input.mousePosition;
        }
    }
}
