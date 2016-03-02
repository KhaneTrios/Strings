//Player attack script by Tony Dougal.

//Declarations
using UnityEngine;
using System.Collections;

//Main functions
public class playerAttack : MonoBehaviour
{
	//Updates every frame.
	void Update()
	{	
		//if the k button is pressed
		if (Input.GetButton("meleeAttack"))
		{	
			//make the player attack
			attack();			
		}	
	}
	
	//Attacking function
	void attack()
	{
		//Change the player's tag to the attack tag.
		gameObject.tag = "playerAttackRange";
		
		//reset the player's tag 
		Invoke("attackEnd", 1);
	}	
	
	//Switching from attack mode to player mode
	void attackEnd()
	{
		//reset the player's tag
		gameObject.tag = "Player";
	}	
}

//bababooey