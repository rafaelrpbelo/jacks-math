using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform cam;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;    
    }

    // Update is called once per frame
    void Update()
    {
        //cam.transform = new Vector3(cam.transform.x * speed, cam.transform.y, cam.transform.z);
    }
}
