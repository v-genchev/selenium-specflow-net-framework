Feature: Test feature
	Trying C#, NUnit, SpecFlow automation coming from Java background

Scenario: Navigate to Documentation Page

	Given I start the browser
	And I navigate to Progress home page
	When I hover over SUPPORT menu
	And I select Documentation submenu
	Then I verify current page title contains Documentation & User Assistance
	And I stop the browser
			