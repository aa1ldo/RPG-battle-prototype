using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public AudioClip returnSFX;
    public void Return_Button()
    {
        GameManager.Instance.PlaySound(returnSFX);
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
