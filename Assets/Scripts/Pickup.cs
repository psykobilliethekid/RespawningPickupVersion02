using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour 
{

	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag =="Pickup")
		{
			Destroy(other);
		}
	}
}
