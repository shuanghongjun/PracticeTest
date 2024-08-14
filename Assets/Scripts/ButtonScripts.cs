using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 按钮发出警报
/// </summary>
public class ButtonScripts : MonoBehaviour
{
    
    public void SendMessage()
    {
        MessagerCenter<string>.Instance.BroadCast(MsgID.SendMessage, "发出警报");
        GetComponent<Text>().text = "发出警报";

    }
}
