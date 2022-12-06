using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Numerics;
using UnityEngine.UI;

public class UIDataFromDB : MonoBehaviour
{
    public Text walletUI;

    public Text totalBronze,totalIron,totalSilver,totalGold,totalDiamond;
    public GameObject mineComPrefab,mineRarePrefab,mineUltRarePrefab,mineLegPrefab;
    public BigInteger valueToBuyMiner = 25;
     Data userinf = new Data();

    // Start is called before the first frame update
    void Start()
    {
         string userInfor = PlayerPrefs.GetString("PlayerInfo");
         string walletValue = PlayerPrefs.GetString("Account");
         walletUI.text = walletValue;

         userinf = JsonUtility.FromJson<Data>(userInfor);
         Debug.Log(userinf.inventory.iron_ore.ToString());

       totalBronze.text = "Bronze: " + userinf.inventory.bronze_ore.ToString();
       totalIron.text = "Iron: " + userinf.inventory.iron_ore.ToString();
       totalSilver.text = "Silver: " + userinf.inventory.silver_ore.ToString();
       totalGold.text = "Gold: " + userinf.inventory.gold_ore.ToString();
       totalDiamond.text = "Diamond: " + userinf.inventory.diamond_ore.ToString();

      // List<MinerStat> minerInv = new List<MinerStat>(userinf.minerStats);
       Debug.Log(userinf.minerStats.Count.ToString());
       foreach (MinerStat miner in userinf.minerStats)
       {
        Debug.Log(miner.rarity);
         if(miner.rarity == "common"){
            var newObj = GameObject.Instantiate(mineComPrefab);
            newObj.transform.parent = GameObject.Find("Content").transform;
        }else if(miner.rarity == "rare"){
            var newObj = GameObject.Instantiate(mineRarePrefab);
            newObj.transform.parent = GameObject.Find("Content").transform;
        }else if(miner.rarity == "ultra_rare"){
            var newObj = GameObject.Instantiate(mineUltRarePrefab);
            newObj.transform.parent = GameObject.Find("Content").transform;
        }else if(miner.rarity == "legendary"){
            var newObj = GameObject.Instantiate(mineLegPrefab);
            newObj.transform.parent = GameObject.Find("Content").transform;
        }

       }
         //Debug.Log(userinf.inventory.user_id);
      // GetMiner(userinf.inventory.user_id);
      
    }

    public void GetNewMiner(){
        if(ERC20BalanceOfExample.walletBalance.CompareTo(valueToBuyMiner)){
        int userId = userinf.inventory.user_id;
        StartCoroutine(GetMiner(userId));
        string miner = PlayerPrefs.GetString("NewMiner");
        Debug.Log(miner);
        NewMiner newMine = JsonUtility.FromJson<NewMiner>(miner);
        if(newMine.rarity == "common"){
            var newObj = GameObject.Instantiate(mineComPrefab);
            newObj.transform.parent = GameObject.Find("Content").transform;
        }else if(newMine.rarity == "rare"){
            var newObj = GameObject.Instantiate(mineRarePrefab);
            newObj.transform.parent = GameObject.Find("Content").transform;
        }else if(newMine.rarity == "ultra_rare"){
            var newObj = GameObject.Instantiate(mineUltRarePrefab);
            newObj.transform.parent = GameObject.Find("Content").transform;
        }else if(newMine.rarity == "legendary"){
            var newObj = GameObject.Instantiate(mineLegPrefab);
            newObj.transform.parent = GameObject.Find("Content").transform;
        }
        }
    }
    public IEnumerator GetMiner(int pdId)
    {
        WWWForm form = new WWWForm();
        form.AddField("user_id",pdId);

        using (UnityWebRequest www = UnityWebRequest.Post("http://127.0.0.1:8000/api/new-miner", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                Debug.Log("n foi");
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string data = www.downloadHandler.text;
                PlayerPrefs.SetString("NewMiner", data);
                Debug.Log(data);
            }
        }
    }
}
 #region 
     [Serializable]
      public class Data
    {
        public Inventory inventory;
        public List<MinerStat> minerStats; 
    }
     [Serializable]
    public class Inventory
    {
        public int id; 
        public int user_id;
        public int iron_ore; 
        public int bronze_ore; 
        public int silver_ore;
        public int gold_ore; 
        public int diamond_ore; 
        public DateTime created_at; 
        public DateTime updated_at; 
    }
     [Serializable]
    public class MinerStat
    {
        public int id; 
        public int user_id; 
        public string rarity; 
        public int boost_level; 
        public string mining_start; 
        public string mining_end; 
        public DateTime created_at; 
        public DateTime updated_at; 
    }
     [Serializable]
    public class Root
    {
        public Data data; 
    }
    [Serializable]
     public class NewMiner
    {
        public string user_id;
        public string rarity;
        public DateTime updated_at;
        public DateTime created_at;
        public int id;
    }



   #endregion
 
