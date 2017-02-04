using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 1f;

    [SerializeField]
    private float maxSpeed = 5f;

    private Rigidbody rigidBody;

    // Use this for initialization
    void Start()
    {
        //Probably gonna have some shit
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * acceleration;
        float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * acceleration;

        /*rigidBody.velocity += new Vector3(x, y);
        if (rigidBody.velocity.magnitude > maxSpeed)
        {
            rigidBody.velocity = rigidBody.velocity.normalized * maxSpeed;
        }

        //if (x == 0f) rigidBody.velocity.x = 0f;
        print(x.ToString() + " " + y.ToString());
        rigidBody.velocity = new Vector3(Input.GetButtonUp("Horizontal") ? 0f : rigidBody.velocity.x, y == 0f ? 0f : rigidBody.velocity.y, 0f);*/

        rigidBody.transform.position += new Vector3(x, y, 0f);

    }
}
