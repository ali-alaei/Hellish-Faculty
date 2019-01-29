using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	// Use this for initialization
	private List<GameObject> InventoryList = new List<GameObject>();

	public void AddToInventoryList(GameObject clickedGameObject)
	{
		InventoryList.Add(clickedGameObject);
		print("size = " + InventoryList.Count);
		
	}
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print("size = " + InventoryList.Count);

		
	}
}
