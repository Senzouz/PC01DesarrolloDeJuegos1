using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float Speed = 5.0f;
    private Rigidbody2D rbPlayer;
    public Animator animator;
    public Vector2 dirOrig;

    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        dirOrig = transform.localScale;
}
    
    private void FixedUpdate()
    {
        Correr();
    }

    void Correr()
    {
        float input = Input.GetAxisRaw("Horizontal");
        if(input < 0)
        {
            Vector2 direccion = transform.localScale;
            direccion.x = -dirOrig.x;
            transform.localScale = direccion;
            rbPlayer.velocity = new Vector2(-Speed,0);
            animator.SetBool("Corriendo", true);
        } else if(input > 0)
        {
            Vector2 direccion = transform.localScale;
            direccion.x = dirOrig.x;
            transform.localScale = direccion;
            rbPlayer.velocity = new Vector2(Speed, 0);
            animator.SetBool("Corriendo", true);
        } else {
            transform.localScale = dirOrig;
            rbPlayer.velocity = Vector2.zero;
            animator.SetBool("Corriendo", false);
        }
    }
}