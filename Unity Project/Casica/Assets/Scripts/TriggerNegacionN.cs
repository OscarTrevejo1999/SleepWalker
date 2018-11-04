using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerNegacionN : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onNegacionN = true;
            if (!manager.negacionDone)
            {
                manager.goNegacionD = true;
                if (manager.habJohnny)
                {
                    SceneManager.UnloadSceneAsync("habJohnny");
                    manager.habJohnny = false;
                }
                if (manager.baño)
                {
                    SceneManager.UnloadSceneAsync("baño");
                    manager.baño = false;
                }
            }
            if(manager.negacionDone)
            {
                if(manager.pasillo)
                {
                    SceneManager.UnloadSceneAsync("pasillo");
                    manager.pasillo = false;
                }
                if(!manager.cuartillo)
                {
                    SceneManager.LoadSceneAsync("cuartillo", LoadSceneMode.Additive);
                    manager.cuartillo = true;
                }
                if(manager.baño)
                {
                    SceneManager.UnloadSceneAsync("baño");
                    manager.baño = false;
                }
                if(manager.habJohnny)
                {
                    SceneManager.UnloadSceneAsync("habJohnny");
                    manager.habJohnny = false;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag =="Player")
        {
            manager.onNegacionN = false;
        }
    }
}
