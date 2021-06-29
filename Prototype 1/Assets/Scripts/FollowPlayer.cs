using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float toggleInput;
    public GameObject vehicle;
    private Vector3[] offsets = { new Vector3(0, 5, -13), new Vector3(0, 5, -4) };
    private int offsetIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ToggleCamera();
        OffsetCamera();
    }

    //Toggle bettwen the diferent types offsets for the camera
    private void ToggleCamera()
    {
        if (Input.GetKeyDown("z"))
            offsetIndex = (offsetIndex + 1) % offsets.Length;
    }
    
    // Offset the camera
    private void OffsetCamera()
    {
        transform.position = vehicle.transform.position + offsets[offsetIndex];
    }

}
