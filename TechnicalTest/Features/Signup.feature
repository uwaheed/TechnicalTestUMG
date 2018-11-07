Feature: Signup
	In order to use various user specific features
	As a potential conduit user
	I want to sign up

@signup
Scenario: Create a new account
	Given I am not logged in
	When I complete the sign up form
	Then I am logged in
	And my username is displayed
	
