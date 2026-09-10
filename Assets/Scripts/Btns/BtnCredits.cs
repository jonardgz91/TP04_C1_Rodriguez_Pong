using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnCredits : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditsMenu;
    [SerializeField] Button creditsBtn;
    [SerializeField] TMP_Text textCreditsBtn;
    private int fontSizeBtns = 40;

    private void Awake()
    {
        creditsBtn.onClick.AddListener(CreditsClicked);
    }

    private void Start()
    {
        textCreditsBtn.text = "Credits";
        textCreditsBtn.fontSize = fontSizeBtns;
    }

    private void OnDestroy()
    {
        creditsBtn.onClick.RemoveAllListeners();
    }

    private void CreditsClicked()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }
}
