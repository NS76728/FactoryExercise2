using System;

namespace FactoryExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use: List, SQL, or Mongo");
            string input = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(input);
            Console.WriteLine("------------------");
            data.LoadData();
            data.SaveData();

        }
    }
}
