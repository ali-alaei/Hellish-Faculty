using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HangerButtonHandler : MonoBehaviour {

    public GameObject hangerCloseShot;
    

	// Use this for initialization
	void Start () {
        Button hangerButton = gameObject.GetComponent<Button>();
        hangerButton.onClick.AddListener(ZoomOnHanger);
	}

    private void ZoomOnHanger()
    { 
        Instantiate(hangerCloseShot);
    }

   
	
	// Update is called once per frame
	void Update () {
		
	}
}
