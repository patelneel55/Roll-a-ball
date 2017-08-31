using UnityEngine;
using System.Collections;

public class CamControl : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position;	
	}
	
	// LateUpdate is called once per frame but runs after all items of update
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
