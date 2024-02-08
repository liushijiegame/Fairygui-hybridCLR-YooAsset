using System;
using System.Collections.Generic;

namespace Core.Pool.Ref
{
    public static class ReferencePool
    {
        private static readonly Dictionary<Type, ReferenceCollection> m_ReferenceCollections =
            new Dictionary<Type, ReferenceCollection>();

        public static int Count => m_ReferenceCollections.Count; //获取引用池的数量

        public static void ClearAll()
        {
            lock (m_ReferenceCollections)
            {
                foreach (var reference in m_ReferenceCollections.Values)
                {
                    reference.RemoveAll();
                }

                m_ReferenceCollections.Clear();
            }
        }

        public static T Acquire<T>() where T : class, IReference, new()
        {
            return GetReferenceCollection(typeof(T)).Acquire<T>();
        }

        public static void Release(IReference reference)
        {
            GetReferenceCollection(reference.GetType()).Release(reference);
        }

        public static void Add<T>(int count) where T : class, IReference, new()
        {
            GetReferenceCollection(typeof(T)).Add<T>(count);
        }

        public static void Remove<T>(int count) where T : class, IReference, new()
        {
            GetReferenceCollection(typeof(T)).Remove(count);
        }

        public static void RemoveAll<T>() where T : class, IReference, new()
        {
            GetReferenceCollection(typeof(T)).RemoveAll();
        }

        private static ReferenceCollection GetReferenceCollection(Type type)
        {
            if (type == null)
            {
                throw new Exception("Type 类型 为空!!!");
            }

            ReferenceCollection referenceCollection = null;
            lock (m_ReferenceCollections)
            {
                if (!m_ReferenceCollections.TryGetValue(type, out referenceCollection))
                {
                    referenceCollection = new ReferenceCollection(type);
                    m_ReferenceCollections.Add(type, referenceCollection);
                }
            }

            return referenceCollection;
        }

        public static int GetCurrUsingRefCount<T>() where T : class, IReference, new()
        {
            return GetReferenceCollection(typeof(T)).CurrUsingRefCount;
        }

        public static int GetAcquireRefCount<T>() where T : class, IReference, new()
        {
            return GetReferenceCollection(typeof(T)).AcquireRefCount;
        }

        public static int GetReleaseRefCount<T>() where T : class, IReference, new()
        {
            return GetReferenceCollection(typeof(T)).ReleaseRefCount;
        }

        public static int GetAddRefCount<T>() where T : class, IReference, new()
        {
            return GetReferenceCollection(typeof(T)).AddRefCount;
        }

        public static int GetRemoveRefCount<T>() where T : class, IReference, new()
        {
            return GetReferenceCollection(typeof(T)).RemoveRefCount;
        }
    }
}