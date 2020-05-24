using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : Shooter
{
    void Start()
    {
        totalShooter = 1.0f;
        poolBullets = new List<GameObject>();
        sound = SoundController.Sounds.ENEMY_FIRE;
    }

    override protected void generateBullet()
    {
        //print("Hola desde el Enemy");
        Vector3 temp = transform.position;
        float height = gameObject.GetComponent<BoxCollider2D>().bounds.size.y * 0.75f;
        temp.y -= height;
        playSound();
        CreateBullet(temp, velocityBullet);
    }
}
