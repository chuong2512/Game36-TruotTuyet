using System;
using System.Collections;
using System.Collections.Generic;
using TruotTuyet;
using UnityEngine;
using Random = UnityEngine.Random;

public class MountainManager : Singleton<MountainManager>
{
    public Mountain[] Mountain;
    public float speed = 4;

    private readonly float dis = 10.25f;
    
    public void AddMountain()
    {
        var mou = GetRandom();

        var lastPos = transform.GetChild(transform.childCount - 1);

        var child = Instantiate(mou.gameObject, transform);

        child.transform.localPosition = lastPos.localPosition + Vector3.right * dis;
    }

    public void Move()
    {
    }

    public Mountain GetRandom()
    {
        return Mountain[Random.Range(0, Mountain.Length)];
    }

    private void Update()
    {
        if (GameUI.Instance.currentState == State.Running)
        {
            transform.position = (Vector2)transform.position + Time.deltaTime * Vector2.left * speed;
        }
    }
}