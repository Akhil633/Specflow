Feature: Youtube search functionality

search for a video

@scripting
Scenario: validate search functionality
	Given Open the browser
	When Enter the URL
	Then search for the video testing
	Then  say something

	@scripting
Scenario: validate search functionality1
	Given Open the browser
	When Enter the URL
	Then search for the video testing
	Then  say something that fils
