using UnityEngine;
using UnityEngine.SceneManagement;

public class Skins : MonoBehaviour
{
    public void SkinShop()
    {
        SceneManager.LoadScene("SkinsMenu");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }


}
