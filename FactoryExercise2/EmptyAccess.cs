using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class EmptyAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Empty");
        }

        public void SaveData()
        {
            Console.WriteLine("Empty");
        }
    }
}
