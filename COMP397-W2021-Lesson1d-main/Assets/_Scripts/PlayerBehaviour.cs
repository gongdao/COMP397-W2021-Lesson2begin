using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            // rigidBody.AddForce(new Vector3(1.0f, 0.0f, 0.0f) * movementForce
            Debug.Log("Move Right force = " + movementForce);

            rigidBody.AddForce(Vector3.right * movementForce);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Debug.Log("Move Left force = " + movementForce);
            rigidBody.AddForce(Vector3.left * movementForce);
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            // move 
            Debug.Log("Move up");
            rigidBody.AddForce(Vector3.right * movementForce);
        }

        if(Input.GetAxisRaw("Vertical") < 0)
        {
            Debug.Log("Move Down");
            rigidBody.AddForce(Vector3.left * movementForce);

        }
    } 
}
