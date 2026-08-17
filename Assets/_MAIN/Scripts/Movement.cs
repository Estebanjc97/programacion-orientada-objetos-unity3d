using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jump = 5f;
    public Rigidbody2D rigidbodyPlayer;

    public float Xscale;

    private float x;

    //[Header("Ground Check")]
    //public Transform groundCheck;      // objeto vac�o en los pies del jugador
    //public float groundRadius = 0.2f;
    //public LayerMask groundLayer;      // capa que representa el suelo

    //private bool jumpRequest;
    //private bool isGrounded;

    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");

        rigidbodyPlayer.MovePosition(rigidbodyPlayer.position + new Vector2(x, 0f) * speed * Time.fixedDeltaTime);

        if (Input.GetKeyDown(KeyCode.F))
        {
            Flip();
        }
    }

    private void Flip()
    {
        if (transform.localScale.x == Xscale)
        {
            transform.localScale = new Vector3(-Xscale, 1, 1);
        } else
        {
            transform.localScale = new Vector3(Xscale, 1, 1);
        }
    }

    //private void FixedUpdate()
    //{
    //    //// Comprueba si el jugador est� tocando el suelo
    //    //isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);

    //    // Movimiento horizontal

    //    //if (Input.GetKeyDown(KeyCode.Space)/* && isGrounded*/)
    //    //{
    //    //    Debug.Log("Jump");
    //    //}
    //    // Salto
    //    if (jumpRequest)
    //    {
    //        Debug.Log("Actual Jump");
    //        rigidbodyPlayer.linearVelocity = new Vector2(rigidbodyPlayer.linearVelocity.x, jump);
    //        jumpRequest = false;
    //    }
    //}
}