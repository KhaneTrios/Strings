//Trigger script created by Tony Dougal and Chandler Davis.

//Declarations
using UnityEngine;
using System.Collections;

public class triggers : MonoBehaviour
{	
	//Variables
	public static bool jumpBoostItem = false; 
	public static bool runSpeedItem = false;
	//public double isTalking = 0f;
	//public bool showGUI = false;
	public static float inTrigger;
	GameObject ParticleJump;
	public static float collectibles = 0f;


	void Start ()
	{
		jumpBoostItem = false;
		runSpeedItem = false;
	}

	void Update ()
	{
		//Call the Health script.
		GameObject Player = GameObject.Find("Player");
		Player.GetComponent<Health>();

		GameObject FriendlyNPC = GameObject.Find ("FriendlyNPC");
		FriendlyNPC.GetComponent<NPCInteraction>();
		
		//Call the Movement script
		Player.GetComponent<MovementScript>();

		//if (Input.GetKeyDown (KeyCode.E))
		//	GUI.Window (1, Rect (200, 100, 200), GUI.WindowFunction (), "Hello.");
	}

	//When the player enters a trigger.
	void OnTriggerEnter (Collider other)
	{
		//Log that the player has entered a trigger.
		Debug.Log("The player has entered a trigger.");
		
		//If the trigger is shrine.
		if(other.tag == "shrine")
		{
			//Set the damage value for shrine
			double heal = 10f;
			
			//Add the healing to the health.
			Health.health = Health.health + heal;	
		}
		
		//If the trigger is fire.
		if(other.tag == "fire")
		{
			//Set the damage value for fire
			double damage = 10f;
		
			//Subtract the damage from the health.
			Health.health = Health.health - damage;	
		}
		
		//If the trigger is jumpBoost.
		if(other.tag == "jumpBoost")
		{
			//If the player does not have the jumpBoost item.
			if(jumpBoostItem == false)
			{			
				//double the jumpSpeed variable.
				MovementScript.jumpSpeed *= 2;

				//notify script that player has the item.
				jumpBoostItem = true;


			}
				
			//If the player does have the jumpBoost item.
			if(jumpBoostItem == true)
			{
				//Do nothing.
				MovementScript.jumpSpeed *= 1;
				MovementScript.speed = MovementScript.speedDef;
			}	
		}	

		//if the trigger is runBoost.
		if (other.tag == "runBoost") {
			//If the player does not have the runBoost.
			if (runSpeedItem == false) {
				//double the speed variable
				MovementScript.speed *= 1.5f;
				
				//notift script that player has the item.
				runSpeedItem = true;
			}
			
			//If the player does have the runBoostItem.
			if (runSpeedItem == true) {
				//Do nothing.
				MovementScript.jumpSpeed *= 1;
				MovementScript.jumpSpeed = MovementScript.jumpSpeedDef;

			}


		}

		if (other.tag == "DoorEnd") {
			Application.LoadLevel("mainmenu");
		}

		if (other.tag == "collectible") {
			collectibles = + 1;
		}
		

	
			//if (other.tag == "FriendlyNPC") 
			//{

			//if (Input.GetKeyDown(KeyCode.E));
			//	{
			//	double isTalking = 1f;
			
				//new Rect (Screen.width * 0.5f - Screen.height * 0.3f, Screen.height * 0.5f - Screen.height * 0.3f, Screen.height * 0.6f, Screen.height * 0.6f);
			//	}
			//}

			if (other.tag == "FriendlyNPC") 
			{
				inTrigger = 1f;
			}
	}
	//When the player exits a trigger.
	void OnTriggerExit (Collider other)
	{
		if (other.tag == "FriendlyNPC") {
			inTrigger = 0f;
			NPCInteraction.continueToggle = 0f;

		}

		//Log that the player has exit a trigger.
		Debug.Log("The player has exited a trigger.");
	}

			

	//void OnGUI(){ 
		//if(!showGUI){ //if gui is off, ignore it return; }
					
//					GUI.Box(Rect(5,5,100,50),"GUI IS ON");
				//} }

}
	
