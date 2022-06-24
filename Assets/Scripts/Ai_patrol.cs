using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_patrol : MonoBehaviour
{


    public float walkSpeed,range;
    [HideInInspector]
    public bool mustPatrol;
    public bool mustTurn;
    public Transform groundCheckPos;
    public LayerMask groundLayer;
    public Rigidbody2D rb;
    public Collider2D bodyCollider;
    public Transform player;


    private float distplayer;
    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        distplayer = Vector2.Distance(transform.position, player.position);
        if (mustPatrol){ 
        Patrol();
        }

        if (distplayer<= range)
            if (player.position.x > transform.position.x && transform.localScale.x < 0 || player.position.x < transform.position.x && transform.localScale.x > 0) Flip();

    }
    private void FixedUpdate()
    {
        if (mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer);
        }
    }

    void Patrol()
    {
        if (mustTurn || bodyCollider.IsTouchingLayers(groundLayer))
        {
            Flip(); 
        }

        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void Flip()
    {
        mustPatrol = false;
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }


}
