using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// some code from Brackeys, Muddy Wolf


public class EndGameScript : MonoBehaviour
{
    bool gameEnded = false;
    public float restartTime = 2f;
    // Start is called before the first frame update
    public void GameOver()
    {
        if (gameEnded == false)
        {
            Debug.Log("Game Overrrrr!");
            gameEnded = true;
          
            Restart();
           

            
        }
    }

    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(1f);
         ScoreCode.scoreNumber = 0;
         LifeScript.lifeNumber = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
