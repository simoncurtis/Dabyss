using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScreen : MonoBehaviour
{
    CameraMove camMoveScript;

    public enum BorderType
    {
        TOP,
        BOTTOM,
        LEFT,
        RIGHT
    }
    public BorderType curBorder;

    void Start()
    {
        camMoveScript = Camera.main.GetComponent<CameraMove>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (curBorder)
            {
                case BorderType.TOP:
                    camMoveScript.shift_Up();
                    break;

                case BorderType.BOTTOM:
                    camMoveScript.shift_Down();
                    break;

                case BorderType.LEFT:
                    camMoveScript.shift_Left();
                    break;

                case BorderType.RIGHT:
                    camMoveScript.shift_Right();
                    break;
            }
        }
    }
}
