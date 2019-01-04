using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZoomButtonHandler : MonoBehaviour {
    public GameObject closeUpObject;

    // Use this for initialization
    void Start()
    {
        Button tableButton = gameObject.GetComponent<Button>();
        tableButton.onClick.AddListener(ZoomIn);
    }

    private void ZoomIn()
    {

        Instantiate(closeUpObject);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
