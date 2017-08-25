using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour {
	public GameObject moles;
	protected float nextSpawnTime;
	public float spawnTimer;
	protected bool isSpawned=false;
	// Use this for initialization
	void Start () {
		spawnTimer = Random.Range (2,10);
		nextSpawnTime = spawnTimer + Time.time;
		//Debug.Log (nextSpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= nextSpawnTime && !GetIsSpawned()) {
			PosIsSpawned ();
			SpawnMole ();
			Debug.Log (spawnTimer);
		}

	}

	public void NegIsSpawned(){
		Debug.Log (spawnTimer);
		nextSpawnTime = spawnTimer + Time.time;
		isSpawned = false;

	}

	public void PosIsSpawned(){
		isSpawned = true;
	}

	public bool GetIsSpawned(){
		return isSpawned;
	}

	void SpawnMole(){
		Vector3 pos;
		pos.x = this.gameObject.transform.position.x;
		pos.z = this.gameObject.transform.position.z;
		pos.y = -6;
		GameObject spwnedMole = Instantiate (moles,pos,transform.rotation) as GameObject;
	}
}
