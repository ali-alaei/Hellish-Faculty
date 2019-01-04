using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightButtonHandler : MonoBehaviour
{

    public List<GameObject> walls = new List<GameObject>(4);
    // Use this for initialization
    void Start()
    {
        //first.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick(int wallNumber)
    {
        //Output this to console when Button1 or Button3 is clicked
        switch (wallNumber)
        {
            case 1:
                Instantiate(walls[1], new Vector3(0, 0, 0), Quaternion.identity);
                Destroy(walls[0]);
                break;
            case 2:
                Instantiate(walls[2], new Vector3(0, 0, 0), Quaternion.identity);
                Destroy(walls[1]);
                break;
            case 3:
                Instantiate(walls[3], new Vector3(0, 0, 0), Quaternion.identity);
                Destroy(walls[2]);
                break;
            case 4:
                Instantiate(walls[0], new Vector3(0, 0, 0), Quaternion.identity);
                Destroy(walls[3]);
                break;
        }
     


    }
}
