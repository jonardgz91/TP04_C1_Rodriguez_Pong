using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnSettings : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject settingsMenu;
    [SerializeField] Button settingsMenuBtn;
    [SerializeField] TMP_Text textSettingsMenu;
    private int fontSizeBtns = 30;

    private void Awake()
    {
        settingsMenuBtn.onClick.AddListener(SettingsClicked);
    }
    private void Start()
    {
        textSettingsMenu.text = "Settings";
        textSettingsMenu.fontSize = fontSizeBtns;
    }

    private void OnDestroy()
    {
        settingsMenuBtn.onClick.RemoveAllListeners();
    }

    private void SettingsClicked()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

}
