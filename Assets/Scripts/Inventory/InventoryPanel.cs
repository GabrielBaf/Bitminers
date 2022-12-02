using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class InventoryPanel : MonoBehaviour
{
   public MinerInventory inventory;

   public int x_space_items,x_start;
   public int numb_colum;
   public int y_space_items,y_start;
   
   Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

   
   



   public void CreateDisplay()
   {
    for(int i = 0; i < inventory.container.Count;i++){
        var obj = Instantiate(inventory.container[i].miner.minerUIPref, Vector3.zero, Quaternion.identity, transform);
        obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
        // obj.OnItemClicked += HandleItemSelection;
        // obj.OnItemBeginDrag += HandleBeginDrag;
        // obj.OnItemDroppedOn += HandleSwap;
        // obj.OnItemEndDrag += HandleEndDrag;
        // obj.OnRightMouseClick += HandleShowItemActions;
        // empty = false;
        //obj.GetComponentInChildren<Image>().GetComponentInChildren<Image>().sprite = inventory.container[i].miner.sprite;

    }
   }
//    private void HandleItemSelection(){
//     throw new NotImplementedException();
//    }
//      private void HandleBeginDrag(){
//     throw new NotImplementedException();
//    }
//        private void HandleSwap(){
//     throw new NotImplementedException();
//    }
//        private void HandleEndDrag(){
//     throw new NotImplementedException();
//    }
//        private void HandleShowItemActions(){
//     throw new NotImplementedException();
//    }

    public Vector3 GetPosition(int i){
        return new Vector3(x_start + (x_space_items *(i % numb_colum)),y_start + (-y_space_items *(i/numb_colum)),0f);
    }

    public void UpdateDisplay(){
        
    for(int i = 0; i < inventory.container.Count;i++){
        if(itemsDisplayed.ContainsKey(inventory.container[i])){
            itemsDisplayed[inventory.container[i]].GetComponentInChildren<Image>().GetComponentInChildren<Image>().sprite = inventory.container[i].miner.sprite;
        }else{
            var obj = Instantiate(inventory.container[i].miner.minerUIPref, Vector3.zero, Quaternion.identity, transform );
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            //empty = false;
           //obj.GetComponentInChildren<Image>().GetComponentInChildren<Image>().sprite = inventory.container[i].miner.sprite; 
        itemsDisplayed.Add(inventory.container[i], obj);
        }
    }
    }

}
