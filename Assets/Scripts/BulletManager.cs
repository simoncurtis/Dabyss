using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [System.Serializable]
    public class PooledBullets
    {
        public List<GameObject> bulletPool = new List<GameObject>();

        public List<GameObject> usedBullets = new List<GameObject>();
    }

    public PooledBullets[] pooledBullets;

    public void PlayerRemoveBullet(GameObject bul)
    {
        pooledBullets[0].bulletPool.Remove(bul);
        pooledBullets[0].usedBullets.Add(bul);
    }

    public void PlayerAddBullet(GameObject bul)
    {
        pooledBullets[0].usedBullets.Remove(bul);
        pooledBullets[0].bulletPool.Add(bul);
    }

    public void BossRemoveBullet(GameObject bul)
    {
        pooledBullets[1].bulletPool.Remove(bul);
        pooledBullets[1].usedBullets.Add(bul);
    }

    public void BossAddBullet(GameObject bul)
    {
        pooledBullets[1].usedBullets.Remove(bul);
        pooledBullets[1].bulletPool.Add(bul);
    }
}
