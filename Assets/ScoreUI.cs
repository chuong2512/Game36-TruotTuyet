using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreTMP;
    public TextMeshProUGUI highScoreTMP;

    void OnEnable()
    {
        scoreTMP.SetText($"{PointTMP.Instance.point}");
        
        GameDataManager.Instance.playerData.SetScore(PointTMP.Instance.point);
        highScoreTMP.SetText($"{GameDataManager.Instance.playerData.score}");
    }
}