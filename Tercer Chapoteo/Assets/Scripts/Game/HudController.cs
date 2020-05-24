using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public static HudController instance;
    private int lifes;
    private int score;
    private float time;
    [SerializeField]
    private Text txtScore;
    [SerializeField]
    private Text txtTime;
    private void Awake()
    {
        instance = this;
        score = 0;
        lifes = GameObject.FindGameObjectsWithTag("Live").Length;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        updateTime();
    }

    public void UpdateScore(int _score)
    {
        score += _score;
        txtScore.text = score.ToString();
    }

    private void updateTime()
    {
        int min = (int)time / 60;
        int sec = (int)time % 60;
        txtTime.text = (min < 10 ? "0" + min.ToString() : min.ToString()) + ":" + (sec < 10 ? "0" + sec.ToString() : sec.ToString());
    }

    public void reduceLife()
    {
        if (lifes > 0)
        {
            GameObject ga = GameObject.FindGameObjectWithTag("Live");
            ga.SetActive(false);
            lifes--;
        }

        if (lifes == 0)
        {
            print("ME MORI :'v");
        }
    }
}
