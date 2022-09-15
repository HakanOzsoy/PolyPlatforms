using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float MovementSpeed = 5;
    public static float JumpSpeed = 10;
    public static bool isGrounded;
    static bool candoublejump;
    const float groundCheckRadius = 0.3f;
    public LayerMask groundLayer;
    public Transform groundCheckCollider;
    public AudioSource coinSound;

    static Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GroundCheck();
        //var movement = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if ((Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)))
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;
        }

        if ((Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;
        }

        if (PressedRight.Rispressed)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;
            //rb.velocity = new Vector2(MovementSpeed, rb.velocity.y);
        }

        if (PressedLeft.Lispressed)
        {
            //rb.velocity = new Vector2(-MovementSpeed, rb.velocity.y);
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;
        }
    }

    void Update()
    {
        if ((Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            if (isGrounded)
            {
                rb.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);
                //GetComponent<Rigidbody2D>().velocity = Vector2.up * JumpSpeed;
                candoublejump = true;
            }
            else if (candoublejump)
            {
                candoublejump = false;
                rb.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);   //Old: 2 * JumpSpeed / 3
            }
        }

        if ((Input.GetKeyUp("w") || Input.GetKeyUp(KeyCode.UpArrow)))
        {
            rb.AddForce(new Vector2(0, -2), ForceMode2D.Impulse);
        }
    }

    void GroundCheck()
    {
        isGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
        if (colliders.Length > 0)
        {
            isGrounded = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            coinSound.Play();
            Coin.LevelCoins++;
            Destroy(other.gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            transform.parent = col.transform;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            transform.parent = null;
        }
    }

    public static void JumpFromButton()
    {       
        if (isGrounded)
        {
            rb.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);
            candoublejump = true;
        }
        else if (candoublejump)
        {
            candoublejump = false;
            rb.AddForce(new Vector2(0, 2 * JumpSpeed / 3), ForceMode2D.Impulse);
        }
    }
}
