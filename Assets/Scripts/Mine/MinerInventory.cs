using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "InventorySystem/Inventory")]
public class MinerInventory : ScriptableObject
{
    public List<InventorySlot> container = new List<InventorySlot>();
    public void AddItem(Miner _miner, int _amount)
    {
        bool hasMiner = false;
        for (int i = 0; i < container.Count; i++)
        {
            if(container[i].miner == _miner){
            container[i].AddAmount(_amount);
            hasMiner = true;
            break;
            }
        }
        if(!hasMiner){
            container.Add(new InventorySlot(_miner,_amount));
        }
    }
}

[System.Serializable]
public class InventorySlot{
    public Miner miner;
    public int amount;
    public InventorySlot(Miner _miner, int _amount){
        miner = _miner;
        amount = _amount;
    }
    public void AddAmount(int value){
        amount += value;
    }
}
//    public static MinerInventory instance;

// #region SingletonMenu

//    void Awake() {
//     if (instance != null){
//         Debug.Log("More them one inventory");
//         return;
//     }
//     instance = this;

//    }
// #endregion

// public List<Miner> miners = new List<Miner>();

// public int space = 20;

// public void Add (Miner miner)
// {
//     if(!miners.isDefaultMiner){
        
//         if(miners.Count >=space){
//             return false;
//         }
//         miners.Add(miner);
//     }
//     return true;
// }

// public void Remove (Miner miner){
//     miners.Remove(miner);
// }

