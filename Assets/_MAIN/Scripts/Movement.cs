using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D rigidbodyPlayer;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rigidbodyPlayer.MovePosition(rigidbodyPlayer.position + new Vector2(x, y) * speed * Time.fixedDeltaTime);
    }

}
