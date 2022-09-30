using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void Play_Button()
    {
        StartCoroutine(PlayAnimation());
    }

    public void Guide_Button()
    {
        StartCoroutine(GuideAnimation());
    }

    public void Settings_Button()
    {
        MenuManager.OpenMenu(Menu.SETTINGS_MENU, gameObject);
    }


    IEnumerator PlayAnimation()
    {
        yield return new WaitForSeconds(0.2f);
        MenuManager.OpenMenu(Menu.OUTFIT_SELECT, gameObject);
    }

    IEnumerator GuideAnimation()
    {
        yield return new WaitForSeconds(0.2f);
        MenuManager.OpenMenu(Menu.GUIDE_MENU, gameObject);
    }
}
