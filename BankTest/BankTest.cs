using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTest
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage 
            double balance = 1000.00;
            double debitAmount = 100.00;
            double expectedBalance = 900.00;

            Bank.Class1.BankAccount bank = new Bank.Class1.BankAccount("Shanthi", balance);

            //Act
            bank.Debit(debitAmount);


            //Assert
            double actualBalance = bank.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
       
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestOutOfRangeException()
        {
            //Arrage 
            double balance = 100.00;
            double debitAmount = 200.00;
            Bank.Class1.BankAccount bank = new Bank.Class1.BankAccount("Shanthi", balance);

            //Act
            bank.Debit(debitAmount);
           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestOutOfRangeException2()
        {
            //Arrage 
            double balance = 100.00;
            double debitAmount = -200.00;
            Bank.Class1.BankAccount bank = new Bank.Class1.BankAccount("Shanthi", balance);

            //Act
            bank.Debit(debitAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestFrozenAccount()
        {
            //Arrage 
            double balance = 100.00;
            double debitAmount = 50.00;
            Bank.Class1.BankAccount bank = new Bank.Class1.BankAccount("Shanthi", balance);
            bank.FreezeAccount();

            //Act
            bank.Debit(debitAmount);
        }

    }
}
