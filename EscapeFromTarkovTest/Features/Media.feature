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


	
	