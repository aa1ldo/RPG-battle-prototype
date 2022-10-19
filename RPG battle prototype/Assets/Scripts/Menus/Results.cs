using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Results : MonoBehaviour
{
    public TMP_Text text;
    public void Quit_Menu()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }

    private void Update()
    {
        if (GameManager.Instance.YouWin && GameManager.Instance.BattleOver)
        {
            text.text = "Congratulations! You Win!";
        }
        else if (!GameManager.Instance.YouWin && GameManager.Instance.BattleOver)
        {
            text.text = "Bad luck! You lost.";
        }
    }
}
