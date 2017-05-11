using UnityEngine;
using System.Collections;

public class Cloud3 : MonoBehaviour
{

    public float speed = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);


    }
}
