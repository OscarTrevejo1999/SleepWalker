using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrofeo : MonoBehaviour {

    public GameObject tpDesvan;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Trofeo")
        {
            Debug.Log("Next LvL");
            tpDesvan.SetActive(true);
        }
    }
}
