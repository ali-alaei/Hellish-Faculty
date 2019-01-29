using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZoomButtonHandler : MonoBehaviour {
    public GameObject closeUpObject;

    // Use this for initialization
    void Start()
    {
        Button objectButton = gameObject.GetComponent<Button>();
        objectButton.onClick.AddListener(ZoomIn);
    }

    private void ZoomIn()
    {
       transform.parent.gameObject.SetActive(false);
       closeUpObject.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
