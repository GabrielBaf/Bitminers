using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class MininGacha : MonoBehaviour
{
   void Start(){
          string account = PlayerPrefs.GetString("Account");
          Debug.Log(account);
   }
   // public Miner miner;

   // void GetNewMiner(){
   //  bool gotMiner = MinerInventory.instance.Add(Miner);
   //  if(gotMiner)
   //     // Debug.Log("New miner add");
   // }
}
