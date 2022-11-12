using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public AudioSource spraySFX;
    public void Return_Button()
    {
        spraySFX.Play();
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
