using UnityEngine;
using UnityEngine.SceneManagement;
public class Welcome : MonoBehaviour
{
    public void StatGame()
    {
        SceneManager.LoadScene("LevelSelector");
    }
        
    
}
