using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<GameObject> walls = new List<GameObject>(4);

    // Use this for initialization
    void Awake () {
        Instantiate(walls[0]);
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
