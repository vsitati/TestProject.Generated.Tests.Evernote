using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System.Threading;
using System;
using TestProject.SDK;
using TestProject.SDK.Tests.Helpers;
using TestProject.SDK.Tests;
using TestProject.Common.Attributes;
using TestProject.Common.Enums;

namespace TestProject.Generated.Tests.Evernote
{
	
	public class Evernote : IWebTest
	{
		[ParameterAttribute(Description = "Auto generated application URL parameter", DefaultValue = "https://evernote.com", Direction = ParameterDirection.Input)]
		public string ApplicationURL;
		public ExecutionResult Execute(WebTestHelper helper)
		{
			var driver = helper.Driver;
			var report = helper.Reporter;
			bool boolResult;
			By by;
			
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 15000;
			
			 // 1. Navigate to '{{ApplicationURL}}'
			// Navigates the specified URL (Auto-generated)
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().NavigateToURL(ApplicationURL);
			report.Step(string.Format("Navigate to '{0}'", ApplicationURL), boolResult, TakeScreenshotConditionType.Failure);
			
			 // 2. Click 'Already have an account? Log in'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//a[. = 'Already have an account? Log in']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Already have an account? Log in'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 3. Click 'username'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#username");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'username'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 4. Type 'vsitati@gmail.com' in 'username'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#username");
			boolResult = driver.TestProject().TypeText(by, "vsitati@gmail.com");
			report.Step("Type 'vsitati@gmail.com' in 'username'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 5. Click 'evaluateUsername'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#loginButton");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'evaluateUsername'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 6. Click 'password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 7. Type '6LuC_$vPt!ayEnS' in 'password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TestProject().TypeText(by, "6LuC_$vPt!ayEnS");
			report.Step("Type '6LuC_$vPt!ayEnS' in 'password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 8. Click 'evaluateUsername'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#loginButton");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'evaluateUsername'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 9. Click 'New'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//button/div[. = 'New']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'New'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 10. Click 'Note'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//button[. = 'Note']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Note'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 11. Click 'Title'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//textarea[@placeholder = 'Title']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Title'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 12. Type 'New Note' in 'Title'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//textarea[@placeholder = 'Title']");
			boolResult = driver.TestProject().TypeText(by, "New Note");
			report.Step("Type 'New Note' in 'Title'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 13. Click 'this iis   new note'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//div[. = 'this iis   new note']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'this iis   new note'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 14. Type 'New note for tomorrow: get awesome' in 'newnotes for victor'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//div[. = 'newnotes for victor']");
			boolResult = driver.TestProject().TypeText(by, "New note for tomorrow: get awesome");
			report.Step("Type 'New note for tomorrow: get awesome' in 'newnotes for victor'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 15. Click 'Victor Sitati'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//span/div/div/div[. = 'Victor Sitati']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Victor Sitati'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 16. Click 'Sign out Victor Sitati'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//span/span[. = 'Sign out Victor Sitati']");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Sign out Victor Sitati'", boolResult, TakeScreenshotConditionType.Failure);
			
			return ExecutionResult.Passed;
		}
	}
}