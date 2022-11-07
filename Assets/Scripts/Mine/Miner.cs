using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Miner", menuName = "Inventory/Miner")]
public class Miner : ScriptableObject {
	//bronze,iron,silver,gold,diamond
	public string[] rarityOptions = {"common","rare","ultrarare","legendary"};
	public GameObject minerSprite;
	public string rarity;
	public float startingMiningSpeed;
	private float presenteMiningSpeed;
	public float maxMiningSpeed;
	public float upgradeTimeMiningSpeed;
	private float[] mineChance;


	public float PresenteMiningSpeed{
		get 
        {    
            return presenteMiningSpeed; 
        }
        set 
        {
			if(rarity == rarityOptions[0]){

            if (upgradeTimeMiningSpeed == 0){
                presenteMiningSpeed = 24f; 
			}
			else if(upgradeTimeMiningSpeed == 1){
				presenteMiningSpeed = 23.45f;
			}
			else if(upgradeTimeMiningSpeed == 2){
				presenteMiningSpeed = 23.30f;
			}
			else if(upgradeTimeMiningSpeed == 3){
				presenteMiningSpeed = 23.15f;
			}
			else if(upgradeTimeMiningSpeed == 4){
				presenteMiningSpeed = 23f;
			}
			}else if(rarity == rarityOptions[1]){
				if (upgradeTimeMiningSpeed == 0){
                presenteMiningSpeed = 22f; 
			}
			else if(upgradeTimeMiningSpeed == 1){
				presenteMiningSpeed = 21.30f;
			}
			else if(upgradeTimeMiningSpeed == 2){
				presenteMiningSpeed = 21f;
			}
			else if(upgradeTimeMiningSpeed == 3){
				presenteMiningSpeed = 20.30f;
			}
			else if(upgradeTimeMiningSpeed == 4){
				presenteMiningSpeed = 20f;
			}
			}else if(rarity == rarityOptions[2]){
				if (upgradeTimeMiningSpeed == 0){
                presenteMiningSpeed = 20f; 
			}
			else if(upgradeTimeMiningSpeed == 1){
				presenteMiningSpeed = 19.15f;
			}
			else if(upgradeTimeMiningSpeed == 2){
				presenteMiningSpeed = 18.30f;
			}
			else if(upgradeTimeMiningSpeed == 3){
				presenteMiningSpeed = 17.45f;
			}
			else if(upgradeTimeMiningSpeed == 4){
				presenteMiningSpeed = 17f;
			}
			}else if(rarity == rarityOptions[3]){
				if (upgradeTimeMiningSpeed == 0){
                presenteMiningSpeed = 18f; 
			}
			else if(upgradeTimeMiningSpeed == 1){
				presenteMiningSpeed = 17f;
			}
			else if(upgradeTimeMiningSpeed == 2){
				presenteMiningSpeed = 16f;
			}
			else if(upgradeTimeMiningSpeed == 3){
				presenteMiningSpeed = 15f;
			}
			else if(upgradeTimeMiningSpeed == 4){
				presenteMiningSpeed = 14f;
			}
			}else{}
        }
    }
	public float[] MineChance{
		get 
        {    
            return mineChance; 
        }
        set {
			if(rarity == rarityOptions[0]){
				mineChance[0] = 70f;
				mineChance[1] = 15f;
				mineChance[2] = 10f;
				mineChance[3] = 4.5f;
				mineChance[4] = 0.5f;
			}else if(rarity == rarityOptions[1]){
				mineChance[0] = 65f;
				mineChance[1] = 20f;
				mineChance[2] = 10f;
				mineChance[3] = 4.5f;
				mineChance[4] = 0.5f;
				//mineChance = {65f,20f,10f,4.5f,0.5f};
			}else if(rarity == rarityOptions[2]){
				mineChance[0] = 55f;
				mineChance[1] = 20f;
				mineChance[2] = 15f;
				mineChance[3] = 9.5f;
				mineChance[4] = 0.5f;
				//mineChance = {55f,20f,15f,9.5f,0.5f};
			}else if(rarity == rarityOptions[3]){
				mineChance[0] = 45f;
				mineChance[1] = 15f;
				mineChance[2] = 20f;
				mineChance[3] = 15f;
				mineChance[4] = 5f;
				//mineChance = {45f,15f,20f,15f,5f};
			}else{}
		}
	} 
	}
	




