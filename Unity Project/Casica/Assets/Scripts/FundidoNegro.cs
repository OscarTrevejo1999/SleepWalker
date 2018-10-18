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
        if (SceneManager.GetActiveScene().name == "negacion_N" && !manager.negacionDone)
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
            if(alpha > 1)
            {
                manager.negacionDone = true;
                SceneManager.LoadScene("negacion_D");
            }
        }
    }

}
