Feature: PreRequisite2.0.1

This Feature is for generating the test data of Publish PrintFormat scenarios 2.0.1

Scenario: Test Data 2.0.1 Font
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Config page
	When User clicks on Font New Button
	When Enter Code and Name with Nutritional Font
	Then click on save button

		
Scenario: Test Data 2.0.1 Nutritional Elements Data
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Config page
	When User clicks on Nutritional Panel New Button
	When Enter CodeName and Nutritional Panel TwoZeroOne
	Then click on save button
	When i search the Nutrional Panel by Name TwoZeroOne
	Then Click on Edit Button NutritionalPanel TwoZeroOne
	Then Click on the New Button
	Then Click on Nutritional Element dropdown TwoZeroOne
	When Enter the value in MeasurementsUnit Mg
	Then Enter Value in Mask Field Updated Value
	Then click on new save button


Scenario: Test Data 2.0.1 Tare
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Config page
	When User clicks on Tare New Button
	When Enter TareCode and Name TwoZeroOne
	Then click on save button

Scenario: Test Data 2.0.1 ContentSymbol
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Config page
	When User clicks on ContentSymbol Button
	When Enter Code ContentSymbol & Description TwoZeroOne
	Then click on save button

Scenario: Test Data 2.0.1 PreSet Message
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Config page
	When User clicks on Preset New Button
	When Enter PresetMessageCode Name & List TwoZeroOne
	Then click on save button