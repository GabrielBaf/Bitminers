using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAcc : MonoBehaviour
{
    public Text myAcc;

    // Start is called before the first frame update
    void Start()
    {
        string account = PlayerPrefs.GetString("Account");
        myAcc.text = account;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
