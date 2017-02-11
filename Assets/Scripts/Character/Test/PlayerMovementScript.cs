using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb2d;
               
    void Start()
    {
        speed = 1f;
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
	
		float x = Input.GetAxis ("Horizontal")*speed*Time.fixedDeltaTime;
		float y = Input.GetAxis ("Vertical")*speed*Time.fixedDeltaTime;

		transform.position += new Vector3 (x, y, 0f);

    }

}