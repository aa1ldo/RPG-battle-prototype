using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitSelect : MonoBehaviour
{
    public void Return_Button()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }

    public void Continue_Button()
    {
        MenuManager.OpenMenu(Menu.BATTLE, gameObject);
    }
}
