using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLibro : MonoBehaviour {

	public Animator Movete;
	

	// Use this for initialization
	private void OnTriggerEnter(Collider other)
    {
		Debug.Log("Me voy a caer re puto");
        if (other.gameObject.tag == "Player")
        {
           Movete = GetComponentInParent<Animator>();
		   Movete.SetBool("Moverse", true);
        }
    }
	

}
