# -Lighting-control-through-CAN-bus

# PL:
Sterowanie oświetleniem za pomocą magistrali CAN
1.	Założenia i cele projektu

Tematem projektu będzie implementacja sterownika oświetleniem poprzez magistralę CAN. 
Do realizacji wykorzystany  będzie:
1.	mikrokontroler Arduino Leonardo, 
2.	dwa Arduino UNO, 
3.	trzy moduły CAN SPI MCP2515 zawierające kontroler MCP2515 oraz CAN transceiver TJA1050 pozwalające połączyć mikrokontroler do magistrali CAN,
4.	8 diod LED (dwie diody koloru białego, symulujące światła przednie samochodu, cztery koloru pomarańczowego, symulujące kierunkowskazy oraz dwie koloru czerwonego symulujące światła z tyłu pojazdu)
5.	czujnik natężenia światła, np.: BH1750 (będzie połączony z mikrokontrolerem i w zależności od natężenia światła będzie zapalał/gasił światła z przodu pojazdu)

W celu sterowania oświetleniem wykonamy odpowiednią aplikację na komputer PC w technologii .NET, w której będzie można włączyć każdą z diod lub np. uruchomić kierunkowskazy. W celu zaprogramowania powyższej aplikacji użyliśmy środowiska Microsoft Visual Studio 2015 oraz języka programowania C#.


2.	Plan pracy

1.	Zakup niezbędnych elementów
2.	Konfiguracja mikrokontrolera Arduino Leonardo do łatwego uruchamiania przykładowych programów oraz konfiguracja Arduino UNO.
3.	Ustanowienie połączenia pomiędzy Leonardo i UNO, bez magistrali CAN
4.	Zaprogramowanie mikrokontrolerów, tak by odpowiednio świeciły diodami (migały „kierunkowskazami”, zapalanie i wyłączanie świateł „z przodu i z tyłu”)
5.	Utworzenie magistrali CAN i stworzenie komunikacji przez tą magistralę.
6.	Zintegrowanie komunikacji poprzez sieć CAN ze świeceniem lampkami.
7.	Dodanie komunikacji w obie strony, tak, by Leonardo mogło odbierać informacje od UNO (np. o spalonej żarówce)
8.	Podłączenie czujnika światła pod Arduino UNO i wykorzystanie go do obsługi trybu automatycznego.
9.	Stworzenie komunikacji Leonardo z laptopem za pomocą portu szeregowego.
10.	 Napisanie aplikacji z interfejsem użytkownika do obsługi zapalania i gaszenia diod LED.

3.	Podsumowanie:

Wykonując ten projekt poznaliśmy  wiele nowych technologii. Zapoznaliśmy się z działaniem i obsługą magistrali CAN, obsługą czujnika natężenia światła BH1750, komunikacją pomiędzy kilkoma mikrokontrolerami oraz poznaliśmy możliwości jakie daje połączenie mikrokontrolera oraz Laptopa poprzez port szeregowy. Napotkaliśmy także wiele problemów. Pierwszym był błędny zakup płytek Arduino Mini Pro z mikroprocesorem ATmega328 ze względu na przestarzałość tej technologii i nie zgodność przykładowo z Windowsem 10, na którym pracowaliśmy, do tego niestety ta płytka była podłączona przez programator, który nie posiadał automatycznego „reseta”, co spowodowało, że postanowiliśmy wymienić te płytki na nowocześniejsze Arduino UNO. Kolejnym problemem była początkowo niewystarczająca wiedza z zakresu działania magistrali CAN. Kupiliśmy transceivery CAN, które okazały się niewystarczające, ponieważ do obsługi tej szyny potrzebne są także kontrolery CAN, niestety zmusiło nas to do zakupu modułów CAN z wbudowanymi kontrolerem i transceiverem. Naszczęście w końcu udało nam się nawiązać komunikację wykorzystując tę magistralę i krok po kroku skończyliśmy nasz projekt.
Myślę, że dzięki projektowi lepiej poznaliśmy mechanizmy jakie pozwalają przesyłać dane do sterownika głównego w samochodach i w przyszłości można by było rozbudować nasz projekt o dodatkowe funkcjonalności jak np. podłączenie zegarów wykorzystywanych w jednym z samochodów i pokazywanie na nim różnych błędów, czy np. zapalonych kierunkowskazów.

4.	Literatura:

1.	https://www.youtube.com/watch?v=sw3ADKPo1Uo – filmik pokazujący działanie płytki bardzo zbliżonej do tematu naszego projektu
2.	 http://abc-rc.pl/templates/images/files/995/1474871437-can-module.pdf - schemat modułu CAN
3.	http://abc-rc.pl/templates/images/files/995/1474871398-21801e.pdf - dokumentacja głównego modułu CAN
4.	http://abc-rc.pl/templates/images/files/995/1474871397-tja1050.pdf - dokumentacja transceivera CAN wbudowanego w moduł CAN
5.	https://www.arduino.cc/en/Main/ArduinoBoardUno - Pełny opis płyty Arduino UNO
6.	https://www.arduino.cc/en/Reference/HomePage - opis języka programowania Arduino
7.	https://www.arduino.cc/en/Main/ArduinoBoardLeonardo - Pełny opis płyty Arduino Leonardo
8.	https://github.com/claws/BH1750 - biblioteka do obslugi czujnika natężenia światła BH1750
9.	http://abc-rc.pl/templates/images/files/995/1462969349-bh1750fvi-tr.pdf - dokumentacja czujnika natężenia światła BH1750
10.	http://ep.com.pl/files/4190.pdf - podstawowe informacje na temat sieci CAN
11.	http://canbus.pl/index.php?id=2 – bardziej szczegółowe informacje odnośnie działania magistrali CAN



# EN:

TODO :P
