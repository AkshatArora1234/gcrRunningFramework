Feature: PreRequisite

This Feature is for generating the test data of Publish PrintFormat scenarios 2.0.0

@tag1
Scenario: Test Data 2.0 Font
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
	When Enter CodeName and Font Name
	Then click on save button

	
Scenario: Test Data 2.0 Nutritional Elements Data
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
	When Enter CodeName and Nutritional Panel
	Then click on save button
	When i search the Nutrional Panel by Name
	Then Click on Edit Button NutritionalPanel
	Then Click on the New Button
	Then Click on Nutritional Element dropdown
	When Enter the value in MeasurementsUnit
	Then Enter Value in Mask Field
	Then click on new save button


Scenario: Test Data 2.0 Tare
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
	When Enter TareCode and Name
	Then click on save button

	
Scenario: Test Data 2.0 PreSet Message
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
	When Enter PresetMessageCode Name & List
	Then click on save button

	Scenario: Test Data 2.0 ContentSymbol
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
	When Enter Code ContentSymbol & Description
	Then click on save button