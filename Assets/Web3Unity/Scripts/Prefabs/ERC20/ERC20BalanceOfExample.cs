using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ERC20BalanceOfExample : MonoBehaviour
{
    public Text balance;
    public static BigInteger walletBalance;
    async void Start()
    {
        //string wallet = PlayerPrefs.GetString("Wallet");
        string chain = "ethereum";
        string network = "Goerli";
        string contract = "0x1c4ca12d35fA20288261BeD7FeaE4430E4Ec86e1";
        string account = PlayerPrefs.GetString("Account");
        //string account = "0x12155DDd1d86C8345d1E75C3f2e2CeD6c1D8f725";

        BigInteger balanceOf = await ERC20.BalanceOf(chain, network, contract, account); 
        balance.text = balanceOf.ToString().Substring(0,1);
        walletBalance = balanceOf;
    }
}
