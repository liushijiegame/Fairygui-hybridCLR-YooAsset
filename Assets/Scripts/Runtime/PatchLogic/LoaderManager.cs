using System.Collections;
using Core;
using UnityEngine;
using UniFramework.Event;
using YooAsset;

public class LoaderManager: Singleton<LoaderManager>
{
    /// <summary>
    /// 协程启动器
    /// </summary>
    public MonoBehaviour Behaviour;

    /// <summary>
    /// 开启一个协程
    /// </summary>
    public void StartCoroutine(IEnumerator enumerator)
    {
        Behaviour.StartCoroutine(enumerator);
    }

}