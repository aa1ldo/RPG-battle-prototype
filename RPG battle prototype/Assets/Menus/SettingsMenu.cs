using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public void Return_Button()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
