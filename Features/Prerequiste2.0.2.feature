Feature: PreRequisite2.0.2

This Feature is for generating the test data of Publish PrintFormat scenarios 2.0.2

Scenario: TestData 2.0.2 for Font
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	#Font
	When User clicks on Font New Button
	When Enter the Code and Name for Testdata TwoZeroTwo
	Then click on save button
	And search for the font
	And click the Nutritional Font as yes 
	When User clicks on Font New Button
	When Enter the Code and Name for second font Testdata TwoZeroTwo
	Then click on save button
	And search for the second font entered
	And click the Nutritional Font as yes 

Scenario: TestData 2.0.2 for ContentSymbol
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	#ContentSymbol
	When User clicks on ContentSymbol Button
	When Enter ContentSymbol & Description for Testdata TwoZeroTwo
	Then click on save button


Scenario: TestData 2.0.2 for NutritionalPanel
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	#NutritionalPanel
	When User clicks on Nutritional Panel New Button
	When Enter CodeName and Nutritional Panel for Testdata TwoZeroTwo
	Then click on save button
	When User clicks on Nutritional Panel New Button
	When Enter CodeName and Nutritional Panel for second Testdata TwoZeroTwo
	Then click on save button
	When I search the Nutrional Panel by Name Testdata TwoZeroTwo
	Then Click on Edit Button NutritionalPanel TwoZeroOne
	Then Click on the New NutritionalPanel Element Button
	Then Click on Nutritional Element dropdown TwoZeroOne
	When Enter the value in MeasurementsUnit Mg
	Then Enter Value in Mask Field Updated Value
	Then click on save and close button Nutritional Panel Element
	When I search the second Nutrional Panel by Name Testdata TwoZeroTwo
	Then Click on Edit Button NutritionalPanel TwoZeroOne
	Then Click on the New NutritionalPanel Element Button
	Then Click on second Nutritional Element dropdown Testdata TwoZeroTwo
	When Enter the value in MeasurementsUnit g
	Then Enter Value in second Mask Field
	Then click on save and close button Nutritional Panel Element
	
Scenario: Test Data 2.0.2 for Tare 
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
    #Tare
	When User clicks on Tare New Button
	When Enter TareCode and Name for TwoZeroTwo
	Then click on save button

Scenario: Test Data 2.0.2 for PreSet Message
    Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then User click on Scale Configuration Item should be displayed on the Menu
	#PresetMessage
	When User clicks on Preset New Button
	When Enter PresetMessageCode Name & List for TwoZeroTwo
	Then click on save button