using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TableButtonHandler : MonoBehaviour {

    public GameObject TableCloseUp;
	// Use this for initialization
	void Start () {
        Button tableButton = gameObject.GetComponent<Button>();
        tableButton.onClick.AddListener(ZoomOnTable);	
	}

    private void ZoomOnTable()
    {

        Instantiate(TableCloseUp);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
