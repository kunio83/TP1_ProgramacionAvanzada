using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TP1_ProgramacionAvanzada;


namespace P1_ProgramacionAvanzada.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int numeroA = 1;
            int numeroB = 5;
            int esperado = 6;

            // Act
            int result = Practica.Sumar(numeroA, numeroB);

            // Assert
            Assert.AreEqual(esperado, result);
        }
    }
}
