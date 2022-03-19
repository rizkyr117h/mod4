using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302203122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.AddNewData(12);
            data.AddNewData(34);
            data.AddNewData(56);
            data.PrintAllData();
        }
        class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;
            public SimpleDataBase()
            {
                storedData = new List<T>();
                inputDates = new List<DateTime>();
            }
            public void AddNewData(T data)
            {
                storedData.Add(data);
                inputDates.Add(DateTime.Now);
            }
            public void PrintAllData()
            {
                for (int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine("Data " +(i + 1)+ " berisi :" + storedData[i].ToString() + ",yang disimpan pada waktu" + inputDates[i]);
                }
            }
        }
    }
}
