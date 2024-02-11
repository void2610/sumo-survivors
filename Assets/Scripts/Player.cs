using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float SPEED = 7.0f;
    private Rigidbody rb;
    private int forward = 0;
    private int right = 0;
    public void CheckMoveInput()
    {
        forward = 0;
        right = 0;
        if (Input.GetKey(KeyCode.W))
            forward = 1;
        else if (Input.GetKey(KeyCode.S))
            forward = -1;
        if (Input.GetKey(KeyCode.A))
            right = -1;
        else if (Input.GetKey(KeyCode.D))
            right = 1;
    }

    public Vector3 GetMoveDirection()
    {
        //TODO: マウス方向に移動もできるようにする
        Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        return Vector3.Lerp(rb.velocity / SPEED, moveDirection, 0.2f);
    }

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        CheckMoveInput();
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = GetMoveDirection();
        rb.velocity = moveDirection * SPEED;
    }
}
