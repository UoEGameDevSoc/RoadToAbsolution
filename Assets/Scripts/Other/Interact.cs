using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {
    //Reference to the player
    private GameObject player;
    //Whether we are currently interacting with something
    //Used for things like showing/hiding UI
    private bool isInteracting = false;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            player = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
            player = null;
        if (isInteracting)
        {
            isInteracting = false;
            StopInteraction();
        }
    }

    private void Update()
    {
        if (player)
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
        //What happens when the interaction begin
    }

    private void StopInteraction()
    {
        //What happens when the interaction ends
        //Can be left empty if nothing needs to be done
    }
}
