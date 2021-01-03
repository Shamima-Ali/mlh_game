using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    public static int scoreNumber = 0;
    public GameObject WinText;
    public float restart = 3f;


    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "score: " + scoreNumber +"/45";
        if (scoreNumber < 0)
        {
            FindObjectOfType<EndGameScript>().GameOver();
        }

        if(scoreNumber == 45)
        {
            WinText.SetActive(true);
            StartCoroutine(FindObjectOfType<EndGameScript>().Restart());
        }
    }
}
