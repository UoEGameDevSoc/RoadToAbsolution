﻿//Comment out for debugging
#undef DEBUG

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour {
    //How wide the cone of vision is (in degrees)
    [SerializeField]
    private float detectionRadius = 90f;
    //How long the cone of vision is
    [SerializeField]
    private float detectionRange = 5f;
    //Detection rate based on range
    [SerializeField]
    private AnimationCurve detectionRate = AnimationCurve.Linear(0f, 0f, 1f, 1f);
    //How fast the enemy loses track of the player (per second)
    [SerializeField]
    private float reductionRate = 1f;

    //Reference to the player
    private GameObject player;
    //Detection meter, between 0 and 100
    private float detectionMeter = 0f;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player == null)
        {
            Debug.LogError("No player found! Make sure the player is tagged with the \"Player\" tag.");
        }
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 myPosition = gameObject.transform.position;
        Vector3 playerPosition = player.transform.position;
        bool wasSeen = false;

        float angle = Vector3.Angle(playerPosition - myPosition, new Vector3(1f, 0f, 0f)) - gameObject.transform.rotation.eulerAngles.z + detectionRadius/2f;
        angle -= Mathf.Floor(angle / 360f) * 360f;

        if ((myPosition - playerPosition).magnitude <= detectionRange && angle <= detectionRadius)
        {
            //We are in the vision cone, but might be behind cover
            RaycastHit2D hit = Physics2D.Raycast(myPosition, (playerPosition - myPosition).normalized);
            if(hit.collider && hit.collider.gameObject == player)
            {
                //We can be seen, so increase the meter based on the curve
                detectionMeter += detectionRate.Evaluate(1f - hit.distance / detectionRange);
                detectionMeter = Mathf.Min(100f, detectionMeter);
                wasSeen = true;
#if DEBUG
                print("Player detected. Detection meter is now " + detectionMeter);
#endif
            }
        }
        if(!wasSeen)
        {
            //Decrease the detection meter if we weren't seen
            detectionMeter -= Time.deltaTime * reductionRate;
            detectionMeter = Mathf.Max(0f, detectionMeter);
#if DEBUG
            print("Player not detected. Detection meter is now " + detectionMeter);
#endif
        }
	}
}
