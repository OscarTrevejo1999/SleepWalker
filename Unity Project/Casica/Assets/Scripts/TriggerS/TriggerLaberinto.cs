using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLaberinto : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onLaberinto = true;

            manager.CloseHabJohnny();
            manager.ClosePasillo();
            manager.CloseBaño();
            manager.CloseNegacionN();
            manager.CloseNegacionD();
            manager.CloseCuartillo();
            manager.CloseDesvan();
            manager.CloseDespensa();
            manager.CloseCocina();
            manager.CloseSalon();
            manager.CloseSotanoN();
            manager.CloseSotanoD();

            manager.OpenHabPadres();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.onLaberinto = false;
        }
    }
}
