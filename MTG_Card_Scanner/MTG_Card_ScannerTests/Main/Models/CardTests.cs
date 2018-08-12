using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG_Card_Scanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_Scanner.Tests
{
    /// <summary>
    /// Tests for the Card model class.
    /// 
    /// Author: Branden Brown
    /// </summary>
    [TestClass()]
    public class CardTests
    {
        private Card _cardModel;

        /// <summary>
        /// Setup method to run before each test.
        /// </summary>
        [TestInitialize()]
        public void SetUp()
        {
            _cardModel = new Card("nameTest", "setTest", "cardNumberTest");
        }

        /// <summary>
        /// Tests the constructor with valid inputs
        /// </summary>
        [TestMethod()]
        public void CardTest()
        {
            Assert.IsFalse(String.IsNullOrEmpty(_cardModel.Name));
            Assert.IsFalse(String.IsNullOrEmpty(_cardModel.Set));
            Assert.IsFalse(String.IsNullOrEmpty(_cardModel.CardNumber));
        }

        /// <summary>
        /// Tests the constructor with a <code>null</code> name as input. Expects an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CardNullNameTest()
        {
            _cardModel = new Card(null, "setTest", "cardNumberTest");
        }

        /// <summary>
        /// Tests the constructor with an empty name as input. Expects an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CardEmptyNameTest()
        {
            _cardModel = new Card(String.Empty, "setTest", "cardNumberTest");
        }

        /// <summary>
        /// Tests the constructor with a <code>null</code> set as input. Expects an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CardNullSetTest()
        {
            _cardModel = new Card("nameTest", null, "cardNumberTest");
        }

        /// <summary>
        /// Tests the constructor with an empty set as input. Expects an ArgumentNullExcpetion to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CardEmptySetTest()
        {
            _cardModel = new Card("nameTest", String.Empty, "cardNumberTest");
        }

    }
}