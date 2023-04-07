Feature: Swag Labs

This feaure is about purchasing a procuct from swag labs

@TC001
Scenario: TC001:Login into Swag Labs and validate home page
	Given The user is logged into application using username 'standard_user' and password 'secret_sauce'
	When Click on Login Button
	Then Verify cart Icon in home page 'true'
	    