using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 消息中心
/// 观察者模式的运用
/// </summary>
/// <typeparam name="T"></typeparam>
public class MessagerCenter<T> :Singleton<MessagerCenter<T>>
{
    Dictionary<int, Action<T>> MegDic = new Dictionary<int, Action<T>>();
    /// <summary>
    /// 添加消息事件的监听
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
    /// 移除消息事件的监听
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
    /// 广播消息
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
