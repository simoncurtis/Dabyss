using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    Transform firePoint;

    public List<ParticleSystem> firingParticles;

    BulletManager bulletManager;

    float timer;
    [SerializeField] float timeBeforeNextFire;
    float fireCD = 1;

    bool canShoot = true;

    bool facingRight = true;

    public enum ActiveWeapon
    {
        GENERIC,
        SPECIAL
    }
    public ActiveWeapon curWeapon;

    void Start()
    {
        firePoint = GameObject.Find("FirePoint").transform;

        bulletManager = GameObject.FindObjectOfType<BulletManager>().GetComponent<BulletManager>();

    }

    void Update()
    {
        switch (curWeapon)
        {
            case ActiveWeapon.GENERIC:
                

                if(Input.GetKey(KeyCode.Mouse0) && canShoot)
                {
                    StartCoroutine(Shoot());
                }



                break;

            case ActiveWeapon.SPECIAL:

                break;
        }
    }

    IEnumerator Shoot()
    {
        canShoot = false;

        GameObject firedBullet = bulletManager.pooledBullets[0].bulletPool[0];

        firedBullet.transform.position = this.transform.position;

        firedBullet.transform.rotation = firePoint.transform.rotation;

        firedBullet.SetActive(true);

        firedBullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * firedBullet.GetComponent<PlayersBullet>().fireSpeed, ForceMode2D.Impulse);

        bulletManager.PlayerRemoveBullet(firedBullet);

        yield return new WaitForSeconds(timeBeforeNextFire);

        canShoot = true;
    }
}
