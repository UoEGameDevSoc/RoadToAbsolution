using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTurret : MonoBehaviour {

	public float rotateSpeed = 0.5f;

	private float initRotation;

	// Use this for initialization
	void Start () {
		initRotation = transform.rotation.z;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3 (0, 0, rotateSpeed*Time.deltaTime));
	}
}
