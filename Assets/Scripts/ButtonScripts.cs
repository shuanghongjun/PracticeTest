using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��ť��������
/// </summary>
public class ButtonScripts : MonoBehaviour
{
    
    public void SendMessage()
    {
        MessagerCenter<string>.Instance.BroadCast(MsgID.SendMessage, "��������");
        GetComponent<Text>().text = "��������";

    }
}
