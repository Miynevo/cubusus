using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{

    int levelLock;
    public Button[] levelbuttons;

    // Start is called before the first frame update
    void Start()
    {
        levelLock = PlayerPrefs.GetInt("LevelLock", 1);

        for (int i = 0; i < levelbuttons.Length; i++)
        {
            levelbuttons[i].interactable = false;
        }

        for (int i = 0; i < levelLock; i++)
        {
            levelbuttons[i].interactable = true;
        }
    }

    public void openLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

}
