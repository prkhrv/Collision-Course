using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;


   public void EndGame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("FCK");
    }





}




