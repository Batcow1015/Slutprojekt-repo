using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playascript : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed = 10;
    public float JumpStrength = 900;
    Vector3 startposition = new Vector3();
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startposition = transform.position;
        sr = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.R))
        {
            transform.position = startposition;
        }


        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            sr.flipX = false;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            sr.flipX = true;
        }


        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Onground ())
        {
            rb.AddForce(new Vector2(0, JumpStrength));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            transform.position = startposition;
        }

        if (collision.gameObject.tag == "Enemy")
        {
            transform.position = startposition;
        }

    }

    bool Onground()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.0f, LayerMask.GetMask("Ground"));
        if (hit.collider == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }




}
