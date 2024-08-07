using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private AudioClip dashSound;
    private float speed = 10.0f;
    private Rigidbody rb;
    private bool canDash = true;
    private ParticleSystem dashParticle;
    private float maxY = 1.0f;
    private Vector3 GetMoveDirection()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        return Vector3.Lerp(rb.velocity / speed, moveDirection, 0.2f);
    }

    private float GetForwardDirection()
    {
        return Mathf.Atan2(rb.velocity.x, rb.velocity.z) * Mathf.Rad2Deg;
    }

    IEnumerator DashColldown()
    {
        canDash = false;
        yield return new WaitForSeconds(StatusManager.instance.DASH_COOLTIME);
        canDash = true;
    }

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        GameObject dash = Instantiate(Resources.Load<GameObject>("Prefabs/Particle/DashParticle"), this.transform.position + new Vector3(0, 0, -0.5f), Quaternion.identity);
        dash.transform.SetParent(this.transform);
        dashParticle = dash.GetComponent<ParticleSystem>();
        dashParticle.Stop();
    }

    void Update()
    {
        speed = StatusManager.instance.PLAYER_SPEED;

        if (Input.GetKeyDown(KeyCode.Space) && canDash)
        {
            rb.AddForce(this.transform.forward * 12 * StatusManager.instance.DASH_POWER, ForceMode.Impulse);
            StartCoroutine("DashColldown");
            dashParticle.Play();
            SoundManager.instance.PlaySe(dashSound, 0.8f);
        }
        maxY = 0.5f + (StatusManager.instance.PLAYER_SIZE / 2);
        float y = Mathf.Min(maxY, this.transform.position.y);
        this.transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
    }

    void FixedUpdate()
    {
        rb.velocity = GetMoveDirection() * speed;
        if (rb.velocity.magnitude > 0.1f)
        {
            rb.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0f, GetForwardDirection(), 0f), Time.deltaTime * 10f);
        }

        rb.AddForce(Vector3.down * 50, ForceMode.Acceleration);
    }
}
