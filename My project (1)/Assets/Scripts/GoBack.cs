using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public void goBack()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
