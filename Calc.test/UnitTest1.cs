using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using clas;
namespace Calc.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sub_200_and_200_returned_0() //вычитание 2 целых чисел 1=2
        {
            //arange
            int x = 200;
            int y = 200;
            int ecpected = 0;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_5_and_10_returned_minus5()//вычитание 2 целых чисел 1<2
        {
            //arange
            int x = 5;
            int y = 10;
            int ecpected = -5;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_10_and_2_returned_8() //вычитание 2 целых чисел 1>2
        {
            //arange
            int x = 10;
            int y = 2;
            int ecpected = 8;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_minus_2_and_minus_2_returned_0() //вычитание 2 целых отрицательных чисел 1=2
        {
            //arange
            int x = -2;
            int y = -2;
            int ecpected = 0;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_minus_10_and_minus_1_returned_minus_9()//вычитание отрицательных 2 целых чисел 1>2
        {
            //arange
            int x = -10;
            int y = -1;
            int ecpected = -9;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_minus_1_and_minus_20_returned_18() //вычитание 2 отрицательных целых чисел 1<2
        {
            //arange
            int x = -1;
            int y = -20;
            int ecpected = 19;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_10_48_and_2_22_returned_8_26() //вычитание 2 вещественных чисел 1>2
        {
            //arange
            double x = 10.48;
            double y = 2.22;
            double ecpected = 8.26;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_1_82_and_2_42_returned_minus_0_62() //вычитание 2 вещественных чисел 1<2
        {
            //arange
            double x = 1.82;
            double y = 2.42;
            double ecpected = -0.6;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        public void sub_1_1_and_1_1_returned_minus_0() //вычитание 2 вещественных чисел 1=2
        {
            //arange
            double x = 1.1;
            double y = 1.1;
            double ecpected = 0;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }


        [TestMethod]
        public void sub_minus_1_08_and_minus_4_02_returned_0_74() //вычитание 2 отрицательных вещественных чисел 1>2
        {
            //arange
            double x = -1.08;
            double y = -2.02;
            double ecpected = 0.94;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_minus_9_3_and_minus_2_092_returned_minus_7_208() //вычитание 2 отрицательных вещественных чисел 1<2
        {
            //arange
            double x = -9.3;
            double y = -2.092;
            double ecpected = -7.208;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void sub_minus_1_and_minus_1_returned_0() //вычитание 2 отрицательных вещественных чисел 1=2
        {
            //arange
            double x = -1;
            double y = -1;
            double ecpected = 0;
            //act
            double actual = clas.Calc_class.sub(x, y);
            //assert
            Assert.AreEqual(ecpected, actual);
        }
    }
}
