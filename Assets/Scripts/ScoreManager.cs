using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTxt;
    public int score;
    private void Start()
    {
        GameEvents.instance.EnemyDead += UpdateScore;
        GameEvents.instance.EnemyDead += heuoaud;
    }
    public void UpdateScore()
    {
        score += 10;
        scoreTxt.text = score.ToString();
    }
    public void heuoaud()
    {

    }
    private void OnDestroy()
    {
        GameEvents.instance.EnemyDead -= UpdateScore;
    }
}
