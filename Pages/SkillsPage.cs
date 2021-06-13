using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowProject1.Pages
{
    class SkillsPage
    {
        internal void SkillsPageSteps(IWebDriver driver)
        {
        // create record in Skills

        // click on add new 
        IWebElement AddNewSkills = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        AddNewSkills.Click();
        Wait.ElementPresent(driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]");

        // Add Skills
        IWebElement AddSkills = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        AddSkills.SendKeys("TeamWork");

        // Identify Skills Level Button and click on it
        IWebElement SkillsLevel = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
        SkillsLevel.Click();

        // choose Intermediate from Drop Down List
        IWebElement Intermediate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]/option[3]"));
        Intermediate.Click();

        // click on add button
        IWebElement SkillsAddButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
        SkillsAddButton.Click();
        Thread.Sleep(5000);

        // validate if the skills record is added
        Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text, Is.EqualTo("TeamWork"));
        }

        internal void SkillPageSteps(IWebDriver driver)
        {

        // edit Skills records
        Thread.Sleep(2000);

        // identify edit icon and click on it
        IWebElement SkillsEditIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
        SkillsEditIcon.Click();
        Wait.ElementPresent(driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]");

        // clear previous data from skills
        IWebElement ClearSkills = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]"));
        ClearSkills.Clear();
        Thread.Sleep(1000);

        // edit Skills
        IWebElement EditSkills = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]"));
        EditSkills.SendKeys("ProblemSolving");

        // identify Language level button and click on it
        IWebElement EditSkillsLevel = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[2]/select[1]"));
        EditSkillsLevel.Click();

        // choose Expert from drop down list
        IWebElement Expert = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[2]/select[1]/option[4]"));
        Expert.Click();

        // click on Update
        IWebElement UpdateSkills = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
        UpdateSkills.Click();
        Thread.Sleep(5000);

        // Validate if the skills record is updated
        Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text, Is.EqualTo("ProblemSolving"));
        }

        internal void SkillPageStep(IWebDriver driver)
        {
            // delete the record from Skills
            Thread.Sleep(2000);

            // identify the remove icon and click on it
            IWebElement DeleteSkills = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            DeleteSkills.Click();
            Thread.Sleep(5000);

            // validate if the skills record has been deleted
            //Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text, Is.EqualTo("ProblemSolving"));
        }
    }
}
