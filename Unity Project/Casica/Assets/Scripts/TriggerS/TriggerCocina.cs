using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCocina : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onCocina = true;

            manager.CloseHabJohnny();
            manager.ClosePasillo();
            manager.CloseBaño();
            manager.CloseNegacionN();
            manager.CloseNegacionD();
            manager.CloseCuartillo();
            manager.CloseDesvan();
            manager.CloseHabPadres();
            manager.CloseLaberinto();
            manager.CloseSotanoD();
            manager.CloseSotanoN();

            manager.OpenDespensa();
            manager.OpenSalon();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        manager.onCocina = false;
    }
}
