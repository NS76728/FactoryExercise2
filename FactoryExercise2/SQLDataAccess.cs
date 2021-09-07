using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from {SQLDataAccess}");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a {SQLDataAccess} database");
        }
    }
}
