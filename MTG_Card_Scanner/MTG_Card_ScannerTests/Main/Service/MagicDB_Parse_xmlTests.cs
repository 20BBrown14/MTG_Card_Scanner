using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG_Card_Scanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace MTG_Card_Scanner.Tests
{
    /// <summary>
    /// Tests for the MagicDB_Parse_xml service class.
    /// 
    /// Author: Branden Brown
    /// </summary>
    [TestClass()]
    public class MagicDB_Parse_xmlTests
    {
        private MagicDB_Parse_xml _magicDB_Parse_xml;

        /// <summary>
        /// Setup method to run before each test.
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
        }

        /// <summary>
        /// Tests the no-arg constructor.
        /// </summary>
        [TestMethod()]
        public void MagicDB_Parse_xml_NoArg_Test()
        {
            _magicDB_Parse_xml = new MagicDB_Parse_xml();
            Assert.IsNotNull(_magicDB_Parse_xml.xmlDatabase);
            Assert.IsNotNull(_magicDB_Parse_xml.cardList);
            Assert.IsFalse(String.IsNullOrEmpty(_magicDB_Parse_xml.xmlDatabasePath));
            Assert.AreEqual("../../Main/Resources/Database/MagicTG_DB_Main.xml", _magicDB_Parse_xml.xmlDatabasePath);
        }

        /// <summary>
        /// Tests the parameterized constructor with valid inputs.
        /// </summary>
        [TestMethod()]
        public void MagicDB_Parse_xml_Paramterized_Test()
        {
            _magicDB_Parse_xml = new MagicDB_Parse_xml("testString");
            Assert.IsNotNull(_magicDB_Parse_xml.xmlDatabase);
            Assert.IsNotNull(_magicDB_Parse_xml.cardList);
            Assert.IsFalse(String.IsNullOrEmpty(_magicDB_Parse_xml.xmlDatabasePath));
            Assert.AreEqual("testString", _magicDB_Parse_xml.xmlDatabasePath);
        }

        /// <summary>
        /// Tests the parameterized constructor with a <code>null</code> path as input. 
        /// Expects an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MagicDB_Parse_xml_Paramterized_Null_Path_Test()
        {
            _magicDB_Parse_xml = new MagicDB_Parse_xml(null);
        }

        /// <summary>
        /// Tests the LoadCards method. Should return a non <code>null</code> 
        /// List<Card> with a count of greater than one.
        /// </summary>
        [TestMethod()]
        public void LoadCardsTest()
        {
            _magicDB_Parse_xml = new MagicDB_Parse_xml("../../../Main/Resources/Database/MagicTG_DB_Main.xml");
            List<Card> cardList = _magicDB_Parse_xml.LoadCards();
            Assert.IsNotNull(cardList);
            Assert.AreNotEqual(0, cardList.Count);
        }

        /// <summary>
        /// Tests the LoadSets method. Should return a non <code>null</code>
        /// List<MTGSet> with a count of greater than one.
        /// </summary>
        [TestMethod()]
        public void LoadSetsTest()
        {
            _magicDB_Parse_xml = new MagicDB_Parse_xml("../../../Main/Resources/Database/MagicTG_DB_Main.xml");
            List<MTGSet> setList = _magicDB_Parse_xml.LoadSets();
            Assert.IsNotNull(setList);
            Assert.AreNotEqual(0, setList.Count);
        }
    }
}