using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : Interactive {

	public GameObject[] luces;

	public override void Activar()
	{
		foreach(GameObject luz in luces)
		{
			luz.SetActive(true);
		}
	}


}
