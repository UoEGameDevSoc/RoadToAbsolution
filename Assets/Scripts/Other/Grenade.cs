using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Grenade : MonoBehaviour
{

    public float fuseTime;
    public GameObject explosion;

    private Vector3 vel;
    private Rigidbody2D rb2d;
    private float timer = 0f;

	// Use this for initialization
	void Start()
	{
	    rb2d = GetComponent<Rigidbody2D>();
        setVelocity(new Vector3(0.5f, 0.5f, 0f));
	}

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > fuseTime)
        {
            explode();
        }
    }

    // Update is called once per frame
	void FixedUpdate ()
	{
	    gameObject.transform.position += vel*Time.fixedDeltaTime;
	}

    public void setVelocity(Vector3 vel)
    {
        this.vel = vel;
    }

    void explode()
    {
        explosion.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        Instantiate(explosion);
        Destroy(gameObject);
    }

}
