Feature: Validate broadband offers
	As a user I would like to access quick links Telenor Home Page
	So as to fetch broadband offers

@Test
Scenario Outline: Access Quick Links on Home Page and verify offers 
	Given I go to home page url 'https://www.telenor.se/'
	When I click on quick links on home page
	And Enter '<search_area>' and '<apartment_number>'
	Then Validate that atleast one offer is displayed

Examples:
	| search_area            | apartment_number |
	| Storgatan 1, Uppsala   | 0001             |
	| Storgatan 1, Stockholm | 1001             |