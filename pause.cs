using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	public int fontsize = 10;

	// Use this for initialization
	void Start () {
		GameObject Player = GameObject.Find("Player");
		
		//Call the Movement script
		Player.GetComponent<MovementScript>();
		Player.GetComponent<triggers>();
	}
	
	// Update is called once per frame
	
		bool paused = false;
		
		void Update()
		{
			if(Input.GetButtonDown("Cancel"))
				paused = togglePause();
		}
		
		void OnGUI()
		{
			if(paused)
			{
				//GUI.skin.label.fontSize = fontsize;
				GUI.Label(new Rect(290, 100, 100, 50), "Paused!");
				GUI.Label(new Rect(300, 120, 100, 50), "Collectibles: " + triggers.collectibles, "/1" );
				if(GUI.Button(new Rect(200, 160, 100, 50), "Resume"))
					paused = togglePause();
				else if(GUI.Button(new Rect(310, 160, 100, 50), "Quit"))
					Application.LoadLevel("mainmenu");
				
				

			}
		}
		
		bool togglePause()
		{
			if(Time.timeScale == 0f)
			{
				Time.timeScale = 1f;
				return(false);
			}
			else
			{
				Time.timeScale = 0f;
				return(true);    
		}
	}
}
	