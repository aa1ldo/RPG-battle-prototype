using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public bool BattleOver { get; set; }
    public bool YouWin { get; set; }

    public static GameManager Instance
    {
        get
        {
            if (_instance is null)
                Debug.LogError("GameManager is NULL");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
}