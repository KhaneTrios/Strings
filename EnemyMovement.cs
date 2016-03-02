using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
//	private Vector3 point1 = -3.46;
	//public float point2 = 3.19f;
	public float movementSpeed = 2;
	///public float MinDist = 5;
	///public float MaxDist = 10;
	public float playerInSight = 0;
	public GameObject curPlayer;
	public Vector3 playerPos;
	public Time Timer;

	// Sprite Declarations
	///public Texture spider_walk1;
	///public Texture spider_walk2;
	///public Texture spider_idle1;


	//public timer = 


	// Use this for initialization
	void Start () 
	{
		curPlayer = GameObject.FindGameObjectWithTag("Player");


		
		//move ();

			move();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		playerPos = curPlayer.transform.position;
		//while (playerInSight == 0) {
			
		//}
//		if (transform.position.x)
		//{
		//	renderer.material.mainTexture = spider_walk1;
		//}

		if (playerInSight != 0) {
		follow();
		}

			//moveRight ();

			///Invoke ("moveLeft", 3);
		//}
	}
	
	void move()
	{
		//while (playerInSight == 0) {
			transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
			//if (Vector3.Distance == (point1))

			//Invoke ("delay", 3);

			//transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);
		//}
	}



	void follow()
	{
		//if (Vector3.Distance (transform.position, Player.) >= MinDist) 
		////{
			
			//transform.Translate (playerPos * movementSpeed * Time.deltaTime);
		////}
	}

	void OnTriggerEnter (Collider  Player)
	{
		playerInSight = 1;
	}

	void delay()
	{
//		Timer = Time.deltaTime * 2;
	}
}
