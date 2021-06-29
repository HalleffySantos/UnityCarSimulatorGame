using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 20.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float forwardInput;
    public virtual string Player { get; set; } = "P1";

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + Player);
        forwardInput = Input.GetAxis("Vertical" + Player);

        //Moves the vehicle forward based on forwardInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotates the vehicule based on horizontalInput
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
