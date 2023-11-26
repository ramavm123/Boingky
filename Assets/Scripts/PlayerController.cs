using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D player;
    private bool isGrounded;
    private SpriteRenderer spriteRenderer;
    public Animator animator;
    private AudioSource jumpAudio;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        jumpAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(moveInput * moveSpeed, player.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(moveInput));

        // Ajusta la orientación del sprite
        if (moveInput > 0)
        {
            spriteRenderer.flipX = false; // No se invierte en el eje x si se está moviendo a la derecha
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true; // Se invierte en el eje x si se está moviendo a la izquierda
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            player.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jumpAudio.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("IsJumping", false);
        }
        else if (collision.collider.CompareTag("End"))
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
            animator.SetBool("IsJumping", true);
        }
    }
}
