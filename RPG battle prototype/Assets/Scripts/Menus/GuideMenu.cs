using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideMenu : MonoBehaviour
{
    public void ReturnButton()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
