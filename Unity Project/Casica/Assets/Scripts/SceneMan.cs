using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        SceneManager.LoadScene("habJohnny", LoadSceneMode.Additive);
        manager.habJohnny = true;
        Destroy(this);
    }
}
