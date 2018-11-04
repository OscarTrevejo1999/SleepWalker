using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCuartillo : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.onCuartillo = true;
            if(!manager.desvan)
            {
                SceneManager.LoadSceneAsync("desvan", LoadSceneMode.Additive);
                manager.desvan = true;
            }
            if(!manager.negacionN)
            {
                SceneManager.LoadSceneAsync("negacion_N", LoadSceneMode.Additive);
                manager.negacionN = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onCuartillo = false;
        }
    }
}