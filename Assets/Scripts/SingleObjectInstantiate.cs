using UnityEngine;
using System.Collections;

public class SingleObjectInstantiate : MonoBehaviour 
{
	public GameObject prefab;

	// Use this for initialization
	void Start () 
	{
		Vector3 position = new Vector3(Random.Range(-5.0F, 5.0F), 0, Random.Range(-5.0F, 5.0F));
		Instantiate(prefab, position, Quaternion.identity);
	
	}

}
