using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenText : MonoBehaviour {

	public float letterPause = 0.03f;
	public string word = "Test"; // change this one in the inspector
	public Vector2 offSet;
	public Font speakFont;

	private string currentWord = "";

	void Start(){
		StartCoroutine(TypeText (word));
	}

	private IEnumerator TypeText (string compareWord) {
		//print("plez WaitUntil");
		foreach (char letter in word.ToCharArray()) {
			if (word != compareWord) break;
			currentWord += letter;
			yield return new WaitForSeconds(letterPause);
			//print (currentWord);
		}
		yield return new WaitForSeconds(5);  
		Destroy (gameObject);

	}

	void OnGUI()
	{
		var centeredStyle = GUI.skin.GetStyle("Label");
		centeredStyle.alignment = TextAnchor.LowerCenter;
		GUI.skin.font = speakFont;
		//GUI.Label(new Rect((Vector2)Camera.main.WorldToScreenPoint((Vector2)transform.position + offSet), new Vector2(200, 60)), currentWord, centeredStyle);
		Rect rect = new Rect(0, 0, 200, 60);
		Vector3 pos = Camera.main.WorldToScreenPoint (transform.position);
		rect.center = (Vector2)pos;
		rect.y -= 3 * rect.height / 2;
		GUI.Label(rect, currentWord, centeredStyle);
	}
		
}
