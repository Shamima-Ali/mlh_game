using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeScript : MonoBehaviour
{
    public static int lifeNumber = 3;
    public GameObject DiedText;

    Text life;
    // Start is called before the first frame update
    void Start()
    {
        life = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        life.text = "lives: " + lifeNumber;
        if (lifeNumber < 1)
        {
            DiedText.SetActive(true);
            StartCoroutine(FindObjectOfType<EndGameScript>().Restart());
        }
    }
}
