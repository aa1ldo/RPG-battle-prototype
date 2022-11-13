using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public AudioClip buttonSFX;
    public AudioClip returnSFX;

    public GameObject quitModal;

    private void OnEnable()
    {
        GameManager.Instance.PlayMusic("Battle");
    }

    public void Run_Button()
    {
        GameManager.Instance.PlaySound(buttonSFX);
        GameManager.Instance.PauseMusic("Battle", "pause");
        quitModal.SetActive(true);
        Time.timeScale = 0;
    }

    // In modal window:
    public void Quit_Button()
    {
        GameManager.Instance.PlaySound(returnSFX);
        GameManager.Instance.PauseMusic("Battle", "stop");
        quitModal.SetActive(false);
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
        GameManager.Instance.BattleOver = false;
        Time.timeScale = 1;
    }

    public void Stay_Button()
    {
        GameManager.Instance.PlaySound(buttonSFX);
        GameManager.Instance.PlayMusic("Battle");
        quitModal.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (GameManager.Instance.BattleOver)
        {
            GameManager.Instance.PauseMusic("Battle", "stop");
            MenuManager.OpenMenu(Menu.RESULTS, gameObject);
        }
    }
}
