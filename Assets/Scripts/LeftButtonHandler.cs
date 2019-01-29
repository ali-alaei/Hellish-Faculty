using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;
using UnityEngine.UI;

public class LeftButtonHandler : MonoBehaviour {

    public List<GameObject> walls = new List<GameObject>(4);
    // Use this for initialization
    void Start() {
        //first.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update() {

    }
    public void OnClick(int wallNumber)
    {
        //Output this to console when Button1 or Button3 is clicked
        switch (wallNumber)
        {
            case 1:
                walls[3].SetActive(true);
                walls[0].SetActive(false);
                break;
            case 2:
                walls[0].SetActive(true);
                walls[1].SetActive(false);
                break;
            case 3:
                walls[1].SetActive(true);
                walls[2].SetActive(false);
                break;
            case 4:
                walls[2].SetActive(true);
                walls[3].SetActive(false);
                break;
        }

        
    } 
}
