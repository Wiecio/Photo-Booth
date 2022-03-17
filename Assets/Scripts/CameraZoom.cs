using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] float zoomSpeed = 20;
    [SerializeField] float minZ = -50;
    [SerializeField] float maxZ = 0;
    [SerializeField] float maxDistanceToModel = 5;
    float zPosition;

    void Start()
    {
        zPosition = transform.position.z;
    }

    void Update()
    {
        var inputDelta = Input.mouseScrollDelta.y;
        var trans = transform;
        var pos = trans.position;
        zPosition = Mathf.Clamp(zPosition + inputDelta, minZ, maxZ);
        CheckDistanceToModel();
        pos.z = Mathf.MoveTowards(pos.z, zPosition, Time.deltaTime * zoomSpeed);
        trans.position = pos;

    }
    
    void CheckDistanceToModel()
    {
        var trans = transform;
        var ray = new Ray(trans.position, trans.forward);
        if (!Physics.SphereCast(ray, 3, out var hit)) return;
        if (zPosition > hit.point.z - maxDistanceToModel)
            zPosition = hit.point.z - maxDistanceToModel;
    }
}
