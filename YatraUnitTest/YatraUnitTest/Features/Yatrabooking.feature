Feature: Yatrabooking
	verifying by selecting to and from destination and redirecting page

Scenario: Test to verify that user redirects to airasia detailspage
Given User Launched airasia portal
When User selects To and From destination 
And User search for Flights
And User selects any flight 
And User click on continue
Then Verify user redirect to guest details page

