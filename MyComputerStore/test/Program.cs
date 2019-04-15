using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic kek = new System.Dynamic.ExpandoObject();

            kek.Name = "Andrew";

            kek.Age = 16;

            List<dynamic> ts = new List<dynamic>();

            ts.Add(kek);
            ts.Add(kek);
            ts.Add(kek);
            ts.Add(kek);


            Console.WriteLine(kek.Name);

            string js = JsonConvert.SerializeObject(kek);

            Console.WriteLine(js);


        }
    }
}
