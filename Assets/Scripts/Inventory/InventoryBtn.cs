using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class InventoryBtn : MonoBehaviour
{
    //Preview miner stats
    public Miner minerStats;
    public Text mineSpdPre,bronzChPre,ironChPre,silverChPre,goldChPre,diamondChPre;
    public Button miner1Btn,miner2Btn;
    

    //Equiped miner stats 
     public Text mineSpd,minedTime,bronzCh,ironCh,silverCh,goldCh,diamondCh;
    public Text mineSpd2,minedTime2,bronzCh2,ironCh2,silverCh2,goldCh2,diamondCh2;
    
    private void Start() {
        Debug.Log(DateTime.Now);
    }
    private void Update() {
        miner1Btn.onClick.AddListener(EquipSlot1);
        miner2Btn.onClick.AddListener(EquipSlot2);
    }

    public void SendMinerPreview(){;
       mineSpdPre.text = "Mining Speed: " + minerStats.startingMiningSpeed;
       bronzChPre.text = "Bronze chance: " + minerStats.mineChance[0] + "%";
       ironChPre.text = "Iron chance: " + minerStats.mineChance[1]+ "%";
       silverChPre.text = "Silver chance: " + minerStats.mineChance[2]+ "%";
       goldChPre.text = "Gold chance: " + minerStats.mineChance[3]+ "%";
       diamondChPre.text = "Diamond chance: " + minerStats.mineChance[4]+ "%";
    }

    public void EquipSlot1(){
         mineSpd.text = "Mining Speed: " + minerStats.startingMiningSpeed;
         bronzCh.text = "Bronze chance: " + minerStats.mineChance[0] + "%";
         ironCh.text = "Iron chance: " + minerStats.mineChance[1]+ "%";
         silverCh.text = "Silver chance: " + minerStats.mineChance[2]+ "%";
         goldCh.text = "Gold chance: " + minerStats.mineChance[3]+ "%";
         diamondCh.text = "Diamond chance: " + minerStats.mineChance[4]+ "%";
    }
    public void EquipSlot2(){
         mineSpd2.text = "Mining Speed: " + minerStats.startingMiningSpeed;
         bronzCh2.text = "Bronze chance: " + minerStats.mineChance[0]+ "%";
         ironCh2.text = "Iron chance: " + minerStats.mineChance[1]+ "%";
         silverCh2.text = "Silver chance: " + minerStats.mineChance[2]+ "%";
         goldCh2.text = "Gold chance: " + minerStats.mineChance[3]+ "%";
         diamondCh2.text = "Diamond chance: " + minerStats.mineChance[4]+ "%";

    }
}
