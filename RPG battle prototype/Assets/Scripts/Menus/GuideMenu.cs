using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideMenu : MonoBehaviour
{
    public AudioSource spraySFX;
    public void ReturnButton()
    {
        spraySFX.Play();
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
