//Spider script created by Tony Dougal
using UnityEngine;
using System.Collections;

//Main functions
public class spider1 : MonoBehaviour
{	
	//variables
	public static double health = 5d;
	
	//Runs when the level restarts
	void Start()
	{
		//reset the values
		health = 5d;
	}	

	//Functions runs every frame.
	void Update()
	{
		//Call the player gameobject.
		GameObject player = GameObject.Find("Player");
		
		//Call the health script.
		player.GetComponent<Health>();

		//Call the damage script.
		player.GetComponent<damage>();	

		//Display the spider 1 health.
		Debug.Log("Spider 1 health = " + health);
		
		//If the spider's health drops to zero.
		if(health <= 0)
		{
			//Log that the spider has died.
			Debug.Log("Spider 1 has died");

			//Destroy the spider game object.
			Destroy(gameObject);			
		}
	}
	
	//When the spider enters a trigger.
	void OnTriggerEnter (Collider other)
	{
		//Log that the spider has entered a trigger
		Debug.Log("Spider has entered a trigger");

		//If the spider hits the player
		if(other.tag == "Player")
		{			
			//Subtract spider damage from player health.
			Health.health = Health.health - damage.spiderDamage;			
		}
		
		//If the spider hits the player's attack range.
		else if(other.tag == "playerAttackRange")
		{
			//Subtract the damage from the health
			health = health - damage.playerDamage;
		}	
	}
}	
		
	
	
	