using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SizeChange : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player1;
    [SerializeField] private PlayerDataSo player2;
    [SerializeField] private TMP_Text textChangeSize;
    [SerializeField] private Slider player1Size;
    [SerializeField] private TMP_Text textPlayer1Size;
    [SerializeField] private TMP_Text textSizeOfPlayer1;
    [SerializeField] private Slider player2Size;
    [SerializeField] private TMP_Text textPlayer2Size;
    [SerializeField] private TMP_Text textSizeOfPlayer2;
    private int fontSizeBtns = 30;
    
    private void Awake()
    {
        player1Size.onValueChanged.AddListener(OnPlayer1SizeChange);
        player2Size.onValueChanged.AddListener(OnPlayer2SizeChange);
    }

    private void OnEnable()
    {
        player1Size.value = player1.verticalSize;
        player2Size.value = player2.verticalSize;
    }

    private void Start()
    {
        textChangeSize.text = "CAMBIA EL TAMAÑO DEL JUGADOR 1";
        textChangeSize.alignment = TextAlignmentOptions.Center;
        textChangeSize.fontSize = fontSizeBtns;

        textPlayer1Size.text = "Tamaño del jugador 1";
        textPlayer1Size.alignment = TextAlignmentOptions.Center;

        textPlayer2Size.text = "Tamaño del jugador 2";
        textPlayer2Size.alignment = TextAlignmentOptions.Center;

        player1Size.value = player1.verticalSize;
        textSizeOfPlayer1.text = player1.verticalSize.ToString("F1");

        player2Size.value = player2.verticalSize;
        textSizeOfPlayer2.text = player2.verticalSize.ToString("F1");
    }

    private void OnDestroy()
    {
        player1Size.onValueChanged.RemoveAllListeners();
        player2Size.onValueChanged.RemoveAllListeners();
    }

    private void OnPlayer1SizeChange(float value)
    {
        player1.verticalSize = value;
        textSizeOfPlayer1.text = value.ToString("F1");
    }

    private void OnPlayer2SizeChange(float value)
    {
        player2.verticalSize = value;
        textSizeOfPlayer2.text = value.ToString("F1");
    }
}