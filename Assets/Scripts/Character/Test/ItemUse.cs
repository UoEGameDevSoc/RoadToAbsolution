using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour {

	//Item in slot1
	public Item itemSlot1;
	public GameObject grenadePrefab;

	//The currently selected item
	public Item selectedItem;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("SelectItem1")) {
			selectedItem = itemSlot1;
			print ("cunt");
		}

		if (Input.GetButtonDown ("UseItem")) {
			if (selectedItem is Grenade) {
				//Grenade grenade = new Grenade ();
				//grenadeScript.setVelocity (rb2d.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
				GameObject myGrenade = Instantiate (grenadePrefab, gameObject.transform.position, Quaternion.identity);
				Grenade grenadeScript = myGrenade.GetComponent<Grenade> ();
				grenadeScript.setVelocity (rb2d.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
				print (" kys cunt");
			}
		}

	}
}
