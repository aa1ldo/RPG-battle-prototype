using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public GameObject quitModal;
    public void Run_Button()
    {
        quitModal.SetActive(true);
        Time.timeScale = 0;
    }

    // In modal window:
    public void Quit_Button()
    {
        quitModal.SetActive(false);
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
        Time.timeScale = 1;
    }

    public void Stay_Button()
    {
        quitModal.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (GameManager.Instance.BattleOver)
        {
            MenuManager.OpenMenu(Menu.RESULTS, gameObject);
        }
    }
}
