//Puzzle Trigger script created by Tony Dougal and Chandler Davis.

//Declarations.
using UnityEngine;
using System.Collections;

//Main functions
public class puzzleTriggers : MonoBehaviour
{
	//Variables
	//Levers that are permanentaly on or off.
	public static bool lever1 = true;
	
	//Pressure plates that are temperarily on.
	public static bool pressurePlate1 = true;
	
	//Levers that open only 1 of 2 doors at a time.
	public static bool leverAB1 = true;
	
	//When the program starts;
	void Start()
	{
		//Reset the values.
		lever1 = true;
		leverAB1 = true;
		pressurePlate1 = true;
	}
	
	//When the player enters a trigger.
	void OnTriggerEnter (Collider other)
	{
		//if the trigger is lever1.
		if(other.tag == "lever1")
		{
			//If the lever was off before being activated.
			if(lever1 == false)
			{
				//Log that the lever was turned on.
				Debug.Log("lever 1 = on");
				
				//Switch the lever to on.
				lever1 = true;
			}
			
			//If the lever was on before being activated.
			else if(lever1 == true)
			{
				//Log that the lever was turned off.
				Debug.Log("lever 1 = off");
				
				//Switch the lever to off.
				lever1 = false;
			}	
		}
		
		//If the trigger is leverA1
		if(other.tag == "leverAB1")
		{
			//If Lever AB1 = false
			if(leverAB1 == false)
			{
				//Log that lever AB1 was set to true.
				Debug.Log("Lever AB1 = True");
				
				//Set lever AB to true
				leverAB1 = true;
			}

			else if(leverAB1 == true)
			{
				//Log that lever AB1 was set to false.
				Debug.Log("Lever AB1 = false");
				
				//Set the lever AB to false
				leverAB1 = false;
			}	
		}
	} //bababooey
}	
		
		