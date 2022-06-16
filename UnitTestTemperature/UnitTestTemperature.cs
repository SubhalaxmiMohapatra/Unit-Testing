using Microsoft.VisualStudio.TestTools.UnitTesting;
using FahrenheitApp.Models;

namespace UnitTestTemperature
{
	[TestClass]
	public class UnitTestTemperature
	{
		[TestMethod]
		public void TestFahrenheitConversion()
		{
			double temperatureCelcius = 22;
			double temperatureFahrenheitActual;
			double temperatureFahreheitExpected = 71.6;

			temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius);
			Assert.AreEqual(temperatureFahreheitExpected, temperatureFahrenheitActual, 0.001, "Temperature conversion not correctly");

		}
	}
}