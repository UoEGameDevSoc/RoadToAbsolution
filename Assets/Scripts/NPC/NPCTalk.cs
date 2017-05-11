using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour {

	public GameObject textPrefab;
	public string textLine;

	public Vector2 offSet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		GameObject myText = Instantiate (textPrefab, gameObject.transform.position, Quaternion.identity);
		GenText text = myText.GetComponent<GenText> ();
		text.transform.position = gameObject.transform.position;
		text.offSet = offSet;
		text.word = textLine;
	}

}
