using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : Interactive 
{

	public PlayerController PC;

	public override void Activar()
	{
		Debug.Log("Linternita de mi corason");
		PC.cojerObj(1);
		Object.Destroy(gameObject);
	}
}
