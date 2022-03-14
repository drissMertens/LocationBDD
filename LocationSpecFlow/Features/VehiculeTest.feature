Feature: VehiculeTest
Background: 
	Given following existing vehicule
	| Immatriculation | Marque | model | color | PriceReservation | PriceKilometrique | ChvFiscaux |
	| QS-541-OP       | BM-W   | X6    | Black | 530              | 26                | 9          |
	| PO-781-HG       | Renault |Clio-RS   | Jaune | 420          | 21                | 8          |

Scenario: Add new Vehicule SUV 
	Given je cree un newVehicule avec pour immatriculation "QS-541-OP", marque "BM-W", model "X6", color "Black", PriceReservation "530" €, PriceKilometrique "26"€ ChvFiscaux is "9"

	Scenario: find a Vehicule in store 
	Given the immatriculation PO-781-HG, the model Clio-RS, the ChvFiscaux 8
	When the data match
	Then the vehicule is the Renault
