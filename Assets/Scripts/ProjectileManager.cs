using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour {
	public float LifeTime;
	private float TimeLimit;
	// Use this for initialization
	void Start () {
		TimeLimit = Time.time + LifeTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeLimit <= Time.time) {
			Destroy (this.gameObject);
		}
	}
}
