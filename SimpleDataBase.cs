using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5_103022300023
{
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

        public void printAllData()
        {
            foreach (T data in storedData)
            {
                Console.WriteLine($"Data {data} berisi: {data}, yang disimpan pada waktu UTC: {DateTime.Now}");
            }
        }
    }
}
