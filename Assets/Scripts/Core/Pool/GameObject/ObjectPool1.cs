using System.Collections;
using System.Collections.Generic;
using Core.Singleton;
using UnityEngine;

namespace Core.Pool
{
    /// <summary>
    /// 对象池(重复调用/使用的游戏物体)  子弹，技能，导弹，敌人
    /// </summary>
    public class ObjectPool1 : SingletonMono<ObjectPool1>
    {
        //字段  池 技能预设物(因为一个技能可能有多个预制件) 技能的复用性
        private Dictionary<string, List<GameObject>> cache = new Dictionary<string, List<GameObject>>();
        int i = 0; //标记 0


        /// <summary>
        /// 创建显示对象
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="key">对象名称</param>
        /// <param name="go">对象的预制件</param>
        /// <param name="position">对象的新位置</param>
        /// <param name="quaternion">对象的角度</param>
        public GameObject CreateObject(string key, GameObject go, Vector3 position, Quaternion quaternion)
        {
            GameObject tempgo =
                cache.ContainsKey(key) ? cache[key].Find(p => !p.activeSelf) : null; //返回池中未激活的对象，所有都被激活就返回空，赋值给临时对象
            if (tempgo != null) //如果临时对象不为空
            {
                tempgo.transform.position = position; //设置位置
                tempgo.transform.rotation = quaternion; //旋转信息
            }
            else //否则，就是空了。（也就是没能从池子里取出对象）
            {
                tempgo = Instantiate(go, position, quaternion); //那就根据传入的预设物，生成一个新物体
                print("实例化物体数量：" + i++);
                if (!cache.ContainsKey(key)) //池中没有键
                {
                    cache.Add(key, new List<GameObject>()); //新建一个 列表
                }

                cache[key].Add(tempgo); //给字典中的列表加入/add 临时物体，如果有键就直接添加了
            }

            tempgo.SetActive(true); //并启用临时物体
            return tempgo; //返回
        }


        /// <summary>
        /// 直接回收
        /// </summary>
        /// <param name="go">Go.</param>
        public void CollectObject(GameObject go)
        {
            go.SetActive(false);
        }


        /// <summary>
        /// 延迟回收
        /// </summary>
        /// <param name="go">Go.</param>
        /// <param name="delay">Delay.</param>
        public void CollectObject(GameObject go, float delay)
        {
            StartCoroutine(Collect(go, delay));
        }


        private IEnumerator Collect(GameObject go, float delay)
        {
            yield return new WaitForSeconds(delay);
            CollectObject(go);
        }


        /// <summary>
        /// 释放资源
        /// </summary>
        /// <returns>The clear.</returns>
        /// <param name="key">Key.</param>
        public void Clear(string key)
        {
            if (cache.ContainsKey(key))
            {
                //Destroy当中所有的对象
                for (int i = 0; i < cache[key].Count; i++)
                {
                    Destroy(cache[key][i]);
                }

                //清除键当中的所有值
                //cache[key].Clear();
                //清除这个键（键值一起清除）
                cache.Remove(key);
            }
        }


        /// <summary>
        /// 释放所有对象池
        /// </summary>
        public void ClearAll()
        {
            var list = new List<string>(cache.Keys);
            for (int i = 0; i < list.Count; i++)
            {
                Clear(list[i]);
            }
        }
    }
}