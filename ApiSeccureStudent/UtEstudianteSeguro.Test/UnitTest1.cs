using System;
using ApiSeccureStudent.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtEstudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arrange
            StudentsController students = new StudentsController ();




            //Act
            var ListaEstudiante = students.GetStudents();


            //Assert
            Assert.IsNotNull(ListaEstudiante);


        }
    }
}
