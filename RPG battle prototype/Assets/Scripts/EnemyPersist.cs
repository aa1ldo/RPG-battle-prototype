using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPersist : MonoBehaviour
{
    public EnemyManager enemyManager;
    Image accessory;
    Image top;
    Image bottoms;
    Image shoes;

    public Sprite[] cuteClothing = new Sprite[4];
    public Sprite[] casualClothing = new Sprite[4];
    public Sprite[] edgyClothing = new Sprite[4];

    private void OnEnable()
    {
        accessory = gameObject.transform.Find("Accessory").gameObject.GetComponent<Image>();
        top = gameObject.transform.Find("Top").gameObject.GetComponent<Image>();
        bottoms = gameObject.transform.Find("Bottoms").gameObject.GetComponent<Image>();
        shoes = gameObject.transform.Find("Shoes").gameObject.GetComponent<Image>();
    }

    private void Update()
    {
        if(enemyManager.currentStyle == "CUTE")
        {
            accessory.sprite = cuteClothing[0];
            top.sprite = cuteClothing[1];
            bottoms.sprite = cuteClothing[2];
            shoes.sprite = cuteClothing[3];
        }
        else if(enemyManager.currentStyle == "CASUAL")
        {
            accessory.sprite = casualClothing[0];
            top.sprite = casualClothing[1];
            bottoms.sprite = casualClothing[2];
            shoes.sprite = casualClothing[3];
        }
        else if(enemyManager.currentStyle == "EDGY")
        {
            accessory.sprite = edgyClothing[0];
            top.sprite = edgyClothing[1];
            bottoms.sprite = edgyClothing[2];
            shoes.sprite = edgyClothing[3];
        }
    }
}
