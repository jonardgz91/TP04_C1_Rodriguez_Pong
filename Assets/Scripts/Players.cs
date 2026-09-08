using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    [SerializeField] private KeyCode moveUp;
    [SerializeField] private KeyCode moveDown;
    [SerializeField] public Rigidbody2D player;

    private void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(moveUp))
        {
            //player.position += (new Vector2(0, moveSpeed * Time.fixedDeltaTime));
            player.AddForce(new Vector2(0, moveSpeed * Time.fixedDeltaTime));
        }

        if (Input.GetKey(moveDown))
        {
            //player.position += (new Vector2(0, -moveSpeed * Time.fixedDeltaTime));
            player.AddForce(new Vector2(0, -moveSpeed * Time.fixedDeltaTime));
        }
    }

    public void SetVerticalSize(float newSize)
    {
        Vector3 scale = transform.localScale;
        scale.y = newSize;
        transform.localScale = scale;
    }
}
