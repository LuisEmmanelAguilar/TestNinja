using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            _logger.Log("a");

            Assert.That(_logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            // using a delegate while writing the assertion
            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
        }

        // Testing Methods that Raise an Event
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var id = Guid.Empty;

            // when we raise the Error Logged Method we send
            // id into args
            _logger.ErrorLogged += (sender, args) => { id = args; };
            _logger.Log("a");


            // if the event is Raised and makes the ejecution
            // Id will not be longer an empy Guid

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }



    }
}
