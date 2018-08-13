using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG_Card_Scanner.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_Scanner.Main.Models.Tests
{
    /// <summary>
    /// Tests related to the MTGSet model.
    /// 
    /// Author: Branden Brown
    /// </summary>
    [TestClass()]
    public class MTGSetTests
    {
        /// <summary>
        /// Tests the constructor with valid args.
        /// </summary>
        [TestMethod()]
        public void MTGSetTest()
        {
            MTGSet set = new MTGSet("testName", "testCode");
            Assert.AreEqual("testName", set.setName);
            Assert.AreEqual("testCode", set.setCode);
        }

        /// <summary>
        /// Tests the constructor with a <code>null</code> name passed in.
        /// Expects an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MTGSetNullNameTest()
        {
            MTGSet set = new MTGSet(null, "testCode");
        }

        /// <summary>
        /// Tests the constructor with an empty name passed in.
        /// Expects an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MTGSetEmptyNameTest()
        {
            MTGSet set = new MTGSet(String.Empty, "testCode");
        }

        /// <summary>
        /// Tests the constructor with a <code>null</code> code passed in.
        /// Expects an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MTGSetNullCodeTest()
        {
            MTGSet set = new MTGSet("testName", null);
        }

        /// <summary>
        /// Tests the constructor with an empty code passed in.
        /// Expects an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MTGSetEmptyCodeTest()
        {
            MTGSet set = new MTGSet("testName", String.Empty);
        }
    }
}