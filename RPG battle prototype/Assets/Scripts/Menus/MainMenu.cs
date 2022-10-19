using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void Play_Button()
    {
        MenuManager.OpenMenu(Menu.OUTFIT_SELECT, gameObject);
    }

    public void Guide_Button()
    {
        MenuManager.OpenMenu(Menu.GUIDE_MENU, gameObject);
    }

    public void Settings_Button()
    {
        MenuManager.OpenMenu(Menu.SETTINGS_MENU, gameObject);
    }
}
