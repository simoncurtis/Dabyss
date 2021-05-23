using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFirePoint : MonoBehaviour
{
    int angleOffset = -90;
    Transform playerPos;

    private void Start()
    {
        playerPos = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        transform.position = playerPos.position;

        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + angleOffset;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
