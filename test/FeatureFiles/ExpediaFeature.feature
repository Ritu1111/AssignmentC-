Feature: ExpediaFeature

@mytag
Scenario: Search for a multiCity flight
	Given I am on home
	And title of the page is Expedia Travel: Search Hotels, Cheap Flights, Car Rentals & Vacations
	Then I have clicked on flights button


Scenario: Select multi-city flights
	Given I have clicked on multi-city button
	And I have entered the first origin and destination
	When I have enterd departing date
	Then I have enterd the adult count
	And I have entered the second destination
	Then I have enterd second departing date
	When I have cliked on add another flight
	Then I have entered the third destination
	And I have enterd third departing date 


Scenario: Seprching the flight
	Then Click On the Search BUtton
	And Display the successfull message


Scenario: Trip Summary
	When ENsuring correct information of all three flights
	Then Ensuring the correct amount per person 

 Scenario: ZClosing the Browser
     Then dismis browser