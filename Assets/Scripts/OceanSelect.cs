using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanSelect : MonoBehaviour {

	private DisplayMap displayMap;
	// Use this for initialization
	void Start () {
		displayMap = GameObject.Find("Map").GetComponent<DisplayMap>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver()
	{
		int x = (int)this.transform.position.x;
		int y = (int)this.transform.position.z;
		displayMap.Hit(x,y);
		Debug.Log("Selecting Ocean: " + x + "," + y);
	}

	void OnMouseEnter()
	{
		Debug.Log("Entering Tile");
	}
}
