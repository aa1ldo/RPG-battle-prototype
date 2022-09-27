using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Results : MonoBehaviour
{
    public void Quit_Menu()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
