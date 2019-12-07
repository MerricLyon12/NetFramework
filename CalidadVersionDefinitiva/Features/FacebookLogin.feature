Feature: FacebookLogin
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Facebook should login when user insert username and password
	Given I have navigated to facebook
	And I have entered user into the username field
	And I have entered password into the password field
	When I press the submit button
	Then I should see the login session
