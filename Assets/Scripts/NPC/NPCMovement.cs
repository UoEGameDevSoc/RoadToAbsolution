using UnityEngine;
using System.Collections;

public class NPCMovement : MonoBehaviour {
	public float speed;
    public Vector3[] points;
    private Vector3 targetPosition;
	private int i = 0;
	private bool end = false;



	//public float directionChangeInterval = 1;
	//public float maxHeadingChange = 30;
	Vector3 movement =new Vector3();

	
	//float heading;
	//Vector3 targetRotation;


	// Use this for initialization
	void Awake () {
		
	    targetPosition = points[0];

	    //Set random initial rotation
	    //heading=Random.Range(0,360);
	    //transform.eulerAngles = new Vector3 (0, heading, 0);
	    //StartCoroutine (NewHeading ());


	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
		transform.position=Vector3.MoveTowards(transform.position,targetPosition,speed*Time.deltaTime);
		//var forward = transform.TransformDirection(Vector3.forward);
		//controller.SimpleMove(forward * speed);
		if (i < points.Length && end == false) {
        
			if (transform.position == targetPosition) {
				targetPosition = points [i];
				i++;
			}
			if (i == points.Length )
				end = true;
		}
		
		if (i > points.Length  && end == true)
		{
		    
			if (transform.position == targetPosition) {
				targetPosition = points [i];
				i--;
			}
			if (i == 0)
				end = false;
		}

	}

	/*/// <summary>
	/// Repeatedly calculates a new direction to move towards.
	/// Use this instead of MonoBehaviour.InvokeRepeating so that the interval can be changed at runtime.
	/// </summary>
	IEnumerator NewHeading ()
	{
		while (true) {
			NewHeadingRoutine();
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}

	/// <summary>
	/// Calculates a new direction to move towards.
	/// </summary>
	void NewHeadingRoutine ()
	{
		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
		var ceil  = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
		heading = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, heading, 0);
	}
*/
}
