//Uncomment this on if you want events to be logged
//#define DEBUG
using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {
    //Reference to the player
    private GameObject player;
    //Whether we are currently interacting with something
    private bool isInteracting = false;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            player = coll.gameObject;
#if (DEBUG)
            print("Player can interact with " + gameObject.name);
#endif
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            player = null;
            if (isInteracting)
            {
                isInteracting = false;
                StopInteraction();
#if (DEBUG)
                print("Interaction stopped on collider exit with " + gameObject.name);
#endif
            }
#if (DEBUG)
            print("Player can no longer interact with " + gameObject.name);
#endif
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
#if (DEBUG)
                print("Player interacted with " + gameObject.name);
#endif
            }
            else if(isInteracting && !Input.GetButton("Interact"))
            {
                isInteracting = false;
                StopInteraction();
#if (DEBUG)
                print("Interaction stopped  with" + gameObject.name);
#endif
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
