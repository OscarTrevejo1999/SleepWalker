using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDespensa : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onDespensa = true;

            manager.CloseHabJohnny();
            manager.ClosePasillo();
            manager.CloseBaño();
            manager.CloseNegacionN();
            manager.CloseNegacionD();
            manager.CloseCuartillo();
            manager.CloseDesvan();
            manager.CloseSalon();
            manager.CloseHabPadres();
            manager.CloseLaberinto();
            manager.CloseSotanoN();
            manager.CloseSotanoD();

            manager.OpenCocina();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        manager.onDespensa = false;
    }
}
