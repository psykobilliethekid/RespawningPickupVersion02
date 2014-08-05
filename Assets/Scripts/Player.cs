using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float movementSpeed = 5.0f;
	CharacterController character;


	public GameObject prefab;
	public float positionX = 3f;
	public float positionY = 3f;
	 
	bool PickedUp = false;
	
	// Update is called once per frame
	void Update () 
	{
		//Get the Character Controller//
		CharacterController character = GetComponent<CharacterController>();

		//Character Movement//
		float FBSpeed = Input.GetAxis("Vertical") * movementSpeed; //forward and back movement
		float LRSpeed = Input.GetAxis("Horizontal") * movementSpeed; //left and right movement

		Vector3 speed = new Vector3(LRSpeed, 0, FBSpeed); //get the Vector for the speed
		speed = transform.rotation * speed;  //storing the speed
		character.Move(speed * Time.deltaTime); //get the character movement speed

	}
	 
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag =="Pickup")
		{
			PickedUp = true;
			other.gameObject.SetActive(false);
			Invoke("RandomCube", 3);
		}
	}
	
	void RandomCube()
	{
		Vector3 position = new Vector3(Random.Range(-5.0F, 5.0F), 0, Random.Range(-5.0F, 5.0F));
		Instantiate(prefab, position, Quaternion.identity);
	}
}
	

