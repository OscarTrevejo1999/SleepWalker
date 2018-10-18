using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    private GameManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if(SceneManager.GetActiveScene().name == "baño")
            {
                SceneManager.LoadScene("pasillo_1");
                manager.pissed = true;
            }
            if (SceneManager.GetActiveScene().name == "habJohnny" && manager.pissed)
            {
                SceneManager.LoadScene("pasillo_2");
            }
        }
    }
}
