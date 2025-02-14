

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public GameObject CompleteLevelUI;

    public void Completelevel ()
    {
        CompleteLevelUI.SetActive(true);
    }
    
    
    public void Endgame()
    {
       if(GameEnded == false)
        {
            GameEnded = true;
            UnityEngine.Debug.Log("Game Over");
            Invoke("Restart", 1.5f);
        }

        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
