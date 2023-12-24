
//LED KONTROL

/*void setup() {
  pinMode(2, OUTPUT); // alt kat
  pinMode(3, OUTPUT); // üst kat
  Serial.begin(9600);
}

void loop() {
  if (Serial.available() > 0) {
    String receivedDataString = Serial.readStringUntil('\n');
    int receivedData = receivedDataString.toInt();
    if (receivedData == 1) // Bütün ışıkları aç
    {
      digitalWrite(2, HIGH);
      digitalWrite(3, HIGH);
    }
    else if (receivedData == 2) // Bütün ışıkları kapat
    {
      digitalWrite(2, LOW);
      digitalWrite(3, LOW);
    }
    else if (receivedData == 3) // alt katın ışıklarını aç
    {
      digitalWrite(2, HIGH);
    }
    else if (receivedData == 4) // alt katın ışıklarını kapat
    {
      digitalWrite(2, LOW);
    }
    else if (receivedData == 5) // üst katın ışıklarını aç
    {
      digitalWrite(3, HIGH);
    }
    else if (receivedData == 6) // üst katın ışıklarını kapat
    {
      digitalWrite(3, LOW);
    }
  }

  check();

  delay(500);
}

void check() {
  int lowerFloorStatus = digitalRead(2); // Alt kat LED durumu
  int upperFloorStatus = digitalRead(3); // Üst kat LED durumu

  String statusMessage = String(lowerFloorStatus) + String(upperFloorStatus);
  Serial.println(statusMessage);
}*/



// DC MOTOR KONTROL

/*
int motorPin = 9; // DC motorun bağlı olduğu pin

void setup() {
  pinMode(motorPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available() > 0) {
    char receivedChar = Serial.read();
    if (receivedChar == '1') {
      startMotor();
      Serial.println("Motor çalisiyor.");
    } else if (receivedChar == '0') {
      stopMotor();
      Serial.println("Motor durdu.");
    }
  }
}
void startMotor() {
  digitalWrite(motorPin, HIGH);
}
void stopMotor() {
  digitalWrite(motorPin, LOW);
}
*/


// DHT11 SENSÖRÜ KULLANARAK SICAKLIĞI ÖLÇ VE GÖNDER

/*#include <DHT.h>

#define DHTPIN 2      //(2 numaralı pin)
#define DHTTYPE DHT11 // Sensör tipi

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  dht.begin();
}

void loop() {
  delay(2000); 

  float temperature = dht.readTemperature();

  if (!isnan(temperature)) {
    Serial.print("Sicaklik: ");
    Serial.println(temperature);

    // C# uygulamasına sıcaklık verisini gönder
    Serial.print(temperature);
    Serial.print('\n');
  } else {
    Serial.println("Sicaklik okunamadi.");
  }
}*/
