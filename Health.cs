//Health Script created by Tony Dougal and Chandler Davis

//Declarations
using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
	//Variable that stores the health.
	public static double health = 100f;
	public static double maxHealth = 100f;




	// Update is called once per frame
	void Update () 
	{

		//GUI.HorizontalScrollbar(Rect (0,40,200,20), 0, "health",0, 100);




		//If the player is alive.
		if (health >= 1)
			//Display total health in the Debug Log.
			Debug.Log("Player has a total health of: " + health + "/" + maxHealth);
		
		//If the player runs out of health.
		else if (health <= 0)
		{
			Debug.Log("The player is dead.");
			
			//Perform the die function after a timer.
			GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;

			Invoke ("die", 3);
		}
	}
	
	//The function for when the player dies
	void die()
	{

		//Restart the level
		Application.LoadLevel (Application.loadedLevel);

	}

	void Start()
	{
		//Restart the variables.
		health = 100f;
	}



}