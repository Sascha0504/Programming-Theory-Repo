using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    [SerializeField] Text enterText;
    [SerializeField] int sceneNumber;
    HingeJoint door;

    private void Start()
    {
        door = gameObject.GetComponent<HingeJoint>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }







    private void OnTriggerStay(Collider collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        enterText.gameObject.SetActive(false);
    }
}


