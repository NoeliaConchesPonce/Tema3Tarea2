using Microsoft.VisualStudio.TestTools.UnitTesting;
using tema3tarea2;
using System;
using System.Collections.Generic;
using System.Text;

namespace tema3tarea2.Tests
{
    [TestClass()]
    public class CosasFechasTests
    {
        [TestMethod()]
        public void DiaSemanaTest()
        {


            //Arrange

            var fechas = new CosasFechas(DateTime.Today);

            var expected = "Friday";


            //Act
            var actual = fechas.DiaSemana(DateTime.Today);


            //Assert
            Assert.AreEqual(expected, actual);



        }
    }
}