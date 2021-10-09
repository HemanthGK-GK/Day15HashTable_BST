
using System;

namespace UC2GetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMap<string, string> hash = new MyMap<string, string>(18);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");

            string hash0 = hash.Get("0");
            Console.WriteLine("0th index value: " + hash0);
            string hash3 = hash.Get("3");
            Console.WriteLine("3rd index value: " + hash3);
            string hash7 = hash.Get("7");
            Console.WriteLine("7th index value: " + hash7);
            string hash16 = hash.Get("16");
            Console.WriteLine("16th index value: " + hash16);
        }
    }
}
