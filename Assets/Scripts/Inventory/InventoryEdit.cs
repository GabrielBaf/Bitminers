using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryEdit : MonoBehaviour
{
   public event Action<InventoryEdit> OnItemClicked,OnItemDroppedOn,OnItemBeginDrag,OnItemEndDrag,OnRightMouseClick;
   private bool empty = true;

public void SetData(){
    empty = false;
}
public void OnBeginDrag(){
    if(empty)
        return;
        OnItemBeginDrag?.Invoke(this);
   }
}
