using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {
	
	public bool Fade_In = true;
	public float Fade_Speed = 0.01f;
	private float Fade_Value;
	public float Delay;
	private SpriteRenderer Colour;


	// Use this for initialization
	void Start () 
	{
		Colour = GetComponent<SpriteRenderer> ();
		if (Fade_In == true) 
		{
			Colour.color = new Color (1, 1, 1, 0);
			Fade_Value = 0;
		} else {
			Colour.color = new Color (1, 1, 1, 1);
			Fade_Value = 1;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Delay > 0) 
		{
			Delay -= Time.deltaTime;
		}
		if ((Fade_In == true) && (Fade_Value < 1) && (Delay <= 0))
		{
			Fade_Value += Fade_Speed;
			Colour.color = new Color (1, 1, 1, Fade_Value);
		}  
		if ((Fade_In == false) && (Fade_Value > 0) && (Delay <= 0))
		{
			Fade_Value -= Fade_Speed;
			Colour.color = new Color (1, 1, 1, Fade_Value);
		}
	}
}
