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
    /// Tests for the CodeContract class
    /// 
    /// Author: Branden Brown
    /// </summary>
    [TestClass()]
    public class CodeContractTests
    {
        /// <summary>
        /// This test ensures that nothing is thrown when a contract is not broken.
        /// </summary>
        [TestMethod()]
        public void Requires_Passing_Test()
        {
            bool predicateTest = false;
            string message = "This contract should pass";

            CodeContract.Requires<ArgumentNullException>(predicateTest, message);
        }

        /// <summary>
        /// Tests the requires method to ensure the contract fails when expected. 
        /// Excepts an ArgumentNullException to be thrown.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Requires_Failing_Test()
        {
            bool predicateTest = true;
            string message = "This contract should fail";

            CodeContract.Requires<ArgumentNullException>(predicateTest, message);
        }
    }
}