using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using TMPro;
using UnityEngine;

public class PointTMP : Singleton<PointTMP>
{
    public TextMeshProUGUI diamondTmp;

    public int point = 0;

    void OnValidated()
    {
        diamondTmp = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        point = 0;
        
        diamondTmp.text = $"{point} KM";
    }

    public void Add()
    {
        point++;
        
        diamondTmp.text = $"{point} KM";
    }
}
