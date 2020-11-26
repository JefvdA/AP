#define ledR1 5
#define ledY1 6
#define ledG1 7

#define ledR2 9
#define ledY2 10
#define ledG2 11

#define pushButton 2

void setup()
{
	//Begin serial
	Serial.begin(9600);
	
	//leds verkeerslicht 1 zijn OUTPUT
	pinMode(ledR1, OUTPUT);
	pinMode(ledY1, OUTPUT);
	pinMode(ledG1, OUTPUT);
	
	//leds verkeerslicht 2 zijn OUTPUT
	pinMode(ledR2, OUTPUT);
	pinMode(ledY2, OUTPUT);
	pinMode(ledG2, OUTPUT);
	
	//pushButton
	pinMode(pushButton, INPUT);
}

void loop()
{
	digitalWrite(ledR1, HIGH);
	digitalWrite(ledG2, HIGH);
	myDelay(8000);
	digitalWrite(ledG2, LOW);
	digitalWrite(ledY2, HIGH);
	myDelay(2000);
	
	digitalWrite(ledR1, LOW);
	digitalWrite(ledG1, HIGH);
	digitalWrite(ledY2, LOW);
	digitalWrite(ledR2, HIGH);
	myDelay(8000);
	
	digitalWrite(ledG1, LOW);
	digitalWrite(ledY1, HIGH);
	myDelay(2000);
	digitalWrite(ledY1, LOW);
	digitalWrite(ledR2, LOW);
}

void myDelay(unsigned long duration)
{
	unsigned long start = millis();
	
	while(millis() - start <= duration){
		int buttonState = digitalRead(pushButton);
		
		if(buttonState == HIGH && digitalRead(ledR1) == HIGH){
			digitalWrite(ledG2, LOW);
			digitalWrite(ledY2, HIGH);
			delay(2000);
			digitalWrite(ledG1, HIGH);
			digitalWrite(ledR1, LOW);
			digitalWrite(ledY2, LOW);
			digitalWrite(ledR2, HIGH);
			delay(8000);
			digitalWrite(ledG1, LOW);
			digitalWrite(ledY1, HIGH);
			delay(2000);
			digitalWrite(ledR1, HIGH);
			digitalWrite(ledY1, LOW);
			digitalWrite(ledG1, LOW);
			digitalWrite(ledR2, LOW);
			digitalWrite(ledY2, LOW);
			digitalWrite(ledG2, HIGH);
		}
	}
}
