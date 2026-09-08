using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject settingsMenu;
    [SerializeField] GameObject creditsMenu;

    private void Start()
    {
        settingsMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }
}
