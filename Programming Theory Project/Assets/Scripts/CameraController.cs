using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 3, -9);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = GameObject.Find("Player").transform.position + offset;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
