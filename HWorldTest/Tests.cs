﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HWorldTest
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void WelcomeTextIsDisplayed()
		{
			//AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
			//app.Screenshot("Welcome screen.");
			//Assert.IsTrue(results.Any());

            Assert.AreEqual("Hello", app.Query("HelloLabel")[0].Text);
            app.Tap("ClickButton");
            Assert.AreEqual("Goodbye", app.Query("HelloLabel")[0].Text);
        }
    }
}
