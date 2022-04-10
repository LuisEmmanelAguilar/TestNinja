using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class InstallerHelperTests
    {
        private Mock<IFileDownloader> _mockFileDownloader;
        private InstallerHelper _installerHelper;

        [SetUp]
        public void Setup()
        {
            _mockFileDownloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallerHelper(_mockFileDownloader.Object);
        }

        [Test]
        public void DownloadInstaller_DownloadFails_ReturnFalse()
        {
            // Arrange
            _mockFileDownloader.Setup(fd => 
                fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>()))
                .Throws<WebException>();

            // Act
            var result = _installerHelper.DownloadInstaller("customer", "installer");

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnTrue()
        {
            // Act
            var result = _installerHelper.DownloadInstaller("customer", "installer");

            // Assert
            Assert.That(result, Is.True);
        }

    }
}
