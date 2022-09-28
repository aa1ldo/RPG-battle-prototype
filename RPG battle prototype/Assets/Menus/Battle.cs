using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public GameObject quitModal;
    public void Run_Button()
    {
        quitModal.SetActive(true);
    }

    // In modal window:
    public void Quit_Button()
    {
        quitModal.SetActive(false);
        // Reset player + enemy health
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }

    public void Stay_Button()
    {
        quitModal.SetActive(false);
    }
}
