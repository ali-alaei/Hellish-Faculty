using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackButtonHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button backButton = gameObject.GetComponentInChildren<Button>();
        backButton.onClick.AddListener(DestroyScene);
    }

    private void DestroyScene()
    {
        Destroy(gameObject);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
