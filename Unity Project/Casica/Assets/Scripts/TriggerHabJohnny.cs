using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerHabJohnny : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.onHab = true;
            if (!manager.pasillo)
            {
                SceneManager.LoadSceneAsync("pasillo", LoadSceneMode.Additive);
                manager.pasillo = true;
            }
            if(manager.baño)
            {
                SceneManager.UnloadSceneAsync("baño");
                manager.baño = false;
            }
            if(manager.negacionN)
            {
                SceneManager.UnloadSceneAsync("negacion_N");
                manager.negacionN = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.onHab = false;
        }
    }
}
