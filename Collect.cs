using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject Player = GameObject.Find("Player");
		
		//Call the trigger script
		Player.GetComponent<triggers>();
	}
	
	// Update is called once per frame
	void Update () {
		if (triggers.collectibles >= 1) {
			Destroy(gameObject);
	}
}
}