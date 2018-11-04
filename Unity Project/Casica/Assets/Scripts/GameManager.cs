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

    [Header("Camaras Activas")]
    public bool onHab;
    public bool onPasillo;
    public bool onBaño;
    public bool onNegacionN;
    public bool onNegacionD;
    public bool onCuartillo;
    public bool onDesvan;

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

    public GameObject desvanPoint;

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
}
