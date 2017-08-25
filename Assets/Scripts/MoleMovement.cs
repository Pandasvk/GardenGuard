using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMovement : MonoBehaviour {
	public MoleSpawner ms;
	private float lifeTime =0;
	public GameManager gm;
	// Use this for initialization
	void Start () {
		//ms = this.transform.parent.GetComponent<MoleSpawner> ();
		gm = GameObject.Find("Main Camera").GetComponent<GameManager>();
		lifeTime = Time.time + 10;
		//Debug.Log (lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.y <= -4.5) {
			transform.position = new Vector3 (transform.position.x, transform.position.y + 1 * Time.deltaTime, transform.position.z);

		}
			
		if (lifeTime <= Time.time) {
			ms.NegIsSpawned ();
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Projectile") {
			ms.NegIsSpawned ();
			gm.IncScore ();
			Destroy (other.gameObject);
			Destroy (this.gameObject);

		}
	}
}
