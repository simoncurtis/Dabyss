using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    Transform firePoint;

    public List<ParticleSystem> firingParticles;

    public enum ActiveWeapon
    {
        GENERIC,
        SPECIAL
    }
    public ActiveWeapon curWeapon;


    void Start()
    {
        firePoint = GameObject.Find("FirePoint").transform;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            switch (curWeapon)
            {
                case ActiveWeapon.GENERIC:
                    firingParticles[0].Play();
                    break;

                case ActiveWeapon.SPECIAL:

                    break;
            }
        }   
    }
}
