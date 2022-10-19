using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitDisplay : MonoBehaviour
{
    public OutfitSelect outfitSelect;
    Image accessory;
    Image top;
    Image bottoms;
    Image shoes;

    private void OnEnable()
    {
        accessory = gameObject.transform.Find("Head").gameObject.GetComponent<Image>();
        top = gameObject.transform.Find("Top").gameObject.GetComponent<Image>();
        bottoms = gameObject.transform.Find("Legs").gameObject.GetComponent<Image>();
        shoes = gameObject.transform.Find("Feet").gameObject.GetComponent<Image>();
    }

    private void Update()
    {
        accessory.sprite = outfitSelect.headCurrent;
        top.sprite = outfitSelect.torsoCurrent;
        bottoms.sprite = outfitSelect.legsCurrent;
        shoes.sprite = outfitSelect.feetCurrent;
    }
}
