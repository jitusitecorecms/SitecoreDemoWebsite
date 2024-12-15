using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    public class Singleton
    {
        private static Singleton _instance;

        // Private constructor prevents instantiation from other classes
        private Singleton() { }

        // Public method to provide a global access point
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void SayHIFromSingleton()
        {
            Console.WriteLine("Hi from Singleton");
        }
    }

}
