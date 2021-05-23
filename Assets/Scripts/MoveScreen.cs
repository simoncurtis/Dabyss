using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScreen : MonoBehaviour
{
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
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("change screen");
        }
    }
}
