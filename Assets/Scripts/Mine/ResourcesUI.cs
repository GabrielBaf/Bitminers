using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesUI : MonoBehaviour
{
  //Inventory menu 
   public static bool GameIsPaused = false;
   public GameObject pauseMenuUI;
   public GameObject pauseButton;

   //Resources values
   public Text minedoreBronze;
   public Text minedoreIron;
   public Text minedoreDiamond;
    public int mineredBronz;
    public int mineredIron;
    public int mineredDiamond;

    //Equiped miners
    public Miner Miner1,Miner2;
    public Text mineSpd,minedTime,bronzCh,ironCh,silverCh,goldCh,diamondCh;
    public Text mineSpd2,minedTime2,bronzCh2,ironCh2,silverCh2,goldCh2,diamondCh2;
    public string rar;
//     public float[] minerChan1;
//     public float[] minerChan2;

    // Update is called once per frame
    void Update()
    {

         minedoreBronze.text = "Bronze: " + mineredBronz; 
         minedoreIron.text = "Iron: " + mineredIron; 
         minedoreDiamond.text = "Diamond: " + mineredDiamond;

          //Display miner stats
          //   minerChan1 = Miner1.MineChance;
          //    minerChan2 = Miner2.MineChance;
          rar = Miner1.rarity;

         mineSpd.text = "Mining Speed: " + Miner1.startingMiningSpeed;
         bronzCh.text = "Bronze chance: " + Miner1.mineChance[0] + "%";
         ironCh.text = "Iron chance: " + Miner1.mineChance[1]+ "%";
         silverCh.text = "Silver chance: " + Miner1.mineChance[2]+ "%";
         goldCh.text = "Gold chance: " + Miner1.mineChance[3]+ "%";
         diamondCh.text = "Diamond chance: " + Miner1.mineChance[4]+ "%";

         mineSpd2.text = "Mining Speed: " + Miner2.startingMiningSpeed;
         bronzCh2.text = "Bronze chance: " + Miner2.mineChance[0]+ "%";
         ironCh2.text = "Iron chance: " + Miner2.mineChance[1]+ "%";
         silverCh2.text = "Silver chance: " + Miner2.mineChance[2]+ "%";
         goldCh2.text = "Gold chance: " + Miner2.mineChance[3]+ "%";
         diamondCh2.text = "Diamond chance: " + Miner2.mineChance[4]+ "%";

         
         if(Input.GetKeyDown(KeyCode.Escape)){
          if(GameIsPaused){
               Resume();
          }else{
               Pause();
          }
         }
    }

     public void Resume() {
     pauseMenuUI.SetActive(false);
     pauseButton.SetActive(true);
     GameIsPaused = false;
    }
     public void Pause() {
     pauseMenuUI.SetActive(true);
      pauseButton.SetActive(false);
     GameIsPaused = true;
    }
}
