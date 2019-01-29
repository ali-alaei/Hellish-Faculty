using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackButtonHandler : MonoBehaviour
{

	public GameObject parentWall;
	// Use this for initialization
	void Start () {
        Button backButton = gameObject.GetComponentInChildren<Button>();
        backButton.onClick.AddListener(DestroyScene);
    }

    private void DestroyScene()
    {
	    gameObject.SetActive(false);
	    parentWall.SetActive(true);
        
    }
	

}
