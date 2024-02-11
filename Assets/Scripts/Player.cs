using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float SPEED = 10.0f;
    private Rigidbody rb;

    private Vector3 GetMoveDirection()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        return Vector3.Lerp(rb.velocity / SPEED, moveDirection, 0.2f);
    }

    private float GetForwardDirection()
    {
        return Mathf.Atan2(rb.velocity.x, rb.velocity.z) * Mathf.Rad2Deg;
    }

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        rb.velocity = GetMoveDirection() * SPEED;
        if (rb.velocity.magnitude > 0.1f)
        {
            rb.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0f, GetForwardDirection(), 0f), Time.deltaTime * 10f);
        }

        rb.AddForce(Vector3.down * 50, ForceMode.Acceleration);
    }
}
