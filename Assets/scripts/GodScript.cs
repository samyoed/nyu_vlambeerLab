using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GodScript : MonoBehaviour {

	public List<Transform> floorList = new List<Transform>();

	public Vector3 averageFloorLocation = Vector3.zero;

	public Vector3 sumFloorLocation;

	public int maxFloorNum = 500;

	public bool maxFloorsHit;

	public Transform pathMakerPrefab;

	
	// Update is called once per frame
	void Update ()
	{
		sumFloorLocation = Vector3.zero;
		foreach (Transform floorObject in floorList)
		{
			sumFloorLocation += floorObject.position;
		}

		averageFloorLocation = sumFloorLocation / floorList.Count;

		if (floorList.Count > maxFloorNum)
		{
			maxFloorsHit = true;
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			foreach (Transform floorThing in floorList)
			{
				Destroy(floorThing.gameObject);
				
			}
			floorList.Clear();
			maxFloorsHit = false;
			Instantiate(pathMakerPrefab, Vector3.zero, Quaternion.identity);
			averageFloorLocation = Vector3.zero;
		}
		
		
		
	}
}
