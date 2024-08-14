using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class First : MonoBehaviour
{
    private void Awake()
    {
        MessagerCenter<string>.Instance.AddListener(MsgID.SendMessage, AddListen);
    }

    private void AddListen(string obj)
    {
        GetComponent<Text>().text = "收到警报一号撤离";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


}
