using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Movment : MonoBehaviour
{
    public float rotationSpeed;
    public float movementSpeed;

    public float jumpForce;

    public float jumpDistcance;
    public LayerMask Ground;
    public float hp;

    public GameObject orientation;
    public Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (GameTime.isPaused) return;

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(Vector3.up, -Time.deltaTime * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(gameObject.transform.forward.normalized * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(gameObject.transform.forward.normalized * -movementSpeed / 3 * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(gameObject.transform.position, Vector3.down, jumpDistcance, Ground) == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        //gameObject.transform.LookAt(orientation.transform.position);

    }

    void SpeedCap()
    {
        Vector3 flatvel = new Vector3(rb.velocity.x, 0.0f, rb.velocity.z);

        if (flatvel.magnitude > movementSpeed * 2f)
        {
            Vector3 limitedVel = flatvel.normalized * movementSpeed * 2f;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
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
