using UnityEngine;
using System.Collections;

public class NPCController : MonoBehaviour {

	private NPCMovement movementScript;
    public bool patrol;
	public bool NPC; // if 0, character is enemy of player
					// if 1, character is normal NPC


	// Use this for initialization
	void Start () {
		movementScript = GetComponent<NPCMovement> ();
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	    Detect();
	}

	void Detect()
	{
		if(patrol)
		{
			movementScript.enabled =true;

		}

		if(!patrol)
			movementScript.enabled =false;
	}

}
