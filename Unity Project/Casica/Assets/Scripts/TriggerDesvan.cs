using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDesvan : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onDesvan = true;
            if (manager.negacionN)
            {
                SceneManager.UnloadSceneAsync("negacion_N");
                manager.negacionN = false;
            }
            if (manager.cuartillo)
            {
                SceneManager.UnloadSceneAsync("cuartillo");
                manager.cuartillo = false;
            }
            if(manager.habJohnny)
            {
                SceneManager.UnloadSceneAsync("habJohnny");
                manager.habJohnny = false;
            }
            if (manager.baño)
            {
                SceneManager.UnloadSceneAsync("baño");
                manager.baño = false;
            }
            if (manager.negacionN)
            {
                SceneManager.UnloadSceneAsync("negacion_N");
                manager.negacionN = false;
            }
            if (manager.negacionD)
            {
                SceneManager.UnloadSceneAsync("negacion_D");
                manager.negacionD = false;
            }
            if (manager.pasillo)
            {
                SceneManager.UnloadSceneAsync("pasillo");
                manager.pasillo = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onDesvan = false;
        }
    }
}
