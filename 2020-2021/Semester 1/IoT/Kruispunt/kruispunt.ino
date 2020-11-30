//Pins definen
#define ledR1 5
#define ledY1 6
#define ledG1 7

#define ledR2 9
#define ledY2 10
#define ledG2 11

#define pushButton 2

void setup()
{
	// Begin serial
	Serial.begin(9600);

	// Leds verkeerslicht 1 zijn OUTPUT
	pinMode(ledR1, OUTPUT);
	pinMode(ledY1, OUTPUT);
	pinMode(ledG1, OUTPUT);

	// Leds verkeerslicht 2 zijn OUTPUT
	pinMode(ledR2, OUTPUT);
	pinMode(ledY2, OUTPUT);
	pinMode(ledG2, OUTPUT);

	// pushButton is INPUT
	pinMode(pushButton, INPUT);
}

// Main loop voor verkeerslichtregeling
void loop()
{
	digitalWrite(ledR1, HIGH);	// Hoofdweg: rood licht aan
	digitalWrite(ledG2, HIGH);	// Zijweg: groen licht aan
	myDelay(8000); // myDelay() wacht 8s en test op pushButton
	digitalWrite(ledG2, LOW);	// Zijweg: groen licht uit
	digitalWrite(ledY2, HIGH);	// Zijweg: geel licht aan
	myDelay(2000); // myDelay() wacht 2s en test op pushButton

	digitalWrite(ledR1, LOW);	// Hoofdweg: rood licht uit
	digitalWrite(ledG1, HIGH);	// Hoofdweg: groen licht aan
	digitalWrite(ledY2, LOW);	// Zijweg: geel licht uit
	digitalWrite(ledR2, HIGH);	// Zijweg: rood licht aan
	myDelay(8000);	// myDelay() wacht 8s en test op pushButton

	digitalWrite(ledG1, LOW);	// Hoofdweg: groen licht uit
	digitalWrite(ledY1, HIGH);	// Hoofdweg: geel licht aan
	myDelay(2000);	// myDelay() wacht 2s en test op pushButton
	digitalWrite(ledY1, LOW);	// Hoofdweg: geel licht uit
	digitalWrite(ledR2, LOW);	// Zijweg: rood licht uit
}

/*
	Functie myDelay()
		-> parameter "duration" is de tijd dat we wachten
		
		-> Gebruiken dit i.p.v gewone delay(), zo kunnen we tijdens het wachten checken op de pushButton
*/
void myDelay(unsigned long duration)
{
	unsigned long start = millis(); // Start tijd wanneer myDelay() wordt uitgevoerd

	// While loop voor "duration" aantal seconden
	while(millis() - start <= duration){
		int buttonState = digitalRead(pushButton); // Input van pushButton in variabele steken
	
		// Check of de pushButton is ingedrukt
		if(buttonState == HIGH){
			// Via serial laten weten dat er werdt gedrukt op de pushButton
			Serial.println("Er werdt op de voorrangsknop gedrukt!");

			// Check of het licht op hoofdweg op rood staat -> alleen dan lichten aanpassen
			if(digitalRead(ledR1) == HIGH){
				// Via serial laten weten dat het groen gaat worden op hoofdweg
				Serial.println("Bus op hoofdweg krijgt voorang...");
				
				// Verkeerslichtregeling met voorang voor bussen
				digitalWrite(ledG2, LOW);	// Zijweg: groen licht uit
				digitalWrite(ledY2, HIGH);	// Zijweg: geel licht aan
				delay(2000);	// delay() wacht 2s
				digitalWrite(ledG1, HIGH);	// Hoofdweg: groen licht aan
				digitalWrite(ledR1, LOW);	// Hoofdweg: rood licht uit
				digitalWrite(ledY2, LOW);	// Zijweg: geel licht uit
				digitalWrite(ledR2, HIGH);	// Zijweg: rood licht aan
 				delay(8000);	// delay() wacht 8s
				digitalWrite(ledG1, LOW);	// Hoofdweg: groen licht uit
				digitalWrite(ledY1, HIGH);	// Hoofdweg: geel licht aan
				delay(2000);	// delay() wacht 2s
				digitalWrite(ledR1, HIGH);	// Hoofdweg: rood licht aan
				digitalWrite(ledY1, LOW);	// Hoofdweg: geel licht uit
				digitalWrite(ledR2, LOW);	// Zijweg: rood licht uit
				digitalWrite(ledG2, HIGH);	// Zijweg: groen licht aan
				delay(10000);	// delay() wacht 10s
			}
		}
	}
}
