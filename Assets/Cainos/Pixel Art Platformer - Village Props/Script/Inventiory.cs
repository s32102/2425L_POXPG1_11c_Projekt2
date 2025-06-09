using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventiory : MonoBehaviour
{
    public int collectibleCount = 0;

    public TextMeshProUGUI collectibleText;

    private void Start()
    {
        collectibleText.text = "zebrano: 0";
    }

    public void AddCollectible()
    {
        collectibleCount++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (collectibleText != null)
        {
            collectibleText.text = "zebrano: " + collectibleCount.ToString();
        }
    }
    //TODO counter for collectibles

}