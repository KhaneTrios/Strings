using UnityEngine;
using System.Collections;

public class NPCInteraction : MonoBehaviour 
{
	public bool doWindow0 = true;

//	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text); 
//	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image); 
//	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content); 
//	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style); 
//	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style); 
//	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style); 


	public Rect windowRect0 = new Rect(40, 40, 200, 75);
	public Rect windowRect1 = new Rect(2000, 10000, 10020, 5000);
	public Rect npcText3= new Rect(75, 75, 200, 75);
	public static float continueToggle = 0f; 
	public string stringToEdit = "Hey Stranger, you don’t look like you’re from around these parts.\n If you haven’t noticed, things aren’t going to well around here.\n";
	public string stringToEdit2 = "The Puppet Master, has been destroying all puppets who oppose him.\n He intends on having the perfect population of obedient puppets.\n";
	public string stringToEdit3 = "If you still plan on continuing and helping us then there’s some things you should know.";
	public string stringToEdit4;
	public float continueView = 0f;
	//public float inTrigger;




	// Use this for initialization
	void Start () 
	{
		triggers.inTrigger = 0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//		Debug.Log (isTalking);
		
		//Call the Health script.
		GameObject Player = GameObject.Find("Player");
		
		//Call the Movement script
		Player.GetComponent<MovementScript>();
		Player.GetComponent<triggers>();

		Debug.Log(triggers.inTrigger);
		Debug.Log(continueToggle);
	}

	void OnGUI() 
	{

		if (Input.GetButton("use") && triggers.inTrigger == 1f) 
		{

			continueView = 1f;

			if (continueView == 1f)
			{
			//GUI.color = Color.white;
			//windowRect0 = GUI.Window (0, windowRect0, DoMyWindow, "Friendly NPC");

//			npcText3 = GUI.TextArea(3, npcText3, DoMyWindow, "Hello there stranger.");
			DoMyWindow (0);
			stringToEdit = GUILayout.TextArea(stringToEdit, 200);
			}

		}
		//GUI.color = Color.green;
		//windowRect1 = GUI.Window (1, windowRect1, DoMyWindow, "Green Window");

	}


	void DoMyWindow(int windowID) 
	{
		if (GUI.Button (new Rect (30, 50, 75, 75), "Continue") || Input.GetButton("continue")) 
		{
			continueToggle = continueToggle + 1f;

			print ("Got a click in window with color " + GUI.color);
		
			//GUI.DragWindow (new Rect (500, 500, 500, 500));

			if (continueToggle == 0f)
			{
				stringToEdit = GUILayout.TextArea(stringToEdit, 200);
			}

			if (continueToggle == 1f) 
			{
				//npcText = GUI.TextArea (npcText, "YOu don't look like you're from around these parts.");
				stringToEdit = GUILayout.TextArea(stringToEdit2, 200);
				//stringToEdit = new Rect(75, 75, 200, 75);
			}

			if (continueToggle == 1f) 
			{
				//npcText = GUI.TextArea (npcText, "YOu don't look like you're from around these parts.");
				stringToEdit = GUILayout.TextArea(stringToEdit3, 200);
				//stringToEdit = new Rect(75, 75, 200, 75);
				
			}
		}
	}

	//void OnTriggerEnter (Collider other)
	//{
	//	if (other.tag == "FriendlyNPC") 
	//	{
	//		inTrigger = 1f;
	//	}
	//}
}


