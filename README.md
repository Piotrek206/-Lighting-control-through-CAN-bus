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
Lighting control via CAN bus

    Assumptions and objectives of the project

The topic of the project will be implementation of the lighting controller via the CAN bus. The following will be used:

    Arduino Leonardo,
    two Arduino UNO,
    Three CAN SPI MCP2515 modules including an MCP2515 controller and a CAN transceiver TJA1050 to connect the microcontroller to the CAN bus,
    8 LEDs (two white diodes simulating the front lights of the car, four orange colors simulating the direction indicators and two red color simulating the rear lights of the vehicle)
	
    Light intensity sensor, eg: BH1750 (will be connected to the microcontroller and depending on the intensity of the light will light / extinguish the light on the front of the vehicle)
	

In order to control the lighting we will make a suitable application for a PC in .NET technology which will enable each of the diodes or eg turn the direction indicators.
 In order to program the above application we used the Microsoft Visual Studio 2015 environment and the C # programming language.

    Work plan

    Purchase the necessary items

    Configuration of the Arduino Leonardo microcontroller for easy running of sample programs and Arduino UNO configuration.

    Establishment of connection between Leonardo and UNO, without CAN bus

    Program microcontrollers to properly illuminate the diodes (flashing "turn signals", turning on and off the lights "in front and back").

    Create a CAN bus and create communication through this bus.

    Integration of CAN communication with lights lit.

    Adding both sides of communication so that Leonardo can receive information from UNO (for example, a burnt light bulb)

    Connection of light sensor under Arduino UNO and use it for automatic mode.

    Creation of Leonardo communication with a laptop using a serial port.

    Writing application with user interface for controlling and extinguishing LEDs.

    Summary:

While doing this project, we have learned many new technologies. We learned about the operation and operation of the CAN bus, the operation of the BH1750 light sensor, communication between several microcontrollers, and we learned about the possibility of connecting the microcontroller and the laptop through the serial port.
 We also encountered many problems.
 The first was the erroneous purchase of Arduino Mini Pro chips with ATmega328 microprocessor due to the outdated technology and not compatible with the example of Windows 10 we were working on, unfortunately this board was connected by a programmer which did not have an automatic "reset" We decided to replace these boards with Arduino UNO boards.
 Another problem was initially insufficient knowledge of the field of CAN bus operation and hardware. We bought CAN transceivers, which proved to be incorrect, because we also need CAN controllers for these arduino boards to control the Bus.
 Therfore we had to buy CAN modules with built-in controller and transceiver. Happily, we finally managed to make communication with the Canbus and step by step we finished our project.
 I think thanks to the project we got to know the mechanisms that allow us to transfer data to the main controller in cars .
 In the future it would be possible to extend our project with additional functionality such as connecting the clocks used in one of the cars and showing various errors or for example, .

    Literature:

    https://www.youtube.com/watch?v=sw3ADKPo1Uo - a video showing the effect of a tile very close to the theme of our project

    http://plc-rc.pl/templates/images/files/995/1474871437-can-module.pdf - CAN module diagram

    http://en.wikipedia.org/wiki/File:Component.htm

    http://abc-rc.pl/templates/images/files/995/1474871397-tja1050.pdf - CAN transceiver documentation built into CAN module

    https://www.arduino.cc/en/Main/ArduinoBoardUno - A full description of Arduino UNO

    https://www.arduino.cc/en/Reference/HomePage - description of the Arduino programming language

    https://www.arduino.cc/en/Main/ArduinoBoardLeonardo - Full description of the album Arduino Leonardo

    https://github.com/claws/BH1750 - BH1750 light sensor support library

    http://en.wikipedia.org/w/index.php?title=File:Blue Light Sensor Specifications

    http://ep.com.pl/files/4190.pdf - basic information about the CAN network

    http://canbus.pl/index.php?id=2 - More detailed information on CAN bus operation
