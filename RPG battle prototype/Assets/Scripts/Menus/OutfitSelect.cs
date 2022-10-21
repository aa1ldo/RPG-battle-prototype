using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitSelect : MonoBehaviour
{
    public Sprite[] headAccessories;
    public string[] headStyles;
    public int headIndex = 0;
    [HideInInspector] public Sprite headCurrent; // Will be a sprite
    public string headStyleCurrent;

    public Sprite[] torsoTops;
    public string[] torsoStyles;
    public int torsoIndex = 0;
    [HideInInspector] public Sprite torsoCurrent;
    public string torsoStyleCurrent;

    public Sprite[] legsBottoms;
    public string[] legsStyles;
    public int legsIndex = 0;
    [HideInInspector] public Sprite legsCurrent;
    public string legsStyleCurrent;

    public Sprite[] feetShoes;
    public string[] feetStyles;
    public int feetIndex = 0;
    [HideInInspector] public Sprite feetCurrent;
    public string feetStyleCurrent;


    /*
    public int cuteStylePoints;
    public int casualStylePoints;
    public int edgyStylePoints;

    // These can be tweaked in the inspector:
    public int headPointsToAdd;
    public int torsoPointsToAdd;
    public int legsPointsToAdd;
    public int feetPointsToAdd;
    */

    public GameObject styleDisplay;
    Image styleImage;

    public Sprite[] styleImages;

    public bool continuePressed;

    private void Start()
    {
        headCurrent = headAccessories[headIndex];
        headStyleCurrent = headStyles[headIndex];

        torsoCurrent = torsoTops[torsoIndex];
        torsoStyleCurrent = torsoStyles[torsoIndex];

        legsCurrent = legsBottoms[legsIndex];
        legsStyleCurrent = legsStyles[legsIndex];

        feetCurrent = feetShoes[feetIndex];
        feetStyleCurrent = feetStyles[feetIndex];

        styleImage = styleDisplay.GetComponent<Image>();
        styleImage.sprite = styleImages[0];
    }

    public void RightButton_Head()
    {
        if(headIndex >= headAccessories.Length - 1)
        {
            headIndex = 0;
        }
        else
        {
            headIndex++;
        }

        headCurrent = headAccessories[headIndex];
        headStyleCurrent = headStyles[headIndex];

        styleImage.sprite = styleImages[CalculateStyle()];
    }

    public void LeftButton_Head()
    {
        if (headIndex <= 0)
        {
            headIndex = headAccessories.Length - 1;
        }
        else
        {
            headIndex--;
        }

        headCurrent = headAccessories[headIndex];
        headStyleCurrent = headStyles[headIndex];

        styleImage.sprite = styleImages[CalculateStyle()];
    }

    public void RightButton_Torso()
    {
        if (torsoIndex >= torsoTops.Length - 1)
        {
            torsoIndex = 0;
        }
        else
        {
            torsoIndex++;
        }

        torsoCurrent = torsoTops[torsoIndex];
        torsoStyleCurrent = torsoStyles[torsoIndex];

        styleImage.sprite = styleImages[CalculateStyle()];
    }

    public void LeftButton_Torso()
    {
        if (torsoIndex <= 0)
        {
            torsoIndex = torsoTops.Length - 1;
        }
        else
        {
            torsoIndex--;
        }

        torsoCurrent = torsoTops[torsoIndex];
        torsoStyleCurrent = torsoStyles[torsoIndex];

        styleImage.sprite = styleImages[CalculateStyle()];
    }

    public void RightButton_Legs()
    {
        if (legsIndex >= legsBottoms.Length - 1)
        {
            legsIndex = 0;
        }
        else
        {
            legsIndex++;
        }

        legsCurrent = legsBottoms[legsIndex];
        legsStyleCurrent = legsStyles[legsIndex];

        styleImage.sprite = styleImages[CalculateStyle()];
    }

    public void LeftButton_Legs()
    {
        if (legsIndex <= 0)
        {
            legsIndex = legsBottoms.Length - 1;
        }
        else
        {
            legsIndex--;
        }

        legsCurrent = legsBottoms[legsIndex];
        legsStyleCurrent = legsStyles[legsIndex];

        styleImage.sprite = styleImages[CalculateStyle()];
    }

    public void RightButton_Feet()
    {
        if (feetIndex >= feetShoes.Length - 1)
        {
            feetIndex = 0;
        }
        else
        {
            feetIndex++;
        }

        feetCurrent = feetShoes[feetIndex];
        feetStyleCurrent = feetStyles[feetIndex];

        styleImage.sprite = styleImages[CalculateStyle()];
    }

    public void LeftButton_Feet()
    {
        if (feetIndex <= 0)
        {
            feetIndex = feetShoes.Length - 1;
        }
        else
        {
            feetIndex--;
        }

        feetCurrent = feetShoes[feetIndex];
        feetStyleCurrent = feetStyles[feetIndex];

        styleImage.sprite = styleImages[CalculateStyle()];
    }

    public void Return_Button()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }

    public void Continue_Button()
    {
        MenuManager.OpenMenu(Menu.BATTLE, gameObject);
        continuePressed = true;
    }

    public int CalculateStyle()
    {
        int cuteCounter = 0;
        int casualCounter = 0;
        int edgyCounter = 0;

        // Head accessories:
        if(headStyles[headIndex] == "CUTE")
        {
            cuteCounter += 3;
        }

        if (headStyles[headIndex] == "CASUAL")
        {
            casualCounter += 3;
        }

        if (headStyles[headIndex] == "EDGY")
        {
            edgyCounter += 3;
        }

        // Torso tops:
        if (torsoStyles[torsoIndex] == "CUTE")
        {
            cuteCounter += 5;
        }

        if (torsoStyles[torsoIndex] == "CASUAL")
        {
            casualCounter += 5;
        }

        if (torsoStyles[torsoIndex] == "EDGY")
        {
            edgyCounter += 5;
        }

        // Legs bottoms:
        if (legsStyles[legsIndex] == "CUTE")
        {
            cuteCounter += 4;
        }

        if (legsStyles[legsIndex] == "CASUAL")
        {
            casualCounter += 4;
        }

        if (legsStyles[legsIndex] == "EDGY")
        {
            edgyCounter += 4;
        }

        // Feet shoes:
        if (feetStyles[feetIndex] == "CUTE")
        {
            cuteCounter += 3;
        }

        if (feetStyles[feetIndex] == "CASUAL")
        {
            casualCounter += 3;
        }

        if (feetStyles[feetIndex] == "EDGY")
        {
            edgyCounter += 3;
        }

        if (cuteCounter > casualCounter && cuteCounter > edgyCounter)
        {
            return 0;
        }
        else if (casualCounter > cuteCounter && casualCounter > edgyCounter)
        {
            return 1;
        }
        else if (edgyCounter > casualCounter && edgyCounter > cuteCounter)
        {
            return 2;
        }

        return 0;
    }
}
