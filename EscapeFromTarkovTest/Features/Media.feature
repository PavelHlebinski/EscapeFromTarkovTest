Feature: EscapeFromTarkov Tests

@EscapeFromTarkovSmoke
Scenario: Open WebPage and play video
	Given Open page "https://www.escapefromtarkov.com/"
	And Select first video
	When Play is pressed
	Then Stop video button contains text "Pause" 
	