using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRenderizar : MonoBehaviour {

    private GameManager manager;

    Renderer[] rend;

    private bool done;

    void Start ()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        rend = GetComponentsInChildren<Renderer>();
    }

    void Update ()
    {
		if(!manager.onHab)
        {
            foreach (Renderer r in rend)
            {
                r.enabled = false;
            }
            /*
            for (int i = 0; 1 < rend.Length; i++)
            {
                rend[i].enabled = false;
                Debug.Log(rend[i].transform.name);
            }
            */
            //done = true;
        }
	}
}