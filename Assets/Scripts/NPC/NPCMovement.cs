using UnityEngine;
using System.Collections;

public class NPCMovement : MonoBehaviour {
	public float speed;
    public Vector3[] points;
    private Vector3 targetPosition;
	private int i = 0;
	private bool end = false;

	Vector3 movement =new Vector3();


	// Use this for initialization
	void Awake () {
		
	    targetPosition = points[0];

	}



	// Update is called once per frame
	//Patrols in a predefined area
	void Update ()
	{

		transform.position=Vector3.MoveTowards(transform.position,targetPosition,speed*Time.deltaTime);
	

		if ( end == false) {
        
			if (transform.position == targetPosition) {
				targetPosition = points [i];
				i++;
			}
			if (i == points.Length  )
				end = true;
		}
		
		if (end == true)
		{
		    
			if (transform.position == targetPosition) {
				targetPosition = points [--i];

			}
			if (i == 0)
				end = false;
		}

	}

	public void changeTarget(Vector3 location)
	{
		targetPosition = location;	
	}


}
