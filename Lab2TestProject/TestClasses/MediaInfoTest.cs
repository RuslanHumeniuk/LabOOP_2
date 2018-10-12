using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LabOp222.Models;
using LabOp222.Models.MediaFiles;

namespace Lab2TestProject.TestClasses
{
    [TestClass]
    public class MediaInfoTest
    {
        [TestMethod]
        public void Title_WhenSetNotNullString_ReturnsTrue()
        {
            MediaInfo instance = new Photo();
            string newTitle = "TestTitle";

            instance.Title = newTitle;

            Assert.AreEqual(instance.Title, newTitle);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Title_WhenSetEmptyString_ReturnArgumentException()
        {
            MediaInfo instance = new Gallery();
            instance.Title = String.Empty;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Title_WhenSetNull_ReturnsArgumentException()
        {
            MediaInfo instance = new Video() { Title = null };
        }

    }
}
