using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {
    private bool canInteract = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canInteract = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canInteract = false;
        }
    }

    private void Update()
    {
        if (canInteract)
        {
            if(Input.GetButton("Interact"))
            {

            }
        }
    }
}
