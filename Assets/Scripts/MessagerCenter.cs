using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// ��Ϣ����
/// �۲���ģʽ������
/// </summary>
/// <typeparam name="T"></typeparam>
public class MessagerCenter<T> :Singleton<MessagerCenter<T>>
{
    Dictionary<int, Action<T>> MegDic = new Dictionary<int, Action<T>>();
    /// <summary>
    /// �����Ϣ�¼��ļ���
    /// </summary>
    /// <param name="MegId"></param>
    /// <param name="action"></param>
    public void AddListener(int MegId, Action<T> action)
    {
        if (MegDic.ContainsKey(MegId))
        {
            MegDic[MegId] += action;
        }
        else
        {
            MegDic.Add(MegId, action);
        }
    }
    /// <summary>
    /// �Ƴ���Ϣ�¼��ļ���
    /// </summary>
    /// <param name="MegId"></param>
    /// <param name="action"></param>
    public void RemoveListener(int MegId, Action<T> action)
    {
        if (MegDic.ContainsKey(MegId))
        {
            MegDic[MegId] -= action;
        }
    }
    /// <summary>
    /// �㲥��Ϣ
    /// </summary>
    /// <param name="MegId"></param>
    /// <param name="t"></param>
    public void BroadCast(int MegId, T t)
    {
        if (MegDic.ContainsKey(MegId))
        {
            MegDic[MegId].Invoke(t);
        }
    }
}
