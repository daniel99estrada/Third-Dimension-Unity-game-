using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextLevel()
    {   
        Debug.Log("NEXT LEVEL");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
