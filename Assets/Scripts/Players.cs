using UnityEngine;

public class Players : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    [SerializeField] public Rigidbody2D rbPlayers;
    //public float maxPlayerSpeed = 10f;
    public float moveSpeed = 2f;
    private SpriteRenderer spriteRenderer;
    private Vector3 playerStartPosition;
    [SerializeField] private float minX = -8.5f;
    [SerializeField] private float maxX = 0f;
    [SerializeField] private float minY = -4.5f;
    [SerializeField] private float maxY = 4.5f;

    private void Awake()
    {
        rbPlayers = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerStartPosition = transform.position;
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
            rbPlayers.linearVelocity += (new Vector2(0, moveSpeed * Time.fixedDeltaTime));
        }

        if (Input.GetKey(player.moveDown))
        {
            rbPlayers.linearVelocity += (new Vector2(0, -moveSpeed * Time.fixedDeltaTime));
        }

        if (Input.GetKey(player.moveRight))
        {
            rbPlayers.linearVelocity += (new Vector2(moveSpeed * Time.fixedDeltaTime, 0));
        }

        if (Input.GetKey(player.moveLeft))
        {
            rbPlayers.linearVelocity += (new Vector2(-moveSpeed * Time.fixedDeltaTime, 0));
        }

        Vector2 pos = rbPlayers.position;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        rbPlayers.position = pos;
    }

    public void SetVerticalSize(float verticalSize) 
    {
        Vector3 scale = transform.localScale;
        scale.y = verticalSize;
        transform.localScale = scale;
    }

    public void ResetPosition()
    {
        transform.position = playerStartPosition;
        rbPlayers.linearVelocity = Vector2.zero;
    }
}