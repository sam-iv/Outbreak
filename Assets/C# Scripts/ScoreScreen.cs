using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScreen : MonoBehaviour
{
    public TMP_Text score1;
    public TMP_Text score2;
    public TMP_Text score3;

    // Start is called before the first frame update
    void Start()
    {
        score1.text = PlayerPrefs.GetInt("highScore1").ToString();
        score2.text = PlayerPrefs.GetInt("highScore2").ToString();
        score3.text = PlayerPrefs.GetInt("highScore3").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
