using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Vector2 axis;

    private CharacterController controller;

    public float speed;

    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }



    
	
	void Update ()
    {

        Vector3 transformDirection = axis.x * transform.right + axis.y * transform.forward;

        moveDirection.x = transformDirection.x * speed;
        moveDirection.z = transformDirection.z * speed;

        controller.Move(moveDirection * Time.deltaTime);
	}

    public void SetAxis(Vector2 inputAxis)
    {
        axis = inputAxis;
    }

}
