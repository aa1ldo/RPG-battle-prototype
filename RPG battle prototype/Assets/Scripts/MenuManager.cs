using UnityEngine;

public static class MenuManager
{
    public static bool IsInitialised { get; private set; }
    public static GameObject mainMenu, settingsMenu, guideMenu, outfitSelect, battle, results;
    public static void Init()
    {
        GameObject canvas = GameObject.Find("Canvas");
        mainMenu = canvas.transform.Find("MainMenu").gameObject;
        settingsMenu = canvas.transform.Find("SettingsMenu").gameObject;
        guideMenu = canvas.transform.Find("GuideMenu").gameObject;
        outfitSelect = canvas.transform.Find("OutfitSelect").gameObject;
        battle = canvas.transform.Find("Battle").gameObject;
        results = canvas.transform.Find("Results").gameObject;

        IsInitialised = true;
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {
        if (!IsInitialised)
        {
            Init();
        }

        switch (menu)
        {
            case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                break;
            case Menu.SETTINGS_MENU:
                settingsMenu.SetActive(true);
                break;
            case Menu.GUIDE_MENU:
                guideMenu.SetActive(true);
                break;
            case Menu.OUTFIT_SELECT:
                outfitSelect.SetActive(true);
                break;
            case Menu.BATTLE:
                battle.SetActive(true);
                break;
            case Menu.RESULTS:
                results.SetActive(true);
                break;
        }

        callingMenu.SetActive(false);
    }
}
