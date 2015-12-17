﻿using CUITe.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.WinForms.ScreenComponentsTest.ObjectRepository;

namespace Sut.WinForms.ScreenComponentsTest
{
    /// <summary>
    /// Summary description for ScreenComponentsTest
    /// </summary>
    [CodedUITest]
#if DEBUG
    [DeploymentItem(@"..\..\..\Sut.WinForms.ScreenComponents\bin\Debug\Sut.WinForms.ScreenComponents.exe")]
#else
    [DeploymentItem(@"..\..\..\Sut.WinForms.ScreenComponents\bin\Release\Sut.WinForms.ScreenComponents.exe")]
#endif
    public class ScreenComponentsTest
    {
        private const string ApplicationFilePath = @"Sut.WinForms.ScreenComponents.exe";
        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            mainScreen = Screen.Launch<MainScreen>(ApplicationFilePath);
        }

        [TestMethod]
        public void UpperLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.UpperLeft.CheckBoxExists);
        }

        [TestMethod]
        public void RebasedUpperLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedUpperLeft.Self.Exists);
            Assert.IsTrue(mainScreen.RebasedUpperLeft.CheckBoxExists);
        }

        [TestMethod]
        public void UpperRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.UpperRight.CheckBoxExists);
        }

        [TestMethod]
        public void RebasedUpperRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedUpperRight.Self.Exists);
            Assert.IsTrue(mainScreen.RebasedUpperRight.CheckBoxExists);
        }

        [TestMethod]
        public void LowerLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.LowerLeft.RadioButtonExists);
        }

        [TestMethod]
        public void RebasedLowerLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedLowerLeft.Self.Exists);
            Assert.IsTrue(mainScreen.RebasedLowerLeft.RadioButtonExists);
        }

        [TestMethod]
        public void LowerRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.LowerRight.RadioButtonExists);
        }

        [TestMethod]
        public void RebasedLowerRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedLowerRight.Self.Exists);
            Assert.IsTrue(mainScreen.RebasedLowerRight.RadioButtonExists);
        }

        [TestMethod]
        public void Application()
        {
            // Act
            ApplicationUnderTest actual = mainScreen.Application;

            // Assert
            Assert.AreEqual(mainScreen.UpperLeft.Application, actual);
            Assert.AreEqual(mainScreen.RebasedUpperLeft.Application, actual);
            Assert.AreEqual(mainScreen.UpperRight.Application, actual);
            Assert.AreEqual(mainScreen.RebasedUpperRight.Application, actual);
            Assert.AreEqual(mainScreen.LowerLeft.Application, actual);
            Assert.AreEqual(mainScreen.RebasedLowerLeft.Application, actual);
            Assert.AreEqual(mainScreen.LowerRight.Application, actual);
            Assert.AreEqual(mainScreen.RebasedLowerRight.Application, actual);
        }

        [TestMethod]
        public void NavigateToModalDialog()
        {
            // Act
            var dialogScreen = mainScreen.MiddleComponent.NavigateToModalDialogScreen();

            // Assert
            Assert.IsTrue(dialogScreen.CloseButtonExists);
        }

        [TestMethod]
        public void NavigateToNonModalDialog()
        {
            // Act
            var dialogScreen = mainScreen.MiddleComponent.NavigateToNonModalDialogScreen();

            // Assert
            Assert.IsTrue(dialogScreen.CloseButtonExists);
        }
    }
}