// Include I2C library
#include<DFRobot_LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x20, 16, 2); //I2C adres 0x20, 16 kolommen en 2 rijen

// Pins definen
#define pushButton1 03
#define pushButton2 04
#define pushButton3 05
#define pushButton4 06

#define MOTOR1_PWM 10
#define MOTOR1_DIR 12
#define MOTOR2_PWM 11
#define MOTOR2_DIR 13

void setup()
{
	// Starten van serial monitor
	Serial.begin(9600);

	// Initialiseer lcd
	lcd.init();
	lcd.backlight();

	// pushButtons zijn INPUT
	pinMode(pushButton1, INPUT);
	pinMode(pushButton2, INPUT);
	pinMode(pushButton3, INPUT);
	pinMode(pushButton4, INPUT);

	// Motor pins zijn OUTPUT
	pinMode(MOTOR1_PWM, OUTPUT);
	pinMode(MOTOR1_DIR, OUTPUT);
	pinMode(MOTOR2_PWM, OUTPUT);
	pinMode(MOTOR2_DIR, OUTPUT);

	// Bij begin gaat robot vooruit, dit ook doorgeven aan LCD scherm
	digitalWrite(MOTOR1_DIR, HIGH);
	digitalWrite(MOTOR2_DIR, HIGH);
	// LCD display instellen
	lcd.setCursor(0, 0);
	lcd.print("Vooruit rijden");
}

void loop()
{
	int speed = 127; // SPEED variable voor snelheid van het robotje (0-255).

	// Zet snelheid motoren naar SPEED
	analogWrite(MOTOR1_PWM, speed);
	analogWrite(MOTOR2_PWM, speed);

/*
		pushButton1 = vooruit -> CCW - CWW
		pushButton2 = achteruit -> CW - CW
		
		pushButton3 = links -> CW - CCW
		pushButton4 = rechts -> CCW - CW
	*/	
	if(digitalRead(pushButton1) == HIGH) // TRUE als pushButton1 ingedrukt wordt
	{
		// Motor1 & Motor2 CCW
		digitalWrite(MOTOR1_DIR, HIGH);
		digitalWrite(MOTOR2_DIR, HIGH);

		//LCD display instellen
		lcd.clear(); // LCD display leegmaken
		lcd.setCursor(0, 0);
		lcd.print("Vooruit rijden");
	}
	else if(digitalRead(pushButton2) == HIGH) // TRUE als pushButton2 ingedrukt wordt
	{
		// Motor1 & Motor2 CW
		digitalWrite(MOTOR1_DIR, LOW);
		digitalWrite(MOTOR2_DIR, LOW);

		//LCD display instellen
		lcd.clear(); // LCD display leegmaken
		lcd.setCursor(0, 0);
		lcd.print("Achteruit rijden");
	}
	else if(digitalRead(pushButton3) == HIGH) // TRUE als pushButton3 ingedrukt wordt
	{
		// Motor1 CW & Motor2 CCW
		digitalWrite(MOTOR1_DIR, LOW);
		digitalWrite(MOTOR2_DIR, HIGH);

		//LCD display instellen
		lcd.clear(); // LCD display leegmaken
		lcd.setCursor(0, 0);
		lcd.print("Links draaien");
	}
	else if(digitalRead(pushButton4) == HIGH) // TRUE als pushButton4 ingedrukt wordt
	{
		// Motor1 CCW & Motor2 CW
		digitalWrite(MOTOR1_DIR, HIGH);
		digitalWrite(MOTOR2_DIR, LOW);

		//LCD display instellen
		lcd.clear(); // LCD display leegmaken
		lcd.setCursor(0, 0);
		lcd.print("Rechts draaien");
	}
}
