using System;
using System.Collections.Generic;

namespace Core.Pool.Ref
{
    public class ReferenceCollection
    {
         private readonly Queue<IReference> m_References = new Queue<IReference>();
        private Type m_ReferenceType;
        private int m_CurrUsingRefCount;//当前引用的数量
        private int m_AcquireRefCount;//请求引用的总数量
        private int m_ReleaseRefCount;//释放引用的总数量
        private int m_AddRefCount;//添加引用的总数量
        private int m_RemoveRefCount;//移除引用的总数量

        public int CurrUsingRefCount => m_CurrUsingRefCount;
        public int AcquireRefCount => m_AcquireRefCount;
        public int ReleaseRefCount => m_ReleaseRefCount;
        public int AddRefCount => m_AddRefCount;
        public int RemoveRefCount => m_RemoveRefCount;


        public ReferenceCollection(Type refType)
        {
            m_ReferenceType = refType;
            m_CurrUsingRefCount = 0;
            m_AcquireRefCount = 0;
            m_ReleaseRefCount = 0;
            m_AddRefCount = 0;
            m_RemoveRefCount = 0;
        }

        public T Acquire<T>() where T : class, IReference, new()
        {
            if (typeof(T) != m_ReferenceType)
            {
                throw new Exception("类型不相同无法请求!!!");
            }
            m_CurrUsingRefCount++;
            m_AcquireRefCount++;
            lock (m_References)
            {
                if (m_References.Count > 0)
                {
                    return (T)m_References.Dequeue();
                }
            }
            m_AddRefCount++;
            return new T();
        }

        public void Release(IReference reference)
        {
            reference.Clear();
            lock (m_References)
            {
                if (m_References.Contains(reference))
                {
                    throw new Exception("引用已经被释放，请勿重新释放!!!");
                }

                m_References.Enqueue(reference);
            }

            m_CurrUsingRefCount--;
            m_ReleaseRefCount++;
        }

        public void Add<T>(int count) where T : class, IReference, new()
        {
            if (typeof(T) != m_ReferenceType)
            {
                throw new Exception("类型不相同无法添加!!!");
            }
            lock (m_References)
            {
                m_AddRefCount += count;
                while (count-- > 0)
                {
                    m_References.Enqueue(new T());
                }
            }
        }

        public void Remove(int count)
        {
            lock (m_References)
            {
                if(count > m_References.Count)
                {
                    count = m_References.Count;
                }
                m_RemoveRefCount += count;
                while (count-- > 0)
                {
                    m_References.Dequeue();
                }
            }
        }

        public void RemoveAll()
        {
            lock (m_References)
            {
                m_RemoveRefCount += m_References.Count;
                m_References.Clear();
            }
        }
    }
}