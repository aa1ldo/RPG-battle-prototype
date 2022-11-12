using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public AudioSource spraySFX;
    int width = 1080;
    int height = 1920;

    private void OnEnable()
    {
        Screen.SetResolution(width, height, true);
    }

    public void Play_Button()
    {
        spraySFX.Play();
        MenuManager.OpenMenu(Menu.OUTFIT_SELECT, gameObject);
    }

    public void Guide_Button()
    {
        spraySFX.Play();
        MenuManager.OpenMenu(Menu.GUIDE_MENU, gameObject);
    }

    public void Settings_Button()
    {
        spraySFX.Play();
        MenuManager.OpenMenu(Menu.SETTINGS_MENU, gameObject);
    }
}
