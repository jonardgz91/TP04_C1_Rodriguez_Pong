using UnityEngine;

public class PlayersColorChange : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;

    public void RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        player.color = new Color(r, g, b);
    }
}
