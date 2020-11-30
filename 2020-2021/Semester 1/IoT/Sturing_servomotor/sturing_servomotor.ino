// Include the Servo library
#include <Servo.h>

// Define pins
#define servoPin 09

#define potentioMeterPin A0

// Setup servo
Servo servo;

void setup()
{
	// Start serial connectie
	Serial.begin(9600);

	// Attach servo met de juiste pin
	servo.attach(servoPin);

	// PotentioMeter is INPUT
	pinMode(potentioMeterPin, INPUT);
}

void loop()
{
	// Steek de waarde (0 - 1023) van de potentioMeter in variabele y
	int y = analogRead(potentioMeterPin);
	Serial.println(y); // Print waarde (0 - 1023) van potentioMeter in serial monitor

	int x = map(y, 0, 1023, 0, 180); // Zet waarde potentioMeter om in graden
	Serial.println(x);	// Print gradenverandering in serial monitor

	servo.write(x); // Verplaats de servo met x graden, x eerder berekent
}
