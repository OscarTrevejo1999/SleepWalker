using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [Header("Progreso")]
    public bool negacionDone;
    public bool pissed;
    public bool goNegacionD;

    [Header("Escenas Cargadas")]
    public bool habJohnny;
    public bool pasillo;
    public bool baño;
    public bool negacionN;
    public bool negacionD;
    public bool cuartillo;
    public bool desvan;
    public bool despensa;

    [Header("Camaras Activas")]
    public bool onHab;
    public bool onPasillo;
    public bool onBaño;
    public bool onNegacionN;
    public bool onNegacionD;
    public bool onCuartillo;
    public bool onDesvan;
    public bool onDespensa;

    [Header("Camaras")]
    public CinemachineVirtualCamera camHab;
    public CinemachineVirtualCamera camPasillo;
    public CinemachineVirtualCamera camBaño;
    public CinemachineVirtualCamera camNegacionN;
    public CinemachineVirtualCamera camNegacionD;
    public CinemachineVirtualCamera camCuartillo;
    public CinemachineVirtualCamera camDesvan;

    private Transform player;
    [Header("Teleports")]

    public GameObject habJohnnyPoint;
    public GameObject pasilloPoint;
    public GameObject bañoPoint;
    public GameObject negacionNPoint;
    public GameObject negacionDPoint;
    public GameObject cuartilloPoint;
    public GameObject desvanPoint;
    public GameObject despensaPoint;

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

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        camHab.enabled = onHab;
        camPasillo.enabled = onPasillo;
        camBaño.enabled = onBaño;
        camNegacionN.enabled = onNegacionN;
        camNegacionD.enabled = onNegacionD;
        camCuartillo.enabled = onCuartillo;
        camDesvan.enabled = onDesvan;
    }

    public void TpHabJohnny()
    {
        if (!habJohnny)
        {
            SceneManager.LoadSceneAsync("habJohnny", LoadSceneMode.Additive);
            habJohnny = true;
        }
        player.position = habJohnnyPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpPasillo()
    {
        if (!pasillo)
        {
            SceneManager.LoadSceneAsync("pasillo", LoadSceneMode.Additive);
            pasillo = true;
        }
        player.position = pasilloPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpBaño()
    {
        if (!baño)
        {
            SceneManager.LoadSceneAsync("baño", LoadSceneMode.Additive);
            baño = true;
        }
        player.position = bañoPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpNegacionN()
    {
        if (!negacionN)
        {
            SceneManager.LoadSceneAsync("negacion_N", LoadSceneMode.Additive);
            negacionN = true;
        }
        player.position = negacionNPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpNegacionD()
    {
        if (!negacionD)
        {
            SceneManager.LoadSceneAsync("negacion_D", LoadSceneMode.Additive);
            negacionD = true;
        }
        player.position = negacionDPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpCuartillo()
    {
        if (!cuartillo)
        {
            SceneManager.LoadSceneAsync("cuartillo", LoadSceneMode.Additive);
            cuartillo = true;
        }
        player.position = cuartilloPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpDesvan()
    {
        if(!desvan)
        {
            SceneManager.LoadSceneAsync("desvan", LoadSceneMode.Additive);
            desvan = true;
        }
        player.position = desvanPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpDespensa()
    {
        if (!despensa)
        {
            SceneManager.LoadSceneAsync("despensa", LoadSceneMode.Additive);
            despensa = true;
        }
        player.position = despensaPoint.transform.position;
        Debug.Log("TP DONE");
    }
}
