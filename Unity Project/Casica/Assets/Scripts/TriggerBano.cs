using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBano : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(manager.habJohnny)
            {
                SceneManager.UnloadSceneAsync("habJohnny");
                manager.habJohnny = false;
            }
            if (manager.negacionN)
            {
                SceneManager.UnloadSceneAsync("negacion_N");
                manager.negacionN = false;
            }
        }
    }
}
