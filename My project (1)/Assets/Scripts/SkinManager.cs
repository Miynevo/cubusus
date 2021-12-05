
using UnityEngine;
using System.Collections.Generic;

public class SkinManager : MonoBehaviour
{
    [SerializeField] private PlayerSkin playerSkin;

    public List<Material> skins;
    private static int skinIndex = 0;
    public GameObject Player;
    public void switchSkinright()
    {
        if (skinIndex > skins.Count - 1)
            skinIndex = 0;
        Player.GetComponent<MeshRenderer>().material = skins[skinIndex++];
    }

    public void switchSkinleft()
    {
        if (skinIndex < 0)
            skinIndex = skins.Count - 1;
        Player.GetComponent<MeshRenderer>().material = skins[skinIndex--];
    }

    public void Awake()
    {
        Player.GetComponent<Rigidbody>().useGravity = false;
        Player.GetComponent<PlayerMovement>().enabled = false;
        Player.GetComponent<PlayerCollision>().enabled = false;
        Player.GetComponent<Socre>().enabled = false;
    }
}
