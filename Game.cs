using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino; //idk which of these we actually need they were in a template i found

//com 8

int redPin = 17;
int greenPin = 16;
int bluePin = 5;
int ButtonPin = 18;

void setup()
{
    pinMode(redPin, OUTPUT);
    pinMode(greenPin, OUTPUT);
    pinMode(bluePin,OUTPUT);
    Serial.begin(115200); //idk what this does
}
void Program (){
    while (numberoflights < count)
    {
        int random = new RandomNumberGenerator;
        sequence.Add(random);
    }
}

void buttonPressed()
{
    //do stuff
    int value = timer;
    timer.stop();
}

class lights
{
    int redPin;
    int greenPin;
    int bluePin;
    int id;

    Light1 = new lights{
    this.ID = 1;
    this.redPin = 17;
    this.greenPin = 16;
    this.bluePin = 5;
    this.ButtonPin = 18; }

    void Lightup(lights light)
    {
        analogWrite(redPin, 255);
        Timer timer = new timer;
        timer.activate();
    }
}