using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float activationTime;

    private float currentTime;
    private GameObject instance;
    private CircleCollider2D collision;

	// Use this for initialization
	void Start ()
	{
	    collision = GetComponent<CircleCollider2D>();
	    currentTime = 0f;
	    instance = gameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    currentTime += Time.deltaTime;
        if(currentTime > activationTime)Destroy(instance);
        else if (currentTime > activationTime*0.8f) collision.enabled = true;
	}
}
