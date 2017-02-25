using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Grenade : Item
{

    public float fuseTime;
    public GameObject explosion;
	public float speed = 120f;

    private Vector2 vel;
    private Rigidbody2D rb2d;
    private float timer = 0f;

	// Use this for initialization
	void Start()
	{
	    rb2d = GetComponent<Rigidbody2D>();
	}

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > fuseTime)
        {
            explode();
        }
		gameObject.transform.position += (Vector3)vel*Time.deltaTime;
    }

    // Update is called once per frame
	void FixedUpdate ()
	{
	    
	}

	//mX/mY = mouseX/Y sX/sY = sourceX/Y
	public void setVelocity(Vector2 currentPos, Vector2 targetPos)
    {
		Vector2 direction = (targetPos - currentPos).normalized;
		vel = direction * speed;
		print (direction);
    }

    void explode()
    {
		explosion.transform.position = gameObject.transform.position;
        Instantiate(explosion);
        Destroy(gameObject);
    }

}
