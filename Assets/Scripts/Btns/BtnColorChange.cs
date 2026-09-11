using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnColorChange : MonoBehaviour
{
    [SerializeField] private PlayersColorChange player1ColorChange;
    [SerializeField] private PlayersColorChange player2ColorChange;
    [SerializeField] private Button player1ChangeColor;
    [SerializeField] private TMP_Text textPlayer1OverColor;
    [SerializeField] private TMP_Text textP1ChangeColorBtn;
    [SerializeField] private Button player2ChangeColor;
    [SerializeField] private TMP_Text textPlayer2OverColor;
    [SerializeField] private TMP_Text textP2ChangeColorBtn;

    private void Awake()
    {
        player1ChangeColor.onClick.AddListener(OnPlayer1ChangeColor);
        player2ChangeColor.onClick.AddListener(OnPlayer2ChangeColor);
    }

    private void Start()
    {
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
        player1ColorChange.RandomColor();
    }

    private void OnPlayer2ChangeColor()
    {
        player2ColorChange.RandomColor();
    }
}
