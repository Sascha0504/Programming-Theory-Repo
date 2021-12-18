using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum Animals{cat = 0 ,dog = 1 }
    public static GameManager Instance { get; private set; }
    public Animals selection;

    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance != null) 
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClickCat()
    {
        selection = Animals.cat;
        SceneManager.LoadScene(1);
        
    }

    public void OnButtonClickDog()
    {
        selection = Animals.dog ;
        SceneManager.LoadScene(1);
    }
}
