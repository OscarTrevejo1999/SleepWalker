using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScene : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "pasillo_1")
            {
                SceneManager.LoadScene("habJohnny");
            }
        }
    }
}
