Feature: SnakeGame
Play to the game

Scenario: go to game page 
	Given user is on home page
	And first username is set
	And second username is set
	When user clicks on add button
	Then user is at game page "http://localhost/game"

Scenario: play to the game
	Given user is on game page "http://localhost/game"
	When user play and one player win
	Then user is at endgame page "http://localhost/endgame"
	