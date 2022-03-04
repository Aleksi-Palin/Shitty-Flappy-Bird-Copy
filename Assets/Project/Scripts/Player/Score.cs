using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI ItemCountText;

    public int CurScore = 0;

    public int ItemCount = 0;

    private void Start()
    {
        if(instance != null)
        {
            return;
        }
        instance = this;
        
        ScoreText.text = "PISTEET: " + CurScore.ToString();
        ItemCountText.text = ItemCount.ToString();
    }

    private void Update()
    {
        if(ScoreText == null)
        {
            return;
        }
        ScoreText.text = "PISTEET: " + CurScore.ToString();

        if (ItemCountText == null)
        {
            return;
        }
        ItemCountText.text = ItemCount.ToString();
    }

}
