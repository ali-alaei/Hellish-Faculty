using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackButtonHandler : MonoBehaviour
{

	public GameObject parentWall;
	// Use this for initialization
	void Start () {
        //Button backButton = gameObject.GetComponentInChildren<Button>();
        gameObject.GetComponent<Button>().onClick.AddListener(OnBack);
    }

    private void OnBack()
    {
	    //gameObject.SetActive(false);
	    this.transform.parent.gameObject.SetActive(false);
	    parentWall.SetActive(true);
        
    }
	

}
