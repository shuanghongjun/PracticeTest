using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Forth : MonoBehaviour
{
    private void Awake()
    {
        MessagerCenter<string>.Instance.AddListener(MsgID.SendMessage, AddListen);
    }

    private void AddListen(string obj)
    {
        GetComponent<Text>().text = "收到警报四号撤离";
    }
}
