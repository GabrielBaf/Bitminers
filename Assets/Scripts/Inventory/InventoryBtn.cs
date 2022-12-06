using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;

public class InventoryBtn : MonoBehaviour
{
    //Preview miner stats
    public Miner minerStats;
    private Text mineSpdPre,bronzChPre,ironChPre,silverChPre,goldChPre,diamondChPre;
    private Button miner1Btn,miner2Btn;
    private GameObject miner1GO,miner2GO;
    

    //Equiped miner stats 
    public static Miner minerEquiped1,minerEquiped2;
    private Text mineSpd,minedTime,bronzCh,ironCh,silverCh,goldCh,diamondCh;
    private Text mineSpd2,minedTime2,bronzCh2,ironCh2,silverCh2,goldCh2,diamondCh2;
    
    private void Start() {
          #region 
          //Declaring the Game Objects previws
          mineSpdPre = GameObject.Find("miningSpeedTxtPre").GetComponent<Text>();
          bronzChPre = GameObject.Find("ChanceBronzPre").GetComponent<Text>();
          ironChPre = GameObject.Find("ChanceIronPre").GetComponent<Text>();
          silverChPre = GameObject.Find("ChanceSilverPre").GetComponent<Text>();
          goldChPre = GameObject.Find("ChanceGoldPre").GetComponent<Text>();
          diamondChPre = GameObject.Find("ChanceDiamonPre").GetComponent<Text>();
          miner1Btn = GameObject.Find("GetMinerBtn1").GetComponent<Button>();
          miner2Btn = GameObject.Find("GetMinerBtn2").GetComponent<Button>();
          miner1GO = GameObject.Find("GetMinerBtn1");
          miner2GO = GameObject.Find("GetMinerBtn2");
          //Equiped miner stats 1
          mineSpd = GameObject.Find("miningSpeedTxt").GetComponent<Text>();
          minedTime = GameObject.Find("TimeLeft").GetComponent<Text>();
          bronzCh = GameObject.Find("ChanceBronz").GetComponent<Text>();
          ironCh = GameObject.Find("ChanceIron").GetComponent<Text>();
          silverCh = GameObject.Find("ChanceSilver").GetComponent<Text>();
          goldCh = GameObject.Find("ChanceGold").GetComponent<Text>();
          diamondCh = GameObject.Find("ChanceDiamon").GetComponent<Text>();
          //Equiped miner stats 2
          mineSpd2 = GameObject.Find("miningSpeedTxt2").GetComponent<Text>();
          minedTime2 = GameObject.Find("TimeLeft2").GetComponent<Text>();
          bronzCh2 = GameObject.Find("ChanceBronz2").GetComponent<Text>();
          ironCh2 = GameObject.Find("ChanceIron2").GetComponent<Text>();
          silverCh2 = GameObject.Find("ChanceSilver2").GetComponent<Text>();
          goldCh2 = GameObject.Find("ChanceGold2").GetComponent<Text>();
          diamondCh2 = GameObject.Find("ChanceDiamon2").GetComponent<Text>();
          #endregion
     //     string account = PlayerPrefs.GetString("Account");
     //      StartCoroutine(LoginCheck(account));
         string userInfor = PlayerPrefs.GetString("PlayerInfo");

         Data userinf = JsonUtility.FromJson<Data>(userInfor);
         Debug.Log(userinf.inventory.iron_ore.ToString());
         //userinf = JsonUtility.FromJson<Data>(userInfor);
        // Debug.Log(userInfor[39]);
          //Debug.Log(userinf.inventory.iron_ore.ToString());
         //Debug.Log(userinf.inventory.iron_ore.ToString());

         miner1GO.SetActive(false);
         miner2GO.SetActive(false);
    }
//    #region 
//      [Serializable]
//       public class Data
//     {
//         public Inventory inventory;
//         public List<MinerStat> minerStats; 
//     }
//      [Serializable]
//     public class Inventory
//     {
//         public int id; 
//         public int user_id;
//         public int iron_ore; 
//         public int bronze_ore; 
//         public int silver_ore;
//         public int gold_ore; 
//         public int diamond_ore; 
//         public DateTime created_at; 
//         public DateTime updated_at; 
//     }
//      [Serializable]
//     public class MinerStat
//     {
//         public int id; 
//         public int user_id; 
//         public string rarity; 
//         public int boost_level; 
//         public string mining_start; 
//         public string mining_end; 
//         public DateTime created_at; 
//         public DateTime updated_at; 
//     }
//      [Serializable]
//     public class Root
//     {
//         public Data data; 
//     }

//    #endregion
 
//    IEnumerator LoginCheck(string pAccount)
//     {
//         WWWForm form = new WWWForm();
//         form.AddField("wallet_address", pAccount);

//         using (UnityWebRequest www = UnityWebRequest.Post("http://127.0.0.1:8000/api/miner-inventory", form))
//         {
//             yield return www.SendWebRequest();

//             if (www.result != UnityWebRequest.Result.Success)
//             {
//                 Debug.Log(www.error);
//             }
//             else
//             {
//                 Debug.Log(www.downloadHandler.text);
//                 string data = www.downloadHandler.text;
//                 Debug.Log(data);
//             }
//         }
//     }

    public void SendMinerPreview(){;
       mineSpdPre.text = "Mining Speed: " + minerStats.startingMiningSpeed;
       bronzChPre.text = "Bronze chance: " + minerStats.mineChance[0] + "%";
       ironChPre.text = "Iron chance: " + minerStats.mineChance[1]+ "%";
       silverChPre.text = "Silver chance: " + minerStats.mineChance[2]+ "%";
       goldChPre.text = "Gold chance: " + minerStats.mineChance[3]+ "%";
       diamondChPre.text = "Diamond chance: " + minerStats.mineChance[4]+ "%";
       miner1Btn.onClick.AddListener(EquipSlot1);
       miner2Btn.onClick.AddListener(EquipSlot2);
       miner1GO.SetActive(true);
       miner2GO.SetActive(true);

    }

    public void EquipSlot1(){
         mineSpd.text = "Mining Speed: " + minerStats.startingMiningSpeed;
         bronzCh.text = "Bronze chance: " + minerStats.mineChance[0] + "%";
         ironCh.text = "Iron chance: " + minerStats.mineChance[1]+ "%";
         silverCh.text = "Silver chance: " + minerStats.mineChance[2]+ "%";
         goldCh.text = "Gold chance: " + minerStats.mineChance[3]+ "%";
         diamondCh.text = "Diamond chance: " + minerStats.mineChance[4]+ "%";
         minerEquiped1 = minerStats;
    }
    public void EquipSlot2(){
         mineSpd2.text = "Mining Speed: " + minerStats.startingMiningSpeed;
         bronzCh2.text = "Bronze chance: " + minerStats.mineChance[0]+ "%";
         ironCh2.text = "Iron chance: " + minerStats.mineChance[1]+ "%";
         silverCh2.text = "Silver chance: " + minerStats.mineChance[2]+ "%";
         goldCh2.text = "Gold chance: " + minerStats.mineChance[3]+ "%";
         diamondCh2.text = "Diamond chance: " + minerStats.mineChance[4]+ "%";
         minerEquiped2 = minerStats;
    }
}
