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

            manager.CloseNegacionD();
            manager.CloseCuartillo();
            manager.CloseDesvan();
            manager.CloseDespensa();
            manager.CloseCocina();
            manager.CloseSalon();
            manager.CloseHabPadres();
            manager.CloseLaberinto();
            manager.CloseSotanoN();
            manager.CloseSotanoD();

            manager.OpenHabJohnny();
            manager.OpenBaño();

            if (manager.pissed)
            {
                manager.OpenNegacionN();
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