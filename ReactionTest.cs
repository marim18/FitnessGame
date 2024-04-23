using System.Diagnostics;
class ReactionTest
{
    private Stopwatch stopwatch = new Stopwatch();

    public void Show()
    {
        Console.WriteLine("Welcome to the Reaction Test!");
        Console.WriteLine("Press any key to start the test.");
    }

    public void StartTest()
    {
        Console.ReadKey(true);
        Console.WriteLine("Get ready...");
        Thread.Sleep(new Random().Next(2000, 5000));
        Console.WriteLine("Go!");
        stopwatch.Start();
    }

    public void StopTest()
    {
        stopwatch.Stop();
        ShowResult((int)stopwatch.ElapsedMilliseconds);
        stopwatch.Reset();
    }

    public void ShowResult(int time)
    {
        Console.WriteLine($"Your reaction time is {time} ms.");
    }
}

/*
const int buttonPin = 2; // the number of the pushbutton pin
const int ledPin =  13; // the number of the LED pin

// variables will change:
int buttonState = 0; // variable for reading the pushbutton status
unsigned long ledOnTime = 0; // when the LED was turned on

void setup() {
  // initialize the LED pin as an output:
  pinMode(ledPin, OUTPUT);
  // initialize the pushbutton pin as an input:
  pinMode(buttonPin, INPUT);
  Serial.begin(9600); // for outputting the reaction time
}

void loop() {
  // check if it's time to start a new reaction test
  if (millis() - ledOnTime > random(5000, 10000)) {
    digitalWrite(ledPin, HIGH); // turn on the LED
    ledOnTime = millis(); // record when the LED was turned on
  }

  // read the state of the pushbutton value:
  buttonState = digitalRead(buttonPin);

  // check if the pushbutton is pressed and the LED is on
  if (buttonState == HIGH && digitalRead(ledPin) == HIGH) {
    unsigned long reactionTime = millis() - ledOnTime;
    Serial.println(reactionTime); // print the reaction time
    digitalWrite(ledPin, LOW); // turn off the LED
  }
}
*/
