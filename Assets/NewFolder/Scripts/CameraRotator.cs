using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public GameObject cameraMain;
    public Vector3 cameraRotation;
    public Vector3 cameraPos;
    public float cameraSize;

  
    public void RotationCamera()
    {
        cameraMain.transform.rotation = Quaternion.Euler(cameraRotation);
        cameraMain.transform.position = cameraPos;
        Camera.main.orthographicSize = cameraSize;
    }





}
