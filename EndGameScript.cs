using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            if (ScoreCode.scoreNumber < 0 || LifeScript.lifeNumber <= 0)
            {
                Restart();
            }else
            {
                Invoke("Restart", restartTime);
            }

            
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
