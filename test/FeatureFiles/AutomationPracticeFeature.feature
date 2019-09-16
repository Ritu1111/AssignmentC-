Feature: Sign in

@mytag
Scenario Outline: Sign in with empty email and password
	Given I am on home page
	When title of home page is My Store
	Then I click on Sign in option 
	When I enter "<user>" and "<pass>"
	When I click on signIn button
	Then empty credentials appears

	Examples: 
	| user         | pass     |
	|              |          |

	Scenario Outline: Sign in with empty password
	Given I am on home page
	When title of home page is My Store
	Then I click on Sign in option 
	When I enter "<user>" and "<pass>"
	When I click on signIn button
	Then empty password appears

	Examples: 
	| user         | pass     |
	|test@gmail.com|          |

	Scenario Outline: Sign in with empty email
	Given I am on home page
	When title of home page is My Store
	Then I click on Sign in option 
	When I enter "<user>" and "<pass>"
	When I click on signIn button
	Then empty emai appears

	Examples: 
	| user         | pass     |
	|              |qwertyuio |

	Scenario Outline: Sign in with invalid email and password
	Given I am on home page
	When title of home page is My Store
	Then I click on Sign in option 
	When I enter "<user>" and "<pass>"
	When I click on signIn button
	Then invalid credentials appears

	Examples: 
	| user         | pass     |
	|test@gmail.com|qwertyuio |