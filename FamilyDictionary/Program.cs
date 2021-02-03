using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           var myFamily = new Dictionary<string, Dictionary<string, string>>();
           myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Natalie" }, { "age", "26" } });
           myFamily.Add("father", new Dictionary<string, string>() { { "name", "Chris" }, { "age", "62" } });
           myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Kathy" }, { "age", "60" } });
           myFamily.Add("grandmother", new Dictionary<string, string>() { { "name", "Lillian" }, { "age", "90" } });
           foreach (var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
            }
        }
    }
}
