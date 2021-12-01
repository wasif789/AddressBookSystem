using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book");
            //calling operation management class that contains operation
            OperationManagement operationmanagement = new OperationManagement();
            operationmanagement.ReadInput();
            Console.Read();
        }
    }
}