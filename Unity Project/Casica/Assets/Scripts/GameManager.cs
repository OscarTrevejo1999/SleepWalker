using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool pissed;

    public bool negacionDone;
    
    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("GameManager").Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    
    void Start ()
    {

    }
	
	void Update ()
    {
        
	}
}
