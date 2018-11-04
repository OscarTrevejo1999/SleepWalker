using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRenderHabJohnny : MonoBehaviour
{
    private GameManager manager;

    Renderer[] rend;

    private bool done;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        rend = GetComponentsInChildren<Renderer>();
    }

    public virtual void Update()
    {
        if (!manager.onHab)
        {
            foreach (Renderer r in rend)
            {
                r.enabled = false;
            }

            done = true;
        }
        if (done && manager.onHab)
        {
            foreach (Renderer r in rend)
            {
                r.enabled = true;
            }

            done = false;
        }
    }
}