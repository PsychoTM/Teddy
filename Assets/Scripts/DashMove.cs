using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{

    private Rigidbody rb;
    public float dashSpeed;
    public float dashTime;
    public float startDashTime;
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                direction = 2;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                direction = 3;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                direction = 4;
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector3.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
            }
            if (direction == 1)
            {
                rb.velocity = Vector3.left * dashSpeed;
            }
            else if (direction == 2)
            {
                rb.velocity = Vector3.right * dashSpeed;
            }
            else if (direction == 3)
            {
                rb.velocity = Vector3.forward * dashSpeed;
            }
            else if (direction == 4)
            {
                rb.velocity = Vector3.back * dashSpeed;
            }
        }
    }
}
