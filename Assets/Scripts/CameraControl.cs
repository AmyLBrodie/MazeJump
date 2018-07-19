using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

    public GameObject cameraTarget;
    public GameObject floor;

    Vector3 cameraOffset;
    float rotateAngle;
    

    void Start()
    {
        cameraOffset = cameraTarget.transform.position - transform.position;
    }

    void LateUpdate()
    {
        float desiredAngle = cameraTarget.transform.eulerAngles.y;
        Quaternion cameraRotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = cameraTarget.transform.position - (cameraRotation * cameraOffset);
        transform.LookAt(cameraTarget.transform);
    }
}
