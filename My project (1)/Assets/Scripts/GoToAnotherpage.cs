using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToAnotherpage : MonoBehaviour
{

    public void LevelSelect01()
    {
        SceneManager.LoadScene("LevelSelector 1");
    }

    public void LevelSelect02()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
