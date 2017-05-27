int odczytanaWartosc;
int odczytanaWartosc2;
int odczytanaWartosc3;
int odczytanaWartosc4;
void setup() {
  pinMode(A0, OUTPUT);
  pinMode(A1, OUTPUT);
  pinMode(A2, OUTPUT);
  pinMode(A3, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  digitalWrite(A0, HIGH);
  digitalWrite(A1, HIGH);
  digitalWrite(A2, HIGH);
  digitalWrite(A3, HIGH);
  odczytanaWartosc = analogRead(A0);
  odczytanaWartosc2 = analogRead(A1);
    odczytanaWartosc3 = analogRead(A2);
  odczytanaWartosc4 = analogRead(A3);//Odczytujemy wartość napięcia
  Serial.println(odczytanaWartosc);//Wysyłamy
  Serial.println(odczytanaWartosc2);
   Serial.println(odczytanaWartosc3);
    Serial.println(odczytanaWartosc4);//ją do terminala
  delay(1000);
  digitalWrite(A0, 0);
  digitalWrite(A1, 0);
   digitalWrite(A2, 0);
  digitalWrite(A3, 0);
  odczytanaWartosc = analogRead(A0);
  odczytanaWartosc2 = analogRead(A1);//Odczytujemy wartość napięcia
  Serial.println(odczytanaWartosc);
  Serial.println(odczytanaWartosc2);//Wysyłamy ją do terminala
  delay(1000);
}
