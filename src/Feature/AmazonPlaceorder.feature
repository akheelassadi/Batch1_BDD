Feature: AmazonPlaceorder
	Verify user is able to place the order, make the payment and check the orders page

Background: The user is logged in successfully to the amazon website

@mytag
Scenario Outline: Verify user is able to add the product to the cart
	When The user searches for the <product>
	 And The user selects the product
	And The user adds the product to the cart
	And The user navigates to the Add to cart page
	Then The user verifies that the product is added to the cart
	Examples: 
	| product     |
	| Sony camera |

Scenario: Verify user is able to make the payment and place the order
	When The user navigates to the Add to cart page 
	 And The user clicks on the Buy now button
	And The user chooses the mode of payment
	And The user confirms the order
	Then The user verifies that the order is placed successfully

Scenario: Verify user is able to check the orders page
	When The user navigates to the Orders page 
	 Then the user shall see the list of orders placed
