using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDesvan : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("TP!");
            manager.TpDesvan();
        }
    }
}
