using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{   
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject CompleteLevelUI;

    public void CompleteLevel ()
    {
        Debug.Log("YASS");
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
