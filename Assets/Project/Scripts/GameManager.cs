using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool IsGameActive;

    public GameObject GameOverMenu;

    public int PlayerHp = 100;
    // Start is called before the first frame update
    void Awake()
    {
        IsGameActive = true;
        GameOverMenu.SetActive(false);
    }

    private void Update()
    {
        if (!IsGameActive)
        {
            GameOverMenu.SetActive(true);
        }
    }

}
