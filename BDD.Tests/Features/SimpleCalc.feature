Feature: SimpleCalc
	Makes simple calculations

@Numbers
Scenario: Sum 2 nums
	Given the first num is 10
	And the second num is 22
	When the two nums are added
	Then the result of sum should be 32

Scenario: Substract 2 nums
	Given the first num is 10
	And the second num is 2
	When the two nums are substracted
	Then the result of substract should be 8