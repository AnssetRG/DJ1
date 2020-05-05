using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public enum Sounds { PLAYER_FIRE, PLAYER_EXPLOSION, ENEMY_FIRE, ENEMY_EXPLOSION, POWER_UP }
    public static SoundController instance;

    [SerializeField]
    private List<AudioClip> sounds;
    [SerializeField]
    private AudioSource reproducer;
    void Awake()
    {
        instance = this;
        reproducer = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void playSound(Sounds sound)
    {
        reproducer.clip = sounds[(int)sound];
        reproducer.Play();
    }
}
