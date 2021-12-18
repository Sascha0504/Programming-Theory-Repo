using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField]GameObject[] playerPrefabs;
    // Start is called before the first frame update

    private void Awake()
    {
        switch (GameManager.Instance.selection)
        {
            case GameManager.Animals.cat:
                {
                    Instantiate(playerPrefabs[0], transform.position, playerPrefabs[0].transform.rotation);
                    break;
                }
            case GameManager.Animals.dog:
                {
                    Instantiate(playerPrefabs[1], transform.position, playerPrefabs[1].transform.rotation);
                    break;
                }
        }
    }
    void Start()
    {

        
        
        
        
    }

    // Update is called once per frame
 
}
