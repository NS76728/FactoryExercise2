using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from {MongoDataAccess}");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a {MongoDataAccess} database");
        }
    }
}
