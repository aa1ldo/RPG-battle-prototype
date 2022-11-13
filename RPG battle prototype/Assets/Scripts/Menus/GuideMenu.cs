using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideMenu : MonoBehaviour
{
    public AudioClip returnSFX;
    public void ReturnButton()
    {
        GameManager.Instance.PlaySound(returnSFX);
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
