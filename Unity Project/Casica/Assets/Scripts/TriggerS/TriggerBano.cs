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
            manager.onBaño = true;

            manager.CloseHabJohnny();
            manager.CloseNegacionN();
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

            manager.OpenPasillo();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        manager.onBaño = false;
    }
}
