using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform CameraMovePoint;
    public float cameraMoveSpeed;

    public float DistanceToPan_Left_Right;
    public float DistanceToPan_Up_Down;

    void Start()
    {
        CameraMovePoint.parent = null;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, CameraMovePoint.position, cameraMoveSpeed * Time.unscaledDeltaTime);
    }

    public void shift_Right()
    {
        CameraMovePoint.transform.position += new Vector3(DistanceToPan_Left_Right, 0, 0);
    }
    public void shift_Left()
    {
        CameraMovePoint.transform.position += new Vector3(-DistanceToPan_Left_Right, 0, 0); ;
    }
    public void shift_Up()
    {
        CameraMovePoint.transform.position += new Vector3(0, DistanceToPan_Up_Down, 0);
    }
    public void shift_Down()
    {
        CameraMovePoint.transform.position += new Vector3(0, -DistanceToPan_Up_Down, 0);
    }
}
