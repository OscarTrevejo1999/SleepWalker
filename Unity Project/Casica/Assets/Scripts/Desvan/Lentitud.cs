using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lentitud : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Player")
        {
           other.gameObject.GetComponent<PlayerController>().speed =  other.gameObject.GetComponent<PlayerController>().speed - 3;
		   other.gameObject.GetComponent<PlayerController>().speedMod = true;
        }
	}

}	