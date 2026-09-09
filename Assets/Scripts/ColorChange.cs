using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player1;
    [SerializeField] private PlayerDataSo player2;
    [SerializeField] private Button player1ChangeColor;
    [SerializeField] private TMP_Text textPlayer1OverColor;
    [SerializeField] private TMP_Text textP1ChangeColorBtn;
    [SerializeField] private Button player2ChangeColor;
    [SerializeField] private TMP_Text textPlayer2OverColor;
    [SerializeField] private TMP_Text textP2ChangeColorBtn;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        player1ChangeColor.onClick.AddListener(OnPlayer1ChangeColor);
        player2ChangeColor.onClick.AddListener(OnPlayer2ChangeColor);
    }

    private void Start()
    {
        //spriteRenderer.color = player1.color;
        //spriteRenderer.color = player2.color;

        textPlayer1OverColor.text = "Color del jugador 1";
        textPlayer2OverColor.text = "Color del jugador 2";

        textP1ChangeColorBtn.text = "Cambiar Color P1";
        textP2ChangeColorBtn.text = "Cambiar Color P2";
    }

    private void OnDestroy()
    {
        player1ChangeColor.onClick.RemoveAllListeners();
        player2ChangeColor.onClick.RemoveAllListeners();
    }

    private void OnPlayer1ChangeColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        player1.color = new Color(r, g, b);
    }

    private void OnPlayer2ChangeColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        player2.color = new Color(r, g, b);
    }
}
