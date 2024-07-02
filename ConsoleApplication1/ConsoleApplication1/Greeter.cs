using System;

namespace ConsoleApplication1
{
    public class Greeter
    {
        private string _name;
        public Greeter(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return _name;
        }
        
        public void SetName(string name)
        {
            _name = name;
        }

        public void Greet()
        {
            Console.WriteLine("Hello " + _name);
        }
    }
}