﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool negacionDone;
    public bool pissed;
    public bool goNegacionD;

    public bool habJohnny;
    public bool pasillo;
    public bool baño;
    public bool negacionN;
    public bool negacionD;
    public bool cuartillo;

    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("GameManager").Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
