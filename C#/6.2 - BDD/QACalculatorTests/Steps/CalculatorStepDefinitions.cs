﻿using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace QACalculatorTests.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private Calculator myCalc;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("a calculator")]
        public void GivenACalculator()
        {
            myCalc = new Calculator();
        }

        [When("I add (.*) and (.*)")]
        public void WhenIAddNumber1AndNumber2(int number1, int number2)
        {
            myCalc.AddTwoNumber(number1, number2);
        }

        [When("I subtract (.*) from (.*)")]
        public void WhenISubtractNumber1FromNumber2(int number1, int number2)
        {
            myCalc.SubtractTwoNumber(number1, number2);
        }

        [When("I multiply (.*) by (.*)")]
        public void WhenIMultiplyNumber1AndNumber2(int number1, int number2)
        {
            myCalc.MultiplyTwoNumber(number1, number2);
        }

        [Then("the outcome should be (.*)")]
        public void ThenTheOutcomeShouldBe(int expected)
        {
            int actual = myCalc.GetResult();
            Assert.AreEqual(expected, actual);
        }
    }
}
