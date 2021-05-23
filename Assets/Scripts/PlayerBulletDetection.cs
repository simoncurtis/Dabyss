using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player") && collision != null)
        {
            Debug.Log("explode the bullet");
        }
    }
}
