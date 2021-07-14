Feature: Run video

@PlayVideo
Scenario: Open webpage and play video
	Given I open media page
	And Select first video
	When Play is pressed
	Then Stop video button contains text "Pause" 
	