using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimieMovement : MonoBehaviour
{
    // Private variables
    private float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the Enimie vehicle forward on a fixed speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
