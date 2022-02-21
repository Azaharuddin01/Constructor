using System;
namespace Constructor
{
    class MyApp
    {
        public string name;
        public int var;
        public MyApp(string name)
        {
            this.name = name;

        }
        public void get(int var)
        {
            this.var = var;
            Console.WriteLine(this.name);
            Console.WriteLine(this.var);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyApp obj = new MyApp("Azahar Uddin");
            obj.get(5);

        }
    }
}
