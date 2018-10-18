using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 axis;
    private CharacterController controller;
    private Vector3 moveDirection;
    public float speed;
    public float tspeed;
    private float forceToGround = Physics.gravity.y;
    public float gravityMagnitude;
    public bool jump;
    public float jumpSpeed;
    public bool tocandoSuelo;
    public bool speedMod;
    private Vector3 tranformDirection;


    //mecanica pull/push
    public bool cerca;
    public float distance;
    public LayerMask mask;
    private RaycastHit hit;
    private Ray ray;
    private float speedPP;
    private bool fspeedPP = false;
    private Vector3 direccion_rayo;
    private int pos = 0;
    private int objSelec = 0;
    private float x;
    private float z;
    private Vector3 origen;
    public Vector3 DistanciaRayo;
    public bool trepar;
    private RaycastHit Cubito;
    
    

    // Use this for initialization
    void Start ()
    {
        controller = GetComponent<CharacterController>();
        tspeed = speed;
        speedMod = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        tocandoSuelo = controller.isGrounded;
        if (tocandoSuelo && !jump)//Dice si el controler esta tocando el suelo
        {
            moveDirection.y = forceToGround;
            gravityMagnitude = 5;
        }
        else if(!tocandoSuelo && jump)
        {
            gravityMagnitude = 5;
            moveDirection.y = forceToGround;
        }
        else
        {
            jump = false;
            moveDirection.y += Physics.gravity.y * gravityMagnitude * Time.deltaTime;
        }
        //transforma el movimiento del moundo al del local
        tranformDirection = axis.x * transform.right + axis.y * transform.forward;

        if(!trepar)
        {
            moveDirection.x = tranformDirection.x * speed;
            moveDirection.z = tranformDirection.z * speed;
        }
            controller.Move(moveDirection * Time.deltaTime);//Mueve el controller
        
       

        #region Cojer objeto 
        hit = new RaycastHit();
        

        if(objSelec == 0)
        {

            int num1 = 0;
            int num2 = 0;
            
            if(axis.x > 0) 
            {
                num1 = 1;
                pos = 1;
                Debug.Log("Derecha");
            }   
            else if(axis.x < 0)
            {
                num1 = -1;
                num2 = 0;
                pos = 2;
                Debug.Log("Izquierda");
            }

            if(axis.y > 0) 
            {
                num2 = 1;
                pos = 3;
                Debug.Log("Alante");
                
            }   
            else if(axis.y < 0)
            {
                num2 = -1;
                num1 = 0;
                pos = 4;
                Debug.Log("Atras");
            }

            if(axis.x == 0 && axis.y == 0)
            {
                Debug.Log("Parado");
                switch(pos)
                {
                    case 1:
                        num1 = 1;
                        num2 = 0;
                        break;
                    case 2:
                        num1 = -1;
                        num2 = 0;
                        break;
                    case 3:
                        num1 = 0;
                        num2 = 1;
                        break;
                    case 4:
                        num1 = 0;
                        num2 = -1;
                        break;
                }
            }

            x = 1.1f * axis.x + num1;
            z = 1.1f * axis.y + num2;
        }
           

       origen = transform.position;
       int sing = 1;
        for(int i = 0; i < 3; i++)
        {
            direccion_rayo = new Vector3( x, 0, z);
            ray = new Ray(origen, direccion_rayo);
            if (Physics.Raycast(ray, out hit, distance, mask))
            {
                Debug.Log("Estoy cerca");
                Debug.Log(hit.transform.name);
                //Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.red, 1);
                switch(i)
                {
                    case 0:
                            if(hit.collider.tag == "Object")
                            {
                                Debug.Log("Es una caja movible");
                                cerca = true;
                            }
                            else if(hit.collider.tag == "Trepar")
                            {
                                Debug.Log("Es una pared escalabre");
                                trepar = true;
                            }
                            else
                            {
                                cerca = false;
                                trepar = false;
                            }
                            break;
                    case 1:

                    case 2:

                    break;

                }
                
            }
            else
            {
                if(i == 0)
                {
                    cerca = false;
                    
                }
                if(i == 2)
                {
                    trepar = false;
                }
                
            }
            origen.y += sing * (i + 1) * DistanciaRayo.y;
            sing *= -1;
        }
        
    #endregion

        

    }

    public void SetAxis(Vector2 naxis)
    {
        axis = naxis;
    }

    public void StartJump()
    {
        if(!controller.isGrounded)
        {
            gravityMagnitude = 1f;
            speed = 15;
            Debug.Log("Planear");
        }
        else
        {
            speed = 15;
            jump = true;
            moveDirection.y = jumpSpeed;
            Debug.Log("Saltar");
        }            
        
    }

    public void PullPush()
    {
        if(hit.transform != null)
        {
            Cubito = hit;
            Cubito.transform.parent = transform;
            objSelec = 1;

            if(!fspeedPP)
            {
                speedPP = speed;
                speed = speed / 2;
                fspeedPP = true;
            }
        }
        
       
    }

    public void NoPullPush()
    {
        Cubito.transform.parent = null;
        objSelec = 0;
        if (fspeedPP)
        {
            speed = speedPP;
            fspeedPP = false;
        }

    }

    public void run()
    {
        if(controller.isGrounded)
        {
            speed = tspeed + 2f;
            speedMod = true;
        }
    }

    public void walk()
    {
        if(controller.isGrounded && jump)
        {
            speed = tspeed;
            speedMod = false;
        }
    }

    public void sneeky()
    {
        if(controller.isGrounded)
        {
            speed = tspeed - 2f;
            speedMod = true;
        }
    }

    public void Escalar()
    {
        if(pos == 1 || pos == 2)//Derecha izquierda
        {
            moveDirection.y = tranformDirection.x * speed;
        }
        else
        {
            moveDirection.y = tranformDirection.z * speed;
        }
    }

    private void OnDrawGizmos()
    {
        origen = transform.position;
        int sing = 1;
        for (int i = 0; i < 3; i++)
        {
            Gizmos.color = Color.blue;
            //Printamos un gizmo con la forma del rayo
            Gizmos.DrawRay(origen, direccion_rayo * distance);
            
            origen.y += sing * (i + 1) * DistanciaRayo.y;
            sing *= -1;
        }    
    }


}
