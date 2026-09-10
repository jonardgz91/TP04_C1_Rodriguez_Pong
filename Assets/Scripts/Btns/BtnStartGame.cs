using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartGameBtn : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] Button startGameBtn;
    [SerializeField] TMP_Text textStartGameBtn;
    private int fontSizeBtns = 40;

    private void Awake()
    {
        startGameBtn.onClick.AddListener(StartGameClicked);
    }

    private void Start()
    {
        textStartGameBtn.text = "Start Game";
        textStartGameBtn.fontSize = fontSizeBtns;
    }

    private void OnDestroy()
    {
        startGameBtn.onClick.RemoveAllListeners();
    }

    private void StartGameClicked()
    {
        mainMenu.SetActive(false);
        SceneManager.LoadScene("Gameplay");
    }
}
