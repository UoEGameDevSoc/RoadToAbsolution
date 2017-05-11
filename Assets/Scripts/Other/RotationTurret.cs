using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTurret : MonoBehaviour {

	public float rotateSpeed;
	public float rotateAngle;

	private float initRotation;
	private float currentRotation;

	// Use this for initialization
	void Start () {
		initRotation = transform.rotation.z;
		print (initRotation);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3 (0, 0, rotateSpeed*Time.deltaTime));
		currentRotation = transform.rotation.z;
		if (initRotation + rotateAngle < currentRotation) {
			rotateSpeed = -Mathf.Abs (rotateSpeed);
		} else if (initRotation > currentRotation) {
			rotateSpeed = Mathf.Abs (rotateSpeed);
		}
	}
}
