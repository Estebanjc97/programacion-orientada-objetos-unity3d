using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jump = 5f;
    public Rigidbody2D rigidbodyPlayer;

    public float Xscale;

    private float x;

    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");

        rigidbodyPlayer.linearVelocity = new Vector2(x * speed, rigidbodyPlayer.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbodyPlayer.linearVelocity = new Vector2(rigidbodyPlayer.linearVelocity.x, jump);
        }
    }

    private void Flip()
    {
        if (transform.localScale.x == Xscale)
        {
            transform.localScale = new Vector3(-Xscale, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(Xscale, 1, 1);
        }
    }
}
