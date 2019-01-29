using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NiddleButtonHandler : MonoBehaviour
{

	public InventoryManager gameInventory;

	private bool needleAdded;
	
	// Use this for initialization
	void Start () {
		Button objectButton = gameObject.GetComponent<Button>();
		objectButton.onClick.AddListener(AddToInventory);
		needleAdded = false;
	}

	void AddToInventory()
	{
		if (!needleAdded)
		{
			gameInventory.AddToInventoryList(gameObject);
			needleAdded = true;
			print("Added");
		}
	}
	
}
