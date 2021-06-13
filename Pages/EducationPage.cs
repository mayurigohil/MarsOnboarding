using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowProject1.Pages
{
    class EducationPage
    {
        internal void EducationPageSteps(IWebDriver driver)
        {
            // create records in education

            // click on add new
            IWebElement AddNewEducation = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[6]/div[1]"));
            AddNewEducation.Click();

            // add college/university name
            IWebElement CollegeName = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            CollegeName.SendKeys("Weltec");

            // identify country of college and click on it
            IWebElement CountryOfCollege = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
            CountryOfCollege.Click();

            // choose New Zealand from drop Down list
            IWebElement NewZealand = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]/option[102]"));
            NewZealand.Click();

            // identify Title and click on it
            IWebElement Title = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
            Title.Click();

            // choose B.A from Drop Down list
            IWebElement BA = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]/option[3]"));
            BA.Click();

            // Add Degree
            IWebElement Degree = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
            Degree.SendKeys("Bachelor");

            // Identify Year of Graduation and click on it
            IWebElement YearOfGraduation = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
            YearOfGraduation.Click();

            // Choose Year 2016 from drop down list
            IWebElement Year2016 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]/option[7]"));
            Year2016.Click();

            // Click on add button
            IWebElement EducationAddButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            EducationAddButton.Click();
            Thread.Sleep(5000);

            // validate if the record in Education has been added
            Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text, Is.EqualTo("Weltec"));
        }
        internal void EducationsPageSteps(IWebDriver driver)
        {
            // Edit Records in Education
            Thread.Sleep(2000);
            // click on edit icon and click on it
            IWebElement EducationEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[1]/i[1]"));
            EducationEditIcon.Click();
            Wait.ElementPresent(driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]");

            // Clear previous college name
            IWebElement ClearCollegeName = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            ClearCollegeName.Clear();
            Thread.Sleep(1000);

            // edit college/university name
            IWebElement EditCollegeName = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            EditCollegeName.SendKeys("GNDU");

            // identify country of college and click on it
            IWebElement EditCountryOfCollege = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            EditCountryOfCollege.Click();

            // choose India from drop Down list
            IWebElement India = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[2]/select[1]/option[66]"));
            India.Click();

            // identify Title and click on it
            IWebElement EditTitle = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[1]/select[1]"));
            EditTitle.Click();

            // choose M.A from Drop Down list
            IWebElement MA = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[1]/select[1]/option[9]"));
            MA.Click();
            Wait.ElementPresent(driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[2]/input[1]");

            // Previous Degree
            IWebElement ClearDegree = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[2]/input[1]"));
            ClearDegree.Clear();
            Thread.Sleep(1000);

            // Add Degree
            IWebElement Degree = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[2]/input[1]"));
            Degree.SendKeys("Masters");

            // Identify Year of Graduation and click on it
            IWebElement EditYearOfGraduation = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[3]/select[1]"));
            EditYearOfGraduation.Click();

            // Choose Year 2019 from drop down list
            IWebElement Year2019 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[3]/select[1]/option[4]"));
            Year2019.Click();

            // Click on update button
            IWebElement EducationUpdateButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[3]/input[1]"));
            EducationUpdateButton.Click();
            Thread.Sleep(5000);

            // validate if the record in Education has been updated
            Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text, Is.EqualTo("GNDU"));
        }
        internal void EducationPagesSteps(IWebDriver driver)
        {
            // Delete records in Education
            Thread.Sleep(2000);
            // Click on delete icon
            IWebElement DeleteEducation = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[2]/i[1]"));
            DeleteEducation.Click();
            Thread.Sleep(5000);

            // validate if the Education record has been deleted
            //Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text, Is.EqualTo("GNDU"));
        }
    }
}
