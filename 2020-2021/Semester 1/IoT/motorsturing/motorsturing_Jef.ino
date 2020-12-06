// Define pins
#define button_1 03
#define button_2 04
#define button_3 05
#define button_4 06

#define MOTOR_1_PWM_PIN 10
#define MOTOR_1_DIR_PIN 12

#define MOTOR_2_PWM_PIN 11
#define MOTOR_2_DIR_PIN 13

#define SLIDER_PIN A0

void setup()
{
	// Begin serial connection
	Serial.begin(9600);

	// Motor pins zijn output
	pinMode(MOTOR_1_PWM_PIN,OUTPUT);
	pinMode(MOTOR_1_DIR_PIN,OUTPUT);

	pinMode(MOTOR_2_PWM_PIN,OUTPUT);
	pinMode(MOTOR_2_DIR_PIN,OUTPUT);

	// Buttons zijn input
	pinMode(button_1, INPUT);
	pinMode(button_2, INPUT);
	pinMode(button_3, INPUT);
	pinMode(button_4, INPUT);

	// Analog slider is input
	pinMode(SLIDER_PIN, INPUT);
}

void loop()
{
	// Leest de waarde van de analog slider, en stuurt deze naar de serial monitor
	int speed = analogRead(SLIDER_PIN);
	Serial.println("Analog Read Value : ");
	Serial.println(speed);
	// Zet de waarde van de analog slider (0-1024) om naar 0-255 zodat dit als snelheid voor de motors kan gebruikt worden
	speed = map(speed, 0, 1024, 0, 255);
	Serial.println("Speed Value: ");
	Serial.println(speed); // Opnieuw even naar serial monitor sturen
	
	/*
		button_1 = CCW - CCW
		button_2 = CW - CW
		button_3 = CCW - CW
		button_4 = CW - CCW
	*/
	if(digitalRead(button_1) == HIGH) // Als knop 1 ingedrukt is
	{		
		// Motor 1 = CCW
		analogWrite(MOTOR_1_PWM_PIN,speed);
		digitalWrite(MOTOR_1_DIR_PIN,HIGH);
		// Motor 2 = CCW
		analogWrite(MOTOR_2_PWM_PIN,speed);
		digitalWrite(MOTOR_2_DIR_PIN,HIGH);
	}
	else if(digitalRead(button_2) == HIGH) // Als knop 2 ingedrukt is
	{
		// Motor 1 is CW
		analogWrite(MOTOR_1_PWM_PIN,speed);
		digitalWrite(MOTOR_1_DIR_PIN,LOW);
		// Motor 2 is CW
		analogWrite(MOTOR_2_PWM_PIN,speed);
		digitalWrite(MOTOR_2_DIR_PIN,LOW);
	}
	else if(digitalRead(button_3) == HIGH) // Als knop 3 ingedrukt is
	{
		// Motor 1 = CCW
		analogWrite(MOTOR_1_PWM_PIN,speed);
		digitalWrite(MOTOR_1_DIR_PIN,HIGH);
		// Motor 2 = CW
		analogWrite(MOTOR_2_PWM_PIN,speed);
		digitalWrite(MOTOR_2_DIR_PIN,LOW);
	}
	else if(digitalRead(button_4) == HIGH) // Als knop 4 ingedrukt is
	{
		// Motor 1 = CW
		analogWrite(MOTOR_1_PWM_PIN,speed);
		digitalWrite(MOTOR_1_DIR_PIN,LOW);
		// Motor 2 = CCW
		analogWrite(MOTOR_2_PWM_PIN,speed);
		digitalWrite(MOTOR_2_DIR_PIN,HIGH);
	}
	else // Als geen knop ingedrukt is
	{
		// We laten de motors stoppen door hun snelheidspin op 0 te zetten
		analogWrite(MOTOR_1_PWM_PIN, 0);
		analogWrite(MOTOR_2_PWM_PIN, 0);
	}
}