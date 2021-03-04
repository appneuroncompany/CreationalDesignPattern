using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface
{
    public class AbstractFactoryMethotWithInterface
    {
        ICommand command;
        IConnection connection;
        IDatabaseFactory databaseFactory;

        public AbstractFactoryMethotWithInterface(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
            command = databaseFactory.CreateCommand();
            connection = databaseFactory.CreateConnection();

            TestDb();
        }

        void TestDb()
        {
            if (connection.State == "Open")
            {
                connection.Connect();
                command.Execute("Select * from...");
                connection.DisConnect();
            }
        }
    }
}
