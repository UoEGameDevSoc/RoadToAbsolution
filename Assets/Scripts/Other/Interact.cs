using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {
    private bool canInteract = false;
    private bool isInteracting = false;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
            canInteract = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
            canInteract = false;
        if (isInteracting)
        {
            isInteracting = false;
            StopInteraction();
        }
    }

    private void Update()
    {
        if (canInteract)
        {
            if(!isInteracting && Input.GetButton("Interact"))
            {
                isInteracting = true;
                StartInteraction();
            }
            else if(isInteracting && !Input.GetButton("Interact"))
            {
                isInteracting = false;
                StopInteraction();
            }
        }
    }

    private void StartInteraction()
    {
        //Add interaction code here
    }

    private void StopInteraction()
    {
        //Add interaction code here
    }
}
