using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackBtn : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject settingsMenu;
    [SerializeField] private Button backBtn;
    [SerializeField] private TMP_Text textBackBtn;
    private int fontSizeBtns = 50;

    private void Awake()
    {
        backBtn.onClick.AddListener(BackBtnClicked);
    }
    private void Start()
    {
        textBackBtn.text = "Atras";
        textBackBtn.fontSize = fontSizeBtns;
    }
    private void OnDestroy()
    {
        backBtn.onClick.RemoveAllListeners();
    }

    private void BackBtnClicked()
    {
        string activeScene = SceneManager.GetActiveScene().name;

        if (activeScene == "Gameplay")
        {
            settingsMenu.SetActive(false);
            Time.timeScale = 1;
        }
        else if (activeScene == "UI.General")
        {
            settingsMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
}