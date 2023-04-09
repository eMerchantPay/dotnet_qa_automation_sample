Feature: Calculator
	Check simple calculations for applying math operators on two numbers

	#Please define and implement ALL needed scenarios for testing a simple calculator.
	#The calculatoor has only one feature and it is to apply math operations on two numbers.
	#The calculator is located at SampleLib project and has a method called "Calculate".

	#Positive scenarios with possitive numbers

	Scenario: Add two numbers
	Given first number is 7
	And second number is 3
	When the two numbers are added
	Then the result is 10 
