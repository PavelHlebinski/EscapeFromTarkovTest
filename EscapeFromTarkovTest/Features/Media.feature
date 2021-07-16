Feature: EscapeFromTarkov Tests

@RunVideo
Scenario: Open WebPage and play video
	Given Open page "https://www.escapefromtarkov.com/"
	And Select first video
	When Play is pressed
	Then Stop video button contains text "Pause" 

@CheckPrice
Scenario: Checking that the book is cost 260
	Given Open books page "https://tarkovmerchstore.com/Books"		
	Then Book "Хозяин ночи" costs "260"

@СheckRating
Scenario: Sort players by kill and check their lvl
	Given Open rating page "https://www.escapefromtarkov.com/rating"
	When Sort by kills
	Then Shown 100 rows
	And Player lvl is valid

@CheckErrorPage
Scenario: Open link about error and check the opened page is correct
	Given Open support page "https://www.escapefromtarkov.com/support"
	And Find "Error 208"
	When Open information about error
	Then Opened correct page about "Error 208"

@CHeckRegistrationAlert
Scenario: Сheck the need for registration for pre-order 
	Given Open pre-order page "https://www.escapefromtarkov.com/preorder-page"
	When Try to get pre-order without registration
	Then Registration alert is shown "YOU NEED TO REGISTER FIRST, AND THEN LOG IN TO YOUR ACCOUNT."

@CheckAK-74MCaliber
Scenario: Check caliber for AK-74M 
	Given Open wiki page "https://escapefromtarkov.fandom.com/wiki/Escape_from_Tarkov_Wiki"
	And Find "AK-74M" card
	Then Caliber is equal "5.45x39mm"



	
	