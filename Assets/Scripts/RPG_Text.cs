using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPG_Text : MonoBehaviour {
	public Font font;
	void Start(){
		TextGenerationSettings settings = new TextGenerationSettings ();
		settings.textAnchor = TextAnchor.MiddleCenter;
		settings.color = Color.cyan;
		//settings.color = Color.black;
		settings.generationExtents = new Vector2(500.0f, 200.0f);
		settings.pivot = Vector2.zero;
		settings.richText = true;
		settings.font = font;
		settings.fontSize = 16;
		settings.fontStyle = FontStyle.Italic;
		settings.verticalOverflow = VerticalWrapMode.Overflow;
		//generate verticies for given string
		TextGenerator generator = new TextGenerator ();
		generator.Populate ("test text generatoer i ahve canccer", settings);


		Debug.Log ("I generated: " + generator.vertexCount + "verts");


	}
	void Update(){
}
}