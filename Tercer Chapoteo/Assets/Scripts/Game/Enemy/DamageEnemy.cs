using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public void kill()
    {
        gameObject.SetActive(false);
        SoundController.instance.playSound(SoundController.Sounds.ENEMY_EXPLOSION);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            kill();
        }
    }
}
