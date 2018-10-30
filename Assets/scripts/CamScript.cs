using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{

	public GameObject godObject;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {

		if (float.IsNaN(godObject.GetComponent<GodScript>().averageFloorLocation.x) )
		{
			transform.position = new Vector3(0, 200f, 0);
		}
		else
		{
			transform.position = new Vector3(
				godObject.GetComponent<GodScript>().averageFloorLocation.x,
				transform.position.y,
				godObject.GetComponent<GodScript>().averageFloorLocation.z
			);
		}
	}
}
