using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public AudioClip returnSFX;
    public Image image;

    public Sprite winSp;
    public Sprite loseSp;
    public void Quit_Menu()
    {
        GameManager.Instance.PlaySound(returnSFX);
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
        GameManager.Instance.BattleOver = false;
    }

    private void Update()
    {
        if (GameManager.Instance.YouWin && GameManager.Instance.BattleOver)
        {
            image.sprite = winSp;
        }
        else if (!GameManager.Instance.YouWin && GameManager.Instance.BattleOver)
        {
            image.sprite = loseSp;
        }
    }
}
