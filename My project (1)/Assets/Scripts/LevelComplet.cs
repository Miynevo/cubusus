using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplet : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("LevelSelector");
    }
    
}
