namespace UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ConsoleApp1;

    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test The MonthByArray
        /// </summary>
        public void MasterTest(Action<Func<int,int>> test, Func<int,int>testedMethod)
        {
            test(testedMethod);
        }

        #region Arrays
        /// <summary>
        /// Test Negative Numbers of the Array Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArrayNegative()
        {
            MasterTest(NegativeNumber, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test High Numbers of the Array Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArrayHighNum()
        {
            MasterTest(HighNumber, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test Zero of the Array Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArrayZero()
        {
            MasterTest(ZeroNumber, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test Janurary of the Array Function
        /// </summary>
        [TestMethod]
        public void ArrayJanurary()
        {
            MasterTest(Janurary, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test Feburary of the Array Function
        /// </summary>
        [TestMethod]
        public void ArrayFeburary()
        {
            MasterTest(Feburary, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test May of the Array Function
        /// </summary>
        [TestMethod]
        public void ArrayMay()
        {
            MasterTest(May, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test June of the Array Function
        /// </summary>
        [TestMethod]
        public void ArrayJune()
        {
            MasterTest(June, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test July of the Array Function
        /// </summary>
        [TestMethod]
        public void ArrayJuly()
        {
            MasterTest(July, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test August of the Array Function
        /// </summary>
        [TestMethod]
        public void ArrayAugust()
        {
            MasterTest(August, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test September of the Array Function
        /// </summary>
        [TestMethod]
        public void ArraySeptember()
        {
            MasterTest(September, Program.GetMonthByArray);
        }

        /// <summary>
        /// Test Decemeber of the Array Function
        /// </summary>
        [TestMethod]
        public void ArrayDecemeber()
        {
            MasterTest(December, Program.GetMonthByArray);
        }
        #endregion

        #region Switchs
        /// <summary>
        /// Test Negative Numbers of the Switch Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SwitchNegative()
        {
            MasterTest(NegativeNumber, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test High Numbers of the Switch Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SwitchHighNum()
        {
            MasterTest(HighNumber, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test Zero of the Switch Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SwitchZero()
        {
            MasterTest(ZeroNumber, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test Janurary of the Switch Function
        /// </summary>
        [TestMethod]
        public void SwitchJanurary()
        {
            MasterTest(Janurary, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test Feburary of the Switch Function
        /// </summary>
        [TestMethod]
        public void SwitchFeburary()
        {
            MasterTest(Feburary, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test May of the Switch Function
        /// </summary>
        [TestMethod]
        public void SwitchMay()
        {
            MasterTest(May, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test June of the Switch Function
        /// </summary>
        [TestMethod]
        public void SwitchJune()
        {
            MasterTest(June, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test July of the Switch Function
        /// </summary>
        [TestMethod]
        public void SwitchJuly()
        {
            MasterTest(July, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test August of the Switch Function
        /// </summary>
        [TestMethod]
        public void SwitchAugust()
        {
            MasterTest(August, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test September of the Switch Function
        /// </summary>
        [TestMethod]
        public void SwitchSeptember()
        {
            MasterTest(September, Program.GetMonthBySwitch);
        }

        /// <summary>
        /// Test Decemeber of the Switch Function
        /// </summary>
        [TestMethod]
        public void SwitchDecemeber()
        {
            MasterTest(December, Program.GetMonthBySwitch);
        }
        #endregion

        #region Magics
        /// <summary>
        /// Test Negative Numbers of the Magic Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MagicNegative()
        {
            MasterTest(NegativeNumber, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test High Numbers of the Magic Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MagicHighNum()
        {
            MasterTest(HighNumber, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test Zero of the Magic Function
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MagicZero()
        {
            MasterTest(ZeroNumber, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test Janurary of the Magic Function
        /// </summary>
        [TestMethod]
        public void MagicJanurary()
        {
            MasterTest(Janurary, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test Feburary of the Magic Function
        /// </summary>
        [TestMethod]
        public void MagicFeburary()
        {
            MasterTest(Feburary, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test May of the Magic Function
        /// </summary>
        [TestMethod]
        public void MagicMay()
        {
            MasterTest(May, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test June of the Magic Function
        /// </summary>
        [TestMethod]
        public void MagicJune()
        {
            MasterTest(June, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test July of the Magic Function
        /// </summary>
        [TestMethod]
        public void MagicJuly()
        {
            MasterTest(July, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test August of the Magic Function
        /// </summary>
        [TestMethod]
        public void MagicAugust()
        {
            MasterTest(August, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test September of the Magic Function
        /// </summary>
        [TestMethod]
        public void MagicSeptember()
        {
            MasterTest(September, Program.GetMonthByMagic);
        }

        /// <summary>
        /// Test Decemeber of the Magic Function
        /// </summary>
        [TestMethod]
        public void MagicDecemeber()
        {
            MasterTest(December, Program.GetMonthByMagic);
        }
        #endregion

        /// <summary>
        /// Test Negative Numbers
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void NegativeNumber (Func<int,int> method)
        {
            method(-1);
        }

        /// <summary>
        /// Test a number that is higher than 12 (the number of months)
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void HighNumber (Func<int,int> method)
        {
            method(13);
        }

        /// <summary>
        /// Test Zero, which is not a month
        /// </summary>
        /// <param name="method">Method to produce the days</param>
        public void ZeroNumber (Func<int,int> method)
        {
            method(0);
        }

        #region MonthOfYears
        /// <summary>
        /// Test days of Janurary
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void Janurary (Func<int,int> method)
        {
            Assert.AreEqual(method(1), 31);
        }

        /// <summary>
        /// Test days of Feburary
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void Feburary (Func<int, int> method)
        {
            Assert.AreEqual(method(2), 28);
        }

        /// <summary>
        /// Test days of May
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void May(Func<int, int> method)
        {
            Assert.AreEqual(method(5), 31);
        }

        /// <summary>
        /// Test days of June
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void June(Func<int, int> method)
        {
            Assert.AreEqual(method(6), 30);
        }

        /// <summary>
        /// Test days of July
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void July(Func<int, int> method)
        {
            Assert.AreEqual(method(7), 31);
        }

        /// <summary>
        /// Test days of August
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void August(Func<int, int> method)
        {
            Assert.AreEqual(method(8), 31);
        }

        /// <summary>
        /// Test days of September
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void September(Func<int, int> method)
        {
            Assert.AreEqual(method(9), 30);
        }

        /// <summary>
        /// Test days of December
        /// </summary>
        /// <param name="method">method to produce the days</param>
        public void December(Func<int, int> method)
        {
            Assert.AreEqual(method(12), 31);
        }
#endregion
    }
}
