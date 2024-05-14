using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Movment : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public float rotationSpeed;
    public float movementSpeed;

    public float hp;
    private void Start()
    {

    }

    void Update()
    {
        if (GameTime.isPaused) return;


        horizontalInput = Input.GetAxis("Horizontal"); //declarem el movment
        verticalInput = Input.GetAxis("Vertical"); // declarem el movment

        //movment
        Vector3 movementDirection = new Vector3(horizontalInput, 0, 0);
        Vector3 rotationMovment = new Vector3(0, verticalInput * rotationSpeed * GameTime.deltaTime, 0);

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (-transform.right) * movementSpeed * GameTime.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (transform.right) * movementSpeed * GameTime.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + transform.forward * movementSpeed * GameTime.deltaTime;
        }
        
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (-transform.forward) * movementSpeed * Time.deltaTime;
        }


    }

    private void OnCollisionStay(Collision collision)
    {
        //if (collision.gameObject.tag == "Enemy")
        //{
        //    hp = hp - 10;
        //}
    }
}
