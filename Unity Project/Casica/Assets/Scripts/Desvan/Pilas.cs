using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilas : Interactive 
{

	public PlayerController PC;

	public override void Activar()
	{
		Debug.Log("Pila mi arma");
		PC.cojerObj(2);
		Object.Destroy(gameObject);
	}
}
