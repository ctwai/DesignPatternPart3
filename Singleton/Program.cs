using System;

namespace Singleton
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Create a class with a single instance - like configManager/Log class
            // Issue - we are creating two instance of ConfigManager here
            ConfigManager manager = new ConfigManager();
            manager.Set("name", "Dave");

            ConfigManager other = new ConfigManager();
            Console.WriteLine(other.Get("name"));

            Console.ReadLine();

            // Todo
            // We need to
            // 1. set the constructor to private so outside class cannot instantiate
            // the configmanager object
            // 2. Create a private static object inside the config manager so it can craete the
            // object inside the ConfigManager Class (Not from the outside class)




        }
    }
}
