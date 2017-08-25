using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {
	public Transform Player;
	public Vector2 uiOffset;
	private RectTransform canvasRect;
	// Use this for initialization
	void Start () {
		//canvasRect = this.GetComponentInParent<RectTransform> ();
		//this.uiOffset = new Vector2 ((float)canvasRect.sizeDelta.x / 2f, (float)canvasRect.sizeDelta.y / 2f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = Player.position;
		Vector2 viewportPoint = Camera.main.WorldToViewportPoint (pos);

		this.GetComponent<RectTransform> ().anchorMin = viewportPoint;
		this.GetComponent<RectTransform> ().anchorMax = viewportPoint;
		//Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint (Camera.main, Player.position);
		//this.GetComponent<RectTransform> ().anchoredPosition = screenPoint - this.GetComponentInParent<RectTransform> ().sizeDelta / 2f;
		/*Vector3 pos;
		//Debug.Log (this.GetComponent<RectTransform> ());
		pos.x = Player.position.x;
		pos.y = Player.position.y;
		pos.z = Player.position.z;
		transform.position = pos;*/
		//Vector2 ViewportPosition = Camera.main.WorldToViewportPoint (Player.position);
		//Vector2 propotionalPosition = new Vector2 (ViewportPosition.x * canvasRect.sizeDelta.x, ViewportPosition.y * canvasRect.sizeDelta.y);

		//this.GetComponent<RectTransform> ().localPosition = propotionalPosition - uiOffset;
	}
}
