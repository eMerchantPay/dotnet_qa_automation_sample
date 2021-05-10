Feature: Calculator
	Simple calculator for applying math operators on two numbers

	#Please define and implement ALL needed scenarios for testing a simple calculator.
	#The calculatoor has only one feature and it is to apply math operations on two numbers.
	#The calculator is located at SampleLib project and has a method called "Calculate".

#basic scenarios
  
 Scenario: Add two numbers
 Given a digit is 30
 And b digit is 90
 When Sum them
 Then the result is 120

  Scenario: Substract two numbers
  Given a digit is 40
  And b digit is 20
  When Substract them
  Then the result is 20

  Scenario: Divide two numbers
  Given a digit is 40
  And b digit is 20
  When Divide them
  Then the result is 2

  Scenario: Multiply two numbers
  Given a digit is 40 
  And b digit is 20
  When Multiply them
  Then the result is 800

 #Negative scenarios

  Scenario: Add two numbers a is negative, b is positive
  Given a digit is -3
  And b digit is 2
  When Sum them
  Then the result is -1

  Scenario: Add two negative numbers
  Given a digit is -3 
  And b digit is 3
  When Sum them
  Then the result is 0

  Scenario: Add two numbers - decimals & Rounding check
  Given a digit is 4.25
  And b digit is 2.94
  When Sum them
  Then the result is 7.19

  Scenario: Substract two negative numbers
  Given a digit is -5
  And b digit is -3
  When Substract them
  Then the result is -2

  Scenario: Substract two decimal numbers
  Given a digit is 0.12
  And b digit is 1.19
  When Substract them
  Then the result is -1.07

  Scenario: Divide two negative numbers
  Given a digit is -5
  And b digit is -3
  When Divide them
  Then the result is 1.6666666666666666666666666667

  Scenario: Divide two decimal numbers
  Given a digit is 0.12
  And b digit is 1.19
  When Divide them
  Then the result is 0.100840336134453781512605042 

  Scenario: Multiply two decimal numbers
  Given a digit is 0.12
  And b digit is 1.19
  When Multiply them
  Then the result is 0.1428 

  Scenario: Multiply two negative numbers
  Given a digit is -7.12
  And b digit is -1.19
  When Multiply them
  Then the result is 8.4728
