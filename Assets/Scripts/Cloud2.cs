using UnityEngine;
using System.Collections;

public class Cloud2 : MonoBehaviour
{

    public float speed = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed);


    }
}