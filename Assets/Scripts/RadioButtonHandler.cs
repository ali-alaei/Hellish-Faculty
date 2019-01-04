using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioButtonHandler : MonoBehaviour {

    public GameObject radioCloseUp;
	// Use this for initialization
	void Start () {
        Button radioButton = gameObject.GetComponent<Button>();
        radioButton.onClick.AddListener(ZoomOnRadio);		
	}
	
    private void ZoomOnRadio()
    {
        Instantiate(radioCloseUp);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
