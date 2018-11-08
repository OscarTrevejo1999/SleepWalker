using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

    public void WakeUp()
    {
        SceneManager.LoadScene("player");
    }

    public void Continue()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}
