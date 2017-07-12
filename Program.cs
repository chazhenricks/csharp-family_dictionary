﻿using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("mother", new Dictionary<string, string>(){ 
                {"name", "Melissa"},
                {"age", "58"}
            });

            myFamily.Add("father", new Dictionary<string, string>(){ 
                {"name", "Peter"},
                {"age", "60"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "JT"},
                {"age", "29"}
            });

            myFamily.Add("wife", new Dictionary<string, string>(){ 
                {"name", "Sarah"},
                {"age", "25"}
            });
            
            foreach(KeyValuePair<string, Dictionary<string, string>> member in myFamily){
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old");

                }
        }
    }
}
