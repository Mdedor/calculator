using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using clas;
namespace Calc.test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Div_3_44_and_6_88_returned_0_5() //Деление двух вещественных чисел 1<2
        {
            //arange
            double x = 3.44;
            double y = 6.88;
            double ecpected = 0.5;
            //act
            double actual = clas.Calc_class.div(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void Div_7_4_and_3_7_returned_2() //Деление двух вещественных чисел 1>2
        {
            //arange
            double x = 7.4;
            double y = 3.7;
            double ecpected = 2;
            //act
            double actual = clas.Calc_class.div(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void Div_9_1_and_9_1_returned_1() //Деление двух вещественных чисел 1=2
        {
            //arange
            double x = 9.1;
            double y = 9.1;
            double ecpected = 1;
            //act
            double actual = clas.Calc_class.div(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void Div_minus_1_24_and_minus_0_31_returned_0_5() //Деление двух минусовых вещественных чисел 1<2
        {
            //arange
            double x = -1.24;
            double y = -0.31;
            double ecpected = 4;
            //act
            double actual = clas.Calc_class.div(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void Div_minus_8_4_and_minus_2_8_returned_3() //Деление двух минусовых вещественных чисел 1<2
        {
            //arange
            double x = -8.4;
            double y = -2.8;
            double ecpected = 3;
            //act
            double actual = clas.Calc_class.div(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void Div_minus_2_4_and_minus_2_4_returned_3() //Деление двух минусовых вещественных чисел 1<2
        {
            //arange
            double x = -2.4;
            double y = -2.4;
            double ecpected = 1;
            //act
            double actual = clas.Calc_class.div(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void Div_2_2_and_0_returned_3() //Деление двух минусовых вещественных чисел 1<2
        {
            //arange
            double x = 2.2;
            double y = 0;
            double ecpected = 0;
            //act
            double actual = clas.Calc_class.div(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void Div_0_and_1_4_returned_3() //Деление двух минусовых вещественных чисел 1<2
        {
            //arange
            double x = 0;
            double y = 1.4;
            double ecpected = 0;
            //act
            double actual = clas.Calc_class.div(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
    }
}
