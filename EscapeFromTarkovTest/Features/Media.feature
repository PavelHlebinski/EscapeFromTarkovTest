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

	
	