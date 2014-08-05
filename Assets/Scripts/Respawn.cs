using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour 
{
	public GameObject prefab;
	public int numberOfObjects = 5;
	public float radius = 5f;
	bool PickedUp = false;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag =="Pickup")
		{
			other.gameObject.SetActive(false);
			StartCoroutine(RespawnItem());
		}
	}

	IEnumerator RespawnItem ()
	{
		if(PickedUp)
		{
			PickedUp = true;
			int respawnTime = 1;
			yield return new WaitForSeconds(respawnTime);
			for (int i = 0; i < numberOfObjects; i++) 
			{
				float angle = i * Mathf.PI * 2 / numberOfObjects;
				Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
				Instantiate(prefab, pos, Quaternion.identity);
			}
			Debug.Log ("Spawned!");
		}
		
		PickedUp = false;
	}
}
