using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public GameObject klb ;
	private Vector3 oldPos;
	private Vector3 zmena;
	public GameManager gm;
	public GameObject Projectile;
	private float ShootTime;

	// Use this for initialization
	void Start () {
		oldPos = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		ShootTime = Time.time + 2;
	}

	// Update is called once per frame
	void Update () {
		if ( Time.time >= ShootTime) {
			//Debug.Log ("Shooting");
			Shoot ();
			ShootTime = Time.time +2;
		}
		if (klb) {
			zmena = new Vector3 (klb.transform.position.x - oldPos.x, klb.transform.position.y - oldPos.y, 0);
			if (oldPos.x + zmena.x * 10 <= 360 && oldPos.x + zmena.x * 10 >= -360 && oldPos.y +zmena.y *10 <= 175 && oldPos.y + zmena.y*10 >= -175) {
				transform.position = oldPos + zmena * 10;
			}
		}


	}

	void Shoot(){
		Vector3 pos ;
		pos.x = transform.position.x;
		pos.y = transform.position.y;
		pos.z = transform.position.z;
		Debug.Log (pos.x+ " " + pos.y + " "+ pos.z);
		GameObject ProjectileClone = Instantiate (Projectile,pos,transform.rotation)as GameObject;
		ProjectileClone.GetComponent<Rigidbody> ().AddForce (0, 1,20, ForceMode.Impulse);
	}
}
