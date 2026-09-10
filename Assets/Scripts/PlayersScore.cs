using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayersScore : MonoBehaviour
{
    public int scoreP1 = 0;
    public int scoreP2 = 0;
    public bool matchOver = false;
    [SerializeField] private GameSettingsSo gameSettings;
    [SerializeField] private TMP_Text textScoreP1;
    [SerializeField] private TMP_Text textScoreP2;
    [SerializeField] public TMP_Text textContinue;
    [SerializeField] public TMP_Text textTimer;
    [SerializeField] GameObject ball;
    [SerializeField] private TMP_Text textMainMenuBtn;
    [SerializeField] private Button btnMainMenu;

    private void Awake()
    {
        btnMainMenu.onClick.AddListener(btnMainMenuClicked);
    }

    private void Start()
    {
        textContinue.gameObject.SetActive(false);
        btnMainMenu.gameObject.SetActive(false);

        textMainMenuBtn.text = "Main Menu";
    }

    public void AddPointPlayer1()
    {
        scoreP1++;
        textScoreP1.text = scoreP1.ToString();
        textScoreP1.alignment = TextAlignmentOptions.Center;

        textContinue.gameObject.SetActive(true);

        if (scoreP1 == gameSettings.pointsToWin)
        {
            textContinue.text = "Player 1 Wins!";
            textContinue.alignment = TextAlignmentOptions.Center;
            ball.gameObject.SetActive(false);
            matchOver = true;

            btnMainMenu.gameObject.SetActive(true);
        }
        else
        {
            textContinue.text = "Press SPACEBAR for next round";
            textContinue.alignment = TextAlignmentOptions.Center;
        }

    }

    public void AddPointPlayer2()
    {
        scoreP2++;
        textScoreP2.text = scoreP2.ToString();
        textScoreP2.alignment = TextAlignmentOptions.Center;

        textContinue.gameObject.SetActive(true);

        if (scoreP2 == gameSettings.pointsToWin)
        {
            textContinue.text = "Player 2 Wins!";
            textContinue.alignment = TextAlignmentOptions.Center;
            ball.gameObject.SetActive(false);
            matchOver = true;

            btnMainMenu.gameObject.SetActive(true);
        }
        else
        {
            textContinue.text = "Press SPACEBAR for next round";
            textContinue.alignment = TextAlignmentOptions.Center;
        }
    }

    private void btnMainMenuClicked()
    {
        SceneManager.LoadScene("UI.General");
    }
}
