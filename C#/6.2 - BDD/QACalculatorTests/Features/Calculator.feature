Feature:
	Various scenarios to test the calculator

Scenario: Add two numbers
	Given a calculator
	When I add 2 and 9
	Then the outcome should be 11

Scenario: Subtract two numbers
	Given a calculator
	When I subtract 2 from 7
	Then the outcome should be 5

Scenario: Multiply two numbers
	Given a calculator
	When I multiply 3 by 5
	Then the outcome should be 15