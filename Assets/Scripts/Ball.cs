using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float ballSpeed = 6f;
    [SerializeField] private Rigidbody2D ball;
    float dirX = -1f;

    private void Start()
    {
        ballMovement();
    }

    private void ballMovement()
    {
        Vector2 direction = new Vector2(dirX, 0);
        ball.AddForce(direction * ballSpeed, ForceMode2D.Impulse);
    }
}
