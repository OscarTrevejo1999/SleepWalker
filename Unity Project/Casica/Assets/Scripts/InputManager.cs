using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerController PC;


    private float sensitivity = 3.0f;
    private bool fPP = false;
    public bool jump = false;
    public int status; 



    // Use this for initialization
    void Start ()
    {
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        status = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Player
        Vector2 inputAxis = Vector2.zero;

        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");

        PC.SetAxis(inputAxis);
        //Jump
        if(PC.tocandoSuelo)
        {
                
                if (status == 0 && Input.GetButton("Jump") && !jump)
                {
                    PC.StartJump();
                    jump = true;
                    Debug.Log("Salto");
                    status = 1;
                }
                else if (status != 0 && !Input.GetButton("Jump"))
                {
                    status = 0;
                    jump = false;
                }
          }
        else
        {
            if(status == 1 && !Input.GetButton("Jump"))
            {
                jump = false;
                
                status = 2;
            }

            if (status == 2 && Input.GetButton("Jump"))
            {
                Debug.Log("planeo");
                PC.StartJump();
                status = 3;
            }
            
            if(status == 3 && !Input.GetButton("Jump"))
            {
                status = 0;
                PC.jump = true;
                jump = false;
            }
            

        }
         
        //push/pull
        if(PC.cerca)
        {
            if(Input.GetKey(KeyCode.Mouse0))
            {
                Debug.Log("Te cojo perra");
                PC.PullPush();
                fPP = true;
            }
            else
            {
                if(fPP)
                {
                    Debug.Log("No Te cojo perra");
                    PC.NoPullPush();
                    fPP = false;
                }
            }
        }
        else
        {
            if(fPP)
                {
                    Debug.Log("No Te cojo perra");
                    PC.NoPullPush();
                    fPP = false;
                }
        }

        //Trepar
        if(PC.trepar)
        {
            if(Input.GetKey(KeyCode.Mouse0))
            {
                Debug.Log("Voy a escalar");
                PC.Escalar();
            }

        }


        //run/walk/sneeky
        if(Input.GetKey(KeyCode.LeftControl))
        {
            PC.sneeky();
        }
        else if(Input.GetKey(KeyCode.LeftShift))
        {
            PC.run();
        }
        else
        {
            PC.walk();
        }

        //Inmune
         if(Input.GetKeyDown(KeyCode.F10))
        {
            PC.Inmune();
        }

        if(PC.inmune)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                PC.vy = 1;
            }
            else if(Input.GetKey(KeyCode.LeftControl))
            {
                PC.vy = -1;
            }
            else
            {
                PC.vy = 0;
            }
        }
    }
}
