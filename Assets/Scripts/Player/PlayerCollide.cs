using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "TopLimit" || collision.gameObject.name == "DownLimit")
        {
            player.color = Color.black;
        }

        MoveBall ball = collision.gameObject.GetComponent<MoveBall>();

        if (ball != null)
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            player.color = new Color(r, g, b);
        }
    }
}