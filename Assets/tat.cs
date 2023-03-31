using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tat : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.name == "Player")
      {
         GameDataManager.Instance.playerData.AddDiamond(1);
      }
   }
}
