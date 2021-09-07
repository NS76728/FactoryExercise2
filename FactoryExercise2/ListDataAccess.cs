using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from {ListDataAccess}");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a {ListDataAccess} database");
        }
    }
}
