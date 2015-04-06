﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValue;

	void Start (){
		SpawnWaves ();
	}

	void SpawnWaves (){
		Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
		Quaternion spawnRotation = new Quaternion ();
		Instantiate ( hazard, spawnPosition, spawnRotation);
	}

}