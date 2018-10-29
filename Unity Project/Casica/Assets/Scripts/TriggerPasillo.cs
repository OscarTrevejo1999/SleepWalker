using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPasillo : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onPasillo = true;
            if (!manager.baño)
            {
                SceneManager.LoadSceneAsync("baño", LoadSceneMode.Additive);
                manager.baño = true;
            }
            if (!manager.habJohnny)
            {
                SceneManager.LoadSceneAsync("habJohnny", LoadSceneMode.Additive);
                manager.habJohnny = true;
            }
            if(manager.pissed && !manager.negacionN)
            {
                SceneManager.LoadSceneAsync("negacion_N", LoadSceneMode.Additive);
                manager.negacionN = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.onPasillo = false;
        }
    }
}