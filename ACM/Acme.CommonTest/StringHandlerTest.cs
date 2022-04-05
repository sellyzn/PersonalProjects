using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            //-- Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            //var handler = new StringHandler();

            //--Act
            //var actual = handler.InsertSpaces(source);
            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaceTestWithExistingSpace()
        {
            //-- Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            //var handler = new StringHandler();

            //--Act
            //var actual = handler.InsertSpaces(source);
            //var actual = StringHandler.InsertSpaces(source);

            // Extension method
            // when types source., the extension methods appear in IntelliSense.
            // No need to hunt around for or remember the name of the class in the component.

            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
