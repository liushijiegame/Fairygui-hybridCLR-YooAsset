namespace Core
{
    public class Singleton<T> where T:class,new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                return _instance ??= new T(); 
            }
           
        }
    }
}

