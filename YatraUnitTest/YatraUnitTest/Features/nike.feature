Feature: nike
	verifying the shoe is added to cart successfully

@mytag
Scenario: Test to verify the Men shoe is added to cart
Given User launched Nike portal
When User Navigate to All Shoes from Men
Then Verify the Men shoes page is Displayed
When User sort the shoes from High to Low
And User selects Nike React Infinity Run Flyknit 2 By You shoe
And User select the size and click on Add to Bag
Then verify if selected product has been added to cart successfully