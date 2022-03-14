Feature: VehiculeTest
Background: 
	Given following existing clients
	| Immatriculation | Marque | model | color | PriceReservation | PriceKilometrique | ChvFiscaux |
	| QS-541-OP       | BM-W   | X6    | Black | 530              | 26                | 9          |
	| PO-781-HG       | Renault |Clio-RS   | Jaune | 420              | 21               | 8          |

Scenario: Add new Vehicule SUV 
	Given my immatriculation is "QS-541-OP" 
	And my marque is "BM-W"
	And my model is "X6"
	And my color is "Black"
	And PriceReservation is "530" €
	And PriceKilometrique is "26"€
	And ChvFiscaux is "9"

	Scenario: Add new Vehicule sport back 
	Given my immatriculation is "PO-781-HG" 
	And my marque is "Renault"
	And my model is "Clio-RS"
	And my color is "Jaune"
	And PriceReservation is "420" €
	And PriceKilometrique is "21"€
	And ChvFiscaux is "8"