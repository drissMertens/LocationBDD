Feature: Client

Background: 
	Given following existing clients
	| Username	| Password	|
	| Lisa24	| azerty	|
	
Scenario: A new client try to register
	Given the username Bob69, the password azerty, the name Bob, the lastname Lenon and the birthdate 01, 01, 2000
	When the client is major
	Then the client is register
	
Scenario: A new client try to register but he have less than 18 year old
	Given the username Lisa24, the password azerty, the name Lisa, the lastname Simson and the birthdate 01, 01, 2010
	When the client is not major
	Then the client is not register because he is to young
	
Scenario: A register client try to add a licence with less than 6 month experience
	Given the username Lisa24 and the password azerty
	And the licence date 12, 01, 2022
	When the licence is less than 6 mouth experience
	Then the licence is not valide you don't have enouth experience to make location

Scenario: A register client try to add a licence with more than 6 month experience
	Given the username Lisa24 and the password azerty
	And the licence date 12, 01, 2021
	When the licence is more than 6 mouth experience
	Then the licence is valide you can make location