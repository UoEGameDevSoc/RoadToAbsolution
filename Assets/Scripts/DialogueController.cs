using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour {

	public LinkedList<string> textList = new LinkedList<string> ();
	public GameObject textPrefab;

	private int listPos = 0;

	// Use this for initialization
	void Start () {
		textList.AddLast ("Cancer");
		textList.AddLast ("I think it's funny");
		nextLine ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void nextLine(){
		if (textList.Count > listPos) {
			
			listPos++;
		}
	}

}
