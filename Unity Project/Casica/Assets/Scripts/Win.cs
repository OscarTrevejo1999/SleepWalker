﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour 
{
	private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Player")
        {
           other.gameObject.GetComponent<PlayerController>().Win();
        }
	}
	
}