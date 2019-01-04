using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VaseButtonHandler : MonoBehaviour {
    public GameObject VaseCloseUp;

    // Use this for initialization
    void Start()
    {
        Button tableButton = gameObject.GetComponent<Button>();
        tableButton.onClick.AddListener(ZoomOnVase);
    }

    private void ZoomOnVase()
    {

        Instantiate(VaseCloseUp);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
