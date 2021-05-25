using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersBullet : MonoBehaviour
{
    BulletManager bulletManager;

    public float fireSpeed = 15;

    [SerializeField] bool firedFromPlayer = false;

    private void Start()
    {
        bulletManager = GameObject.FindObjectOfType<BulletManager>().GetComponent<BulletManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player") && firedFromPlayer)
        {
            this.gameObject.SetActive(false);
            bulletManager.PlayerAddBullet(this.gameObject);
        }
    }

    private void OnEnable()
    {
        StartCoroutine(ResetTheBullet());
    }

    IEnumerator ResetTheBullet()
    {
        yield return new WaitForSeconds(3);
        this.gameObject.SetActive(false);
        bulletManager.PlayerAddBullet(this.gameObject);
    }
}
