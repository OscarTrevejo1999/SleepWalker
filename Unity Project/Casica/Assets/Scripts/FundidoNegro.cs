using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FundidoNegro : MonoBehaviour {

    private GameManager manager;

    public CanvasGroup panel;

    private float alpha;

    private float counter;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (manager.goNegacionD)
        {
            panel.alpha = alpha;

            if (counter < 10)
            {
                counter += Time.deltaTime;
            }
            else
            {
                alpha += 0.3f * Time.deltaTime;
            }
            if (alpha > 1)
            {
                manager.negacionDone = true;
                SceneManager.LoadSceneAsync("negacion_D", LoadSceneMode.Additive);
                manager.negacionD = true;
                SceneManager.UnloadSceneAsync("pasillo");
                manager.pasillo = false;
                SceneManager.UnloadSceneAsync("negacion_N");
                manager.negacionN = false;
            }
        }
    }
}
