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
        GetComponent<Text>().text = "�յ�����һ�ų���";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


}
