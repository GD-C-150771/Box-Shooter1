using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {
	public enum rotate
	{
		forward,
		backward,
		up,
		down
	};
	public float spinspeed=180.0f;
	private Transform mover;
	public rotate RotateAround = new rotate ();

	void Start () {
		mover = gameObject.transform;
	}
	
	void Update () {
		if (RotateAround==rotate.forward) 
      	mover.Rotate (Vector3.forward * spinspeed * Time.deltaTime);
	if(RotateAround==rotate.backward)
			mover.Rotate (Vector3.back * spinspeed * Time.deltaTime);
		if(RotateAround==rotate.up)
			mover.Rotate (Vector3.up * spinspeed * Time.deltaTime);
		if(RotateAround==rotate.down)
			mover.Rotate (Vector3.down * spinspeed * Time.deltaTime);
	}
}

