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

            manager.CloseHabJohnny();
            manager.CloseBaño();
            manager.CloseDespensa();
            manager.CloseDesvan();
            manager.CloseCocina();
            manager.CloseSalon();
            manager.CloseHabPadres();
            manager.CloseLaberinto();
            manager.CloseSotanoN();
            manager.CloseSotanoD();

            if (!manager.negacionDone)
            {
                manager.goNegacionD = true;
            }
            if(manager.negacionDone)
            {
                manager.ClosePasillo();
                manager.OpenCuartillo();
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
