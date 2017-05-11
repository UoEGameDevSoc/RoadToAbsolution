using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{

	//Standard player speed
	public float speed = 2f;
	//Multiplier to speed when sprinting
	public float sprintSpeedMod = 1.5f;
	//Multiplier to speed when sneaking
	public float sneakSpeedMod = 0.5f;

	//Standard speed modifier
	[SerializeField]
	private float speedMod = 1;
	//The rigidbody
	private Rigidbody2D rb2d;
	//Whether or not the player is sneaking
	private bool sneaking = false;
			   
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}


	void Update()
	{

		if (Input.GetAxis ("Sprint") != 0f) {
			speedMod = sprintSpeedMod;
			sneaking = false;
		} else if (Input.GetButtonDown ("ToggleSneak"))
			sneaking = !sneaking;
		else
			speedMod = 1f;

		if (sneaking)
			speedMod = sneakSpeedMod;

		float x = Input.GetAxisRaw ("Horizontal")*speed*speedMod*Time.fixedDeltaTime;
		float y = Input.GetAxisRaw ("Vertical")*speed*speedMod*Time.fixedDeltaTime;

		transform.position += new Vector3 (x, y, 0f);

	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{



	}

}