using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollButtonHandler : MonoBehaviour {

    public GameObject DollCloseUp;
    // Use this for initialization
    void Start()
    {
        Button tableButton = gameObject.GetComponent<Button>();
        tableButton.onClick.AddListener(ZoomOnDoll);
    }

    private void ZoomOnDoll()
    {

        Instantiate(DollCloseUp);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
