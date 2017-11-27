Feature: Main
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@AddTwoNumbers
Scenario: Add two numbers
	Given I have opened calculator

	When I have entered 5 into the calculator
	Then The result field should be 5 
	
	When I press "add" button
	Then The result field should be empty

	When I have entered 7 into the calculator
	Then The result field should be 7 

	When I press result button
	Then The result should be 12

	@MinusTwoNumbers
Scenario: Minus two numbers
	Given I have opened calculator

	When I have entered 7 into the calculator
	Then The result field should be 7
	
	When I press "minus" button
	Then The result field should be empty

	When I have entered 5 into the calculator
	Then The result field should be 5 

	When I press result button
	Then The result should be 2

	@MultiplyTwoNumbers
Scenario: Multiply two numbers
	Given I have opened calculator

	When I have entered 5 into the calculator
	Then The result field should be 5 
	
	When I press "multiply" button
	Then The result field should be empty

	When I have entered 7 into the calculator
	Then The result field should be 7 

	When I press result button
	Then The result should be 35

	@DivideTwoNumbers
Scenario: Divide two numbers
	Given I have opened calculator

	When I have entered 9 into the calculator
	Then The result field should be 9 
	
	When I press "divide" button
	Then The result field should be empty

	When I have entered 3 into the calculator
	Then The result field should be 3 

	When I press result button
	Then The result should be 3
