using UnityEngine;

public class Players : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    [SerializeField] public Rigidbody2D rbPlayers;
    public float moveSpeed = 100f;
    private SpriteRenderer spriteRenderer;
    
    private void Awake()
    {
        rbPlayers = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void Start()
    {
        SetVerticalSize(player.verticalSize);
        moveSpeed = player.moveSpeed;
        spriteRenderer.color = player.color;
    }
    private void Update()
    {
        SetVerticalSize(player.verticalSize);
        moveSpeed = player.moveSpeed;
        spriteRenderer.color = player.color;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(player.moveUp))
        {
            rbPlayers.AddForce(new Vector2(0, moveSpeed * Time.fixedDeltaTime));
        }

        if (Input.GetKey(player.moveDown))
        {
            rbPlayers.AddForce(new Vector2(0, -moveSpeed * Time.fixedDeltaTime));
        }

        if (Input.GetKey(player.moveRight))
        {
            rbPlayers.AddForce(new Vector2(moveSpeed * Time.fixedDeltaTime, 0));
        }

        if (Input.GetKey(player.moveLeft))
        {
            rbPlayers.AddForce(new Vector2(-moveSpeed * Time.fixedDeltaTime, 0));
        }
    }

    public void SetVerticalSize(float verticalSize)
    {
        Vector3 scale = transform.localScale;
        scale.y = verticalSize;
        transform.localScale = scale;
    }
}