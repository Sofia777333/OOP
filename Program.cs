using System;

namespace Properties
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.Age = 56;

            Console.WriteLine(client.Name);
        }
    }
}