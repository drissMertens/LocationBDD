Feature: Client

Scenario: A new client try to register
	Given the username Bob69, the password azerty, the name Bob, the lastname Lenon and the birthdate 01, 01, 2000
	When the client is major
	Then the client is register
	
Scenario: A new client try to register but he have less than 18 year old
	Given the username Lisa24, the password azerty, the name Lisa, the lastname Simson and the birthdate 01, 01, 2010
	When the client is not major
	Then the client is not register because he is to young