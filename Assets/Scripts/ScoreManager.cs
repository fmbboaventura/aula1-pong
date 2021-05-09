using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textP1;
    public Text textP2;

    private int scorePl = 0;

    private int scoreP2 = 0;

    private static ScoreManager _instance;

    public static ScoreManager SharedInstance
    {
        get{
            return _instance;
        }
    }

    void Awake(){
        if (_instance == null) _instance = this;
    }

    public void IncrementarScore(int player) {
        if (player == 1) {
            scorePl++;
            textP1.text = scorePl.ToString();
        }
        else {
            scoreP2++;
            textP2.text = scoreP2.ToString();
        }
    }
}
