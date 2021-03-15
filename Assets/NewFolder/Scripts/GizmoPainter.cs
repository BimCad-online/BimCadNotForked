using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoPainter : MonoBehaviour
{
    LineDrawer lineDrawerX;
    LineDrawer lineDrawerY;
    LineDrawer lineDrawerZ;
    float lineSize = 1000.0f;
    float lineDistance = 0.2f;
    Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
        lineSize = Camera.main.orthographicSize / 50;
        lineDistance = Camera.main.orthographicSize * 1000;
        lineDrawerX = new LineDrawer(lineSize);
        lineDrawerY = new LineDrawer(lineSize);
        lineDrawerZ = new LineDrawer(lineSize);
        lineDrawerZ.DrawLineInGameView(Vector3.zero, new Vector3(0, 0, lineDistance), Color.blue);
        lineDrawerY.DrawLineInGameView(Vector3.zero, new Vector3(0, lineDistance, 0), Color.green);
        lineDrawerX.DrawLineInGameView(Vector3.zero, new Vector3(lineDistance, 0, 0), Color.red);

    }

   
}
