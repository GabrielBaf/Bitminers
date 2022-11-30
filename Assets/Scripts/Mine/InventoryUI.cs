using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public MinerInventory inventory;
    public Miner comMine;
    public Miner rareMine;
    public Miner ultRareMine;
    public Miner legMine;
    public float luckyNumber;

    public void GatchaButton(){
        luckyNumber += Random.Range(0f,100f);

        if(luckyNumber == 0){
            inventory.AddItem(legMine,1);
        }else if(luckyNumber > 0 && luckyNumber<=9){
            inventory.AddItem(ultRareMine,1);
        }else if(luckyNumber > 9 && luckyNumber <= 20){
            inventory.AddItem(rareMine,1);
        }else{
             inventory.AddItem(comMine,1);
        }
        luckyNumber = 0;
        //var item = other.GetComponent<Item>();
    }
    private void OnApplicationQuit() {
        inventory.container.Clear();
    }

    }
    // MinerInventory inventory;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     inventory = MinerInventory.instance;
    //     inventory.onItemChangedCallback += UpdateUI;
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // void UpdateUI() {

    // }

