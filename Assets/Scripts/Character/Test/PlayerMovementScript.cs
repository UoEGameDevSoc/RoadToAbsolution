using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 1f;

    [SerializeField]
    private float maxSpeed = 5f;

    private Rigidbody rigidBody;
    private Vector3 direction;

    // Use this for initialization
    void Start()
    {
        //Probably gonna have some shit
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = new Vector3();
        if(Input.GetAxisRaw("Horizontal") > .1f)
        {
            direction.x = 1f;
        }
        else if (Input.GetAxisRaw("Horizontal") < -.1f)
        {
            direction.x = -1f;
        }
        if (Input.GetAxisRaw("Vertical") > .1f)
        {
            direction.y = 1f;
        }
        else if (Input.GetAxisRaw("Vertical") < -.1f)
        {
            direction.y = -1f;
        }

        rigidBody.velocity = direction.normalized * maxSpeed;
    }

    private void Update()
    {
        //Debug.DrawLine(gameObject.transform.position, new Vector3(Mathf.Cos(Vector3.Angle(Vector3.up, direction)), Mathf.Sin(Vector3.Angle(Vector3.up, direction))) * 2f);
    }
}
