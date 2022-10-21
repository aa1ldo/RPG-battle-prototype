using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StyleDisplay : MonoBehaviour
{
    public EnemyManager enemyManager;

    Image image;

    public Sprite cuteDisplay;
    public Sprite casualDisplay;
    public Sprite edgyDisplay;

    private void OnEnable()
    {
        Debug.Log("Set Enemy Styledisplay");
        image = gameObject.GetComponent<Image>();

        if(enemyManager.currentStyle == "CUTE")
        {
            image.sprite = cuteDisplay;
        }
        else if (enemyManager.currentStyle == "CASUAL")
        {
            image.sprite = casualDisplay;
        }
        else if (enemyManager.currentStyle == "EDGY")
        {
            image.sprite = edgyDisplay;
        }
    }
}
