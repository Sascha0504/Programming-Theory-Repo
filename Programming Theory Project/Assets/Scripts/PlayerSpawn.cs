using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
