using UnityEngine;

namespace Interfaces
{
    public interface IRotator
    {
        Transform RotatedTransform { get; set; }
        void Rotate();
    }
}
