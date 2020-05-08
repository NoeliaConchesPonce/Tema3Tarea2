using Microsoft.VisualStudio.TestTools.UnitTesting;
using tema3tarea2;
using System;
using System.Collections.Generic;
using System.Text;

namespace tema3tarea2.Tests
{
    [TestClass()]
    public class OperacionTests
    {
        [TestMethod()]
        public void SumaTest()
        {

            //Arrange

            var operacion = new Operacion(5, 10);

            var expected = 15;


            //Act
            var actual = operacion.Suma(5, 10);


            //Assert
            Assert.AreEqual(expected, actual);

        }




        [TestMethod()]
        public void MultiplicacionTest()
        {

            //Arrange

            var operacion = new Operacion(5, 10);

            var expected = 50;


            //Act
            var actual = operacion.Multiplicacion(5, 10);


            //Assert
            Assert.AreEqual(expected, actual);




        }

        [TestMethod()]
        public void RestaTest()
        {
            //Arrange

            var operacion = new Operacion(5, 10);

            var expected = 5;


            //Act
            var actual = operacion.Resta(5, 10);


            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}