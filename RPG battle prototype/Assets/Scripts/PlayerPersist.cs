using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPersist : MonoBehaviour
{
    public OutfitSelect outfitSelect;

    public Image style;
    public Sprite cuteImage;
    public Sprite casualImage;
    public Sprite edgyImage;

    Image accessory;
    Image top;
    Image bottoms;
    Image shoes;

    private void OnEnable()
    {
        accessory = gameObject.transform.Find("Accessory").gameObject.GetComponent<Image>();
        top = gameObject.transform.Find("Top").gameObject.GetComponent<Image>();
        bottoms = gameObject.transform.Find("Bottoms").gameObject.GetComponent<Image>();
        shoes = gameObject.transform.Find("Shoes").gameObject.GetComponent<Image>();

        if (outfitSelect.CalculateStyle() == 0)
        {
            style.sprite = cuteImage;
        }
        else if (outfitSelect.CalculateStyle() == 1)
        {
            style.sprite = casualImage;
        }
        else if (outfitSelect.CalculateStyle() == 2)
        {
            style.sprite = edgyImage;
        }

        accessory.sprite = outfitSelect.headCurrent;
        top.sprite = outfitSelect.torsoCurrent;
        bottoms.sprite = outfitSelect.legsCurrent;
        shoes.sprite = outfitSelect.feetCurrent;
    }
}
