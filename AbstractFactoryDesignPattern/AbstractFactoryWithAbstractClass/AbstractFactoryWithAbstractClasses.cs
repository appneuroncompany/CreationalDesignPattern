using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using System;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass
{


    public class AbstractFactoryWithAbstractClasses 
    {
        DatabaseFactory databaseFactory;
        Command command;
        Connection connection;

        public AbstractFactoryWithAbstractClasses(DatabaseFactory databaseFactory)
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
