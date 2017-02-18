using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{

	public float speed = 2f;
	public float sprintSpeedMod = 1.5f;
	public float sneakSpeedMod = 0.5f;
	[SerializeField]
	private float speedMod = 1;
	private Rigidbody2D rb2d;
			   
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}


	void Update()
	{

		

	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{

		if (Input.GetAxis ("Fire3") != 0f)
			speedMod = sprintSpeedMod;
		else if (Input.GetAxis ("Fire1") != 0f)
			speedMod = sneakSpeedMod;
		else
			speedMod = 1f;
		float x = Input.GetAxisRaw ("Horizontal")*speed*speedMod*Time.fixedDeltaTime;
		float y = Input.GetAxisRaw ("Vertical")*speed*speedMod*Time.fixedDeltaTime;

		transform.position += new Vector3 (x, y, 0f);

	}

}