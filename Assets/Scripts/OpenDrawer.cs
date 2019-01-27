using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDrawer : MonoBehaviour {
    public List<Sprite> drawerImages;
    private Button[] drawerButtons;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < GetComponentsInChildren<Button>().Length; i++)
        {
            drawerButtons = GetComponentsInChildren<Button>();
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
