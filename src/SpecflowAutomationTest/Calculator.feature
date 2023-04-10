Feature: Calculator
	Check simple calculations for applying math operators on two numbers

#Positive scenarios
Scenario Outline: Add two numbers
	Given first number is <firstNum>
	And second number is <secondNum>
	When the two numbers are added
	Then the result is <result>

	Examples:
		| firstNum | secondNum | result    |
		| 7        | 3         | 10        |
		| -5       | -55       | -60       |
		| 7.038954 | 11.0005   | 18.039454 |
		| -999     | 88.3147   | -910.6853 |

Scenario Outline: Substract two numbers
	Given first number is <firstNum>
	And second number is <secondNum>
	When the two numbers are substracted
	Then the result is <result>

	Examples:
		| firstNum | secondNum | result     |
		| 7        | 3         | 4          |
		| -5       | -55       | 50         |
		| 7.038954 | 11.0005   | -3.961546  |
		| -999     | 88.3147   | -1087.3147 |

Scenario Outline: Multiply two numbers
	Given first number is <firstNum>
	And second number is <secondNum>
	When the two numbers are multiplied
	Then the result is <result>

	Examples:
		| firstNum | secondNum | result       |
		| 7        | 3         | 21           |
		| 7        | 0         | 0            |
		| 0        | 7.77      | 0            |
		| -5       | -55       | 275          |
		| 7.038954 | 11.0005   | 77.432013477 |
		| -999     | 88.3147   | -88226.3853  |

Scenario Outline: Divide two numbers
	Given first number is <firstNum>
	And second number is <secondNum>
	When the two numbers are divided
	Then the result is <result>

	Examples:
		| firstNum | secondNum | result                          |
		| 7        | 3         | 2.3333333333333333333333333333  |
		| -5       | -55       | 0.0909090909090909090909090909  |
		| 7.038954 | 11        | 0.6399049090909090909090909091  |
		| -999     | 88.3147   | -11.311820116016925834543966067 |
		| 999      | -88.3147  | -11.311820116016925834543966067 |
		| 99.9     | 88.8      | 1.125                           |

Scenario Outline: Power two numbers
	Given first number is <firstNum>
	And second number is <secondNum>
	When the two numbers are powered
	Then the result is <result>

	Examples:
		| firstNum | secondNum | result           |
		| 7        | 3         | 343              |
		| 7        | 0         | 1                |
		| 0        | 3.1       | 0                |
		| -5       | -3        | -0.008           |
		| 7.038954 | 11.0005   | 2103842149.97199 |

#Negative scenarios
Scenario: Unknown operator
	Given first number is 7
	And second number is 3
	When adding an unknown operator
	Then result is equals an unknown operator

Scenario Outline: Dividing with zero
	Given first number is <firstNum>
	And second number is <secondNum>
	When the two numbers are divided
	Then the result equals an error message

	Examples:
		| firstNum | secondNum |
		| 7        | 0         |
		| 0        | 3         |
		| 0        | 0         |
