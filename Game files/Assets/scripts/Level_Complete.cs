
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete : MonoBehaviour
{
    
    public void LoadNewLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
