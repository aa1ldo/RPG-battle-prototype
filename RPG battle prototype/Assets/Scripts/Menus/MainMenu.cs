using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    int width = 1080;
    int height = 1920;

    public AudioClip buttonSFX;

    private void Start()
    {
        GameManager.Instance.PlayMusic("MainMenu");
        Screen.SetResolution(width, height, true);
    }

    public void Play_Button()
    {
        GameManager.Instance.PauseMusic("MainMenu", "stop");
        GameManager.Instance.PlaySound(buttonSFX);
        MenuManager.OpenMenu(Menu.OUTFIT_SELECT, gameObject);
    }

    public void Guide_Button()
    {
        GameManager.Instance.PlaySound(buttonSFX);
        MenuManager.OpenMenu(Menu.GUIDE_MENU, gameObject);
    }

    public void Settings_Button()
    {
        GameManager.Instance.PlaySound(buttonSFX);
        MenuManager.OpenMenu(Menu.SETTINGS_MENU, gameObject);
    }
}
