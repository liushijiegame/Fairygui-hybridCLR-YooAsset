using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Core.Singleton;
using MK;

namespace MK
{
    public class AttributeService: Singleton<AttributeService>
    {
        
        private readonly Dictionary<string, Type> allTypes = new();

        private readonly UnOrderMultiMapSet<Type, Type> types = new();


        public void Add(Dictionary<string, Type> addTypes)
        {
            this.allTypes.Clear();
            this.types.Clear();
            
            foreach ((string fullName, Type type) in addTypes)
            {
                this.allTypes[fullName] = type;
                
                if (type.IsAbstract)
                {
                    continue;
                }
                
                // 记录所有的有BaseAttribute标记的的类型
                object[] objects = type.GetCustomAttributes(typeof(FUIBaseAttribute), true);

                foreach (object o in objects)
                {
                    this.types.Add(o.GetType(), type);
                }
            }
        }
        
        public HashSet<Type> GetTypes(Type systemAttributeType)
        {
            if (!this.types.ContainsKey(systemAttributeType))
            {
                return new HashSet<Type>();
            }

            return this.types[systemAttributeType];
        }
    }
}
