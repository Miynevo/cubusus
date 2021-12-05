using UnityEngine;

public class PlayerSkin : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    void Start()
    {
       meshRenderer = GetComponent<MeshRenderer>(); 
    }

}
