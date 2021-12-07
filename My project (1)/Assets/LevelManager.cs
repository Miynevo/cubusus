using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelManager : MonoBehaviour
{
    [System.Serializable]
    public class Level
    {
        public string LevelText;
        public bool IsIteractible;
        public int UnLocked;

        public Button.ButtonClickedEvent onClickEvent;
    }

    public GameObject LevelButton;
    public List<Level> LevelList;

    public Transform Spacer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
