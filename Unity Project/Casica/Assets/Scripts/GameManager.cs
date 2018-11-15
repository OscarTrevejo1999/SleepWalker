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
    public bool cocina;
    public bool salon;
    public bool habPadres;
    public bool laberinto;
    public bool sotanoN;
    public bool sotanoD;

    [Header("Camaras Activas")]
    public bool onHab;
    public bool onPasillo;
    public bool onBaño;
    public bool onNegacionN;
    public bool onNegacionD;
    public bool onCuartillo;
    public bool onDesvan;
    public bool onDespensa;
    public bool onCocina;
    public bool onSalon;
    public bool onHabPadres;
    public bool onLaberinto;
    public bool onSotanoN;
    public bool onSotanoD;

    [Header("Camaras")]
    public CinemachineVirtualCamera camHab;
    public CinemachineVirtualCamera camPasillo;
    public CinemachineVirtualCamera camBaño;
    public CinemachineVirtualCamera camNegacionN;
    public CinemachineVirtualCamera camNegacionD;
    public CinemachineVirtualCamera camCuartillo;
    public CinemachineVirtualCamera camDesvan;
    public CinemachineVirtualCamera camDespensa;
    public CinemachineVirtualCamera camHabPadres;
    public CinemachineVirtualCamera camLaberinto;
    public CinemachineVirtualCamera camSotanoN;

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
    public GameObject cocinaPoint;
    public GameObject salonPoint;
    public GameObject habPadresPoint;
    public GameObject laberintoPoint;
    public GameObject sotanoNPoint;
    //public GameObject sotanoDPoint;

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
        camHabPadres.enabled = onHabPadres;
        camLaberinto.enabled = onLaberinto;


        if (onDespensa || onCocina ||onSalon)
        {
            camDespensa.enabled = true;
        }
        else
        {
            camDespensa.enabled = false;
        }

        if(onSotanoN || onSotanoD)
        {
            camSotanoN.enabled = true;
        }
        else
        {
            camSotanoN.enabled = false;
        }
    }


    #region Teleports
    public void TpHabJohnny()
    {
        OpenHabJohnny();
        player.position = habJohnnyPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpPasillo()
    {
        OpenPasillo();
        player.position = pasilloPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpBaño()
    {
        OpenBaño();
        player.position = bañoPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpNegacionN()
    {
        OpenNegacionN();
        player.position = negacionNPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpNegacionD()
    {
        OpenNegacionD();
        player.position = negacionDPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpCuartillo()
    {
        OpenCuartillo();
        player.position = cuartilloPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpDesvan()
    {
        OpenDesvan();
        player.position = desvanPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpDespensa()
    {
        OpenDespensa();
        player.position = despensaPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpCocina()
    {
        OpenCocina();
        player.position = cocinaPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpSalon()
    {
        OpenSalon();
        player.position = salonPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpHabPadres()
    {
        OpenHabPadres();
        player.position = habPadresPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpLaberinto()
    {
        OpenLaberinto();
        player.position = laberintoPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpSotanoN()
    {
        OpenSotanoN();
        player.position = sotanoNPoint.transform.position;
        Debug.Log("TP DONE");
    }

    public void TpSotanoD()
    {
        OpenSotanoD();
        //player.position = sotanoDPoint.transform.position;
        Debug.Log("TP DONE");
    }
    #endregion

    #region Abrir Escenas

    public void OpenHabJohnny()
    {
        if(!habJohnny)
        {
            SceneManager.LoadSceneAsync("habJohnny", LoadSceneMode.Additive);
            habJohnny = true;
        }
    }

    public void OpenPasillo()
    {
        if (!pasillo)
        {
            SceneManager.LoadSceneAsync("pasillo", LoadSceneMode.Additive);
            pasillo = true;
        }
    }

    public void OpenBaño()
    {
        if (!baño)
        {
            SceneManager.LoadSceneAsync("baño", LoadSceneMode.Additive);
            baño = true;
        }
    }

    public void OpenNegacionN()
    {
        if (!negacionN)
        {
            SceneManager.LoadSceneAsync("negacion_N", LoadSceneMode.Additive);
            negacionN = true;
        }
    }

    public void OpenNegacionD()
    {
        if (!negacionD)
        {
            SceneManager.LoadSceneAsync("negacion_D", LoadSceneMode.Additive);
            negacionD = true;
        }
    }

    public void OpenCuartillo()
    {
        if (!cuartillo)
        {
            SceneManager.LoadSceneAsync("cuartillo", LoadSceneMode.Additive);
            cuartillo = true;
        }
    }

    public void OpenDesvan()
    {
        if (!desvan)
        {
            SceneManager.LoadSceneAsync("desvan", LoadSceneMode.Additive);
            desvan = true;
        }
    }

    public void OpenDespensa()
    {
        if (!despensa)
        {
            SceneManager.LoadSceneAsync("despensa", LoadSceneMode.Additive);
            despensa = true;
        }
    }

    public void OpenCocina()
    {
        if (!cocina)
        {
            SceneManager.LoadSceneAsync("cocina", LoadSceneMode.Additive);
            cocina = true;
        }
    }

    public void OpenSalon()
    {
        if (!salon)
        {
            SceneManager.LoadSceneAsync("salon", LoadSceneMode.Additive);
            salon = true;
        }
    }

    public void OpenHabPadres()
    {
        if (!habPadres)
        {
            SceneManager.LoadSceneAsync("habPadres", LoadSceneMode.Additive);
            habPadres = true;
        }
    }

    public void OpenLaberinto()
    {
        if (!laberinto)
        {
            SceneManager.LoadSceneAsync("laberinto", LoadSceneMode.Additive);
            laberinto = true;
        }
    }

    public void OpenSotanoN()
    {
        if (!sotanoN)
        {
            SceneManager.LoadSceneAsync("sotanoN", LoadSceneMode.Additive);
            sotanoN = true;
        }
    }

    public void OpenSotanoD()
    {
        /*
        if (!sotanoD)
        {
            SceneManager.LoadSceneAsync("sotanoD", LoadSceneMode.Additive);
            sotanoD = true;
        }
        */
    }

    #endregion

    #region Cerrar Escenas

    public void CloseHabJohnny()
    {
        if (habJohnny)
        {
            SceneManager.UnloadSceneAsync("habJohnny");
            habJohnny = false;
        }
    }

    public void ClosePasillo()
    {
        if (pasillo)
        {
            SceneManager.UnloadSceneAsync("pasillo");
            pasillo = false;
        }
    }

    public void CloseBaño()
    {
        if (baño)
        {
            SceneManager.UnloadSceneAsync("baño");
            baño = false;
        }
    }

    public void CloseNegacionN()
    {
        if (negacionN)
        {
            SceneManager.UnloadSceneAsync("negacion_N");
            negacionN = false;
        }
    }

    public void CloseNegacionD()
    {
        if (negacionD)
        {
            SceneManager.UnloadSceneAsync("negacion_D");
            negacionD = false;
        }
    }

    public void CloseCuartillo()
    {
        if (cuartillo)
        {
            SceneManager.UnloadSceneAsync("cuartillo");
            cuartillo = false;
        }
    }

    public void CloseDesvan()
    {
        if (desvan)
        {
            SceneManager.UnloadSceneAsync("desvan");
            desvan = false;
        }
    }

    public void CloseDespensa()
    {
        if (despensa)
        {
            SceneManager.UnloadSceneAsync("despensa");
            despensa = false;
        }
    }

    public void CloseCocina()
    {
        if (cocina)
        {
            SceneManager.UnloadSceneAsync("cocina");
            cocina = false;
        }
    }

    public void CloseSalon()
    {
        if (salon)
        {
            SceneManager.UnloadSceneAsync("salon");
            salon = false;
        }
    }

    public void CloseHabPadres()
    {
        if (habPadres)
        {
            SceneManager.UnloadSceneAsync("habPadres");
            habPadres = false;
        }
    }

    public void CloseLaberinto()
    {
        if (laberinto)
        {
            SceneManager.UnloadSceneAsync("laberinto");
            laberinto = false;
        }
    }

    public void CloseSotanoN()
    {
        if (sotanoN)
        {
            SceneManager.UnloadSceneAsync("sotanoN");
            sotanoN = false;
        }
    }

    public void CloseSotanoD()
    {
        /*
        if (sotanoD)
        {
            SceneManager.UnloadSceneAsync("sotanoD");
            sotanoD = false;
        }
        */
    }

    #endregion
}
