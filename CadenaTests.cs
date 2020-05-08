using Microsoft.VisualStudio.TestTools.UnitTesting;
using tema3tarea2;
using System;
using System.Collections.Generic;
using System.Text;

namespace tema3tarea2.Tests
{
    [TestClass()]
    public class CadenaTests
    {
        [TestMethod()]
        public void ExtraerPrimerTest()
        {
            //Arrange

            var cadena = new Cadena("hola Vicent");

            var expected = "h";


            //Act
            var actual = cadena.ExtraerPrimer("hola Vicent");


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ExtraerUltimoTest()
        {

            //Arrange

            var cadena = new Cadena("hola Vicent");

            var expected = "t";


            //Act
            var actual = cadena.ExtraerUltimo("hola Vicent");


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void ExtraerCualquierTest()
        {
            //Arrange

            var cadena = new Cadena("hola Vicent");

            var expected = "a";


            //Act
            var actual = cadena.ExtraerCualquier("hola Vicent");


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}