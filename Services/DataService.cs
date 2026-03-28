using System;
using System.Collections.Generic;

namespace Services
{
    public class DataService
    {
        public List<string> LoadDummyData()
        {
            return new List<string>
            {
                "Sample Data 1",
                "Sample Data 2",
                "Sample Data 3"
            };
        }

        public void PrintDummyData()
        {
            var data = LoadDummyData();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}