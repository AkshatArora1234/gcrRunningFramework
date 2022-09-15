Feature: PublishPrintFormatWithExistingCode
	Simple calculator for adding two numbers

@mytag
Scenario: Verify Print Format with Existing same code as Store
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	#Then HQ homepage should be displayed
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	When User clicks on Tab Print Format
	Then Print Format Page should be displayed
	Then Click on the New Button
	When User Enters the Code and PrintFormat
	When Enter the Value of Print Name Nicebiscits
	When Click on Edit Button
	When Check the required text boxes
	Then Check the Content Symbol 
	When Click on Add Section
	Then Click on Font Dropdown
	Then Add Desc to font
	Then Add another new nutritional Panel to another section latest
	Then Save the font with data
	Then Close the font
	#Then Publish the PF
	#Then Select the Store
	When Clear the PrintformatName
	When Enter the Value of Print Name Nicebiscits
	When Click on Edit Button
	
	When Change the PF name to Popcorn, also uncheck 'product life' only.Take any nutritional font and uncheck 'Nutritional' and check 'Enable copy'.
	Then Check the Content Symbol 
	
	Then verify user can Change non nutritional section to the nutritional by adding a nutritional font and description
	Then Change Nutritional to Non Nutritional
	Then Save the font with data
	Then Close the font
	When Clear the PrintformatName
	When Searches for PrintFormat
	When User clicks on Tab Config page
	When i search the Font by name
	When User Deletes the font added to PF
	When User Verify the font message
	When User clicks on Tab Print Format
	Then Publish the PF
	Then Select the Store
	And user navigates to SR application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Login button of SR app
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then navigate to verify Tare '<searchcodeTare>' and '<verifytextTare>'
    Then navigate to verify Content Symbol '<searchcodeCS>' and '<verifytextCS>'
	Then navigate to verify Preset Messages '<searchcodePM>' and '<verifytextPM>'
	Then navigate to verify Print Format '<searchcode>' and '<verifytext>'
    

     Examples: 
	| searchcode | verifytext      | searchcodeCS| verifytextCS    | searchcodePM | verifytextPM     | searchcodeTare  | verifytextTare      |
	| 12         | Popcorn2        | 39          | ML              | 46           | Contains preservatives	| 45	   | RicePowder	         |	
    




@mytag
Scenario: Publish PF to Store
	Given user navigates to HQ application
    When enter valid '<username>', '<hqpassword>'
    And Clicks on Log In button
    When user create a new batch
    When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Scale Configuration in the Search Box
    Then Scale Configuration Item should be displayed on the Menu
    When User Selects the Scale Configuration
    #Then Scale Configuration Page should be displayed
    When User clicks on Tab Print Format
    Then Click on the New Button
    When Enter the CodeName and PrintFormat
    When Enter the Value of Print Name
    Then Click on Edit Button
    When Check the required text boxes
    Then Check the Content Symbol
    When Click on Add Section
    Then Click on Font Dropdown
    Then Add Desc to font
    Then Save the font with data
    Then Close the font
    Then Publish the PF
    Then Select the Store
    And user navigates to SR application
    When enter valid '<username>', '<hqpassword>'
    And Clicks on Login button of SR app
    When User clicks on the Left Menu
    Then menu should be displayed
    When User enters Scale Configuration in the Search Box
    Then Scale Configuration Item should be displayed on the Menu
    Then navigate to verify Tare '<searchcodeTare>' and '<verifytextTare>'
    Then navigate to verify Content Symbol '<searchcodeCS>' and '<verifytextCS>'
    Then navigate to verify Preset Messages '<searchcodePM>' and '<verifytextPM>'
    Then navigate to verify Print Format '<searchcode>' and '<verifytext>'
Examples:
    | searchcode | verifytext      | searchcodeCS| verifytextCS    | searchcodePM | verifytextPM     | searchcodeTare  | verifytextTare      |
    | 12         | OpenSansBiscuits| 27          | G               | 67           | Minerals Qty     | 10              | Penuts              |  


@mytag
Scenario: Edit PF
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When user create a new batch
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Print Format
	Then Click on the New Button
	When Enter the CodeName and PrintFormat new
	When Enter the Value of Print Name OpenSanBiscuit1
	Then Click on Edit Button new PF
	When Check the required text boxes
	When Click on Add Section
	Then Click on Font Dropdown
	Then Add Desc to font
	And check the Manadatory & Fixed Width check box
	And configure the row & Characters values
	Then check a new nutritional Panel can be added to another section
	Then Click Support Basic Mode Header and Table
	Then Save the font with data
	Then Close the font
	




@mytag
Scenario Outline: Publish PF existing with same name as in store
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	When user create a new batch
    When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User clicks on Tab Print Format
	Then Click on the New Button
	When user enter new PF code and name and Publish PF
	And user search and select the printformat code
	Then user change the PF code and update the checkboxes
	And verify Content Symbol is automatically checked on checking Content
	And verify user can Change non nutritional section to the nutritional by adding a nutritional font and description
	And Add another new nutritional Panel to another section
	And Save and close the PF
    Then select a scale item
	And add the PF and ContentSymbol 
	And Save item
	Then navigate to the configuration page to edit the content symbol assigned to item
	And Verify that the change is reflected in Item's scale tab
	And Delete the second panel added from the configuration page
	And Publish the PF to a second store where PF exists with same name
	And user navigates to SR application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Login button of SR app
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then navigate to verify Tare '<searchcodeTare>' and '<verifytextTare>'
    Then navigate to verify Content Symbol '<searchcodeCS>' and '<verifytextCS>'
	Then navigate to verify Preset Messages '<searchcodePM>' and '<verifytextPM>'
	Then navigate to verify Print Format '<searchcode>' and '<verifytext>'
    #Testdata update to actual one
	And navigate back to configuration page to change the contentSymbol back
	When User clicks on Nutritional Panel New Button
	When Enter CodeName and Nutritional Panel for second Testdata TwoZeroTwo
	Then click on save button
	When I search the second Nutrional Panel by Name Testdata TwoZeroTwo
	Then Click on Edit Button NutritionalPanel TwoZeroOne
	Then Click on the New NutritionalPanel Element Button
	Then Click on second Nutritional Element dropdown Testdata TwoZeroTwo
	When Enter the value in MeasurementsUnit g
	Then Enter Value in second Mask Field
	Then click on save and close button Nutritional Panel Element
	And Navigate to PF tab

     Examples: 
	| searchcode | verifytext      | searchcodeCS| verifytextCS    | searchcodePM | verifytextPM     | searchcodeTare  | verifytextTare      |
	| 21         | Popcorn         | 18          | KGTest          | 47           | Contains fat     | 46              | FriedRicePowder     |	
    



    



