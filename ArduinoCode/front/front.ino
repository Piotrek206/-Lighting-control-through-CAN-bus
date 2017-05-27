
#include <Wire.h>
#include <BH1750.h>
#include <SPI.h>
#include "mcp_can.h"
BH1750 lightMeter;
unsigned char buf[8]={0};

const int SPI_CS_PIN = 10;

MCP_CAN CAN(SPI_CS_PIN);                                    // Set CS pin

void setup()
{
    Serial.begin(115200);
    lightMeter.begin();
    pinMode(A0,OUTPUT);
    pinMode(A1,OUTPUT);
    pinMode(A2,OUTPUT);
    pinMode(A3,OUTPUT);
    pinMode(A4,OUTPUT);
    pinMode(LED_BUILTIN,OUTPUT);

    while (CAN_OK != CAN.begin(CAN_500KBPS))              // init can bus : baudrate = 500k
    {
        Serial.println("CAN BUS Shield init fail");
        Serial.println(" Init CAN BUS Shield again");
        delay(100);
    }
    Serial.println("CAN BUS Shield init ok!");
}
unsigned long time_l=0;
unsigned long time_r=0;
unsigned long time_f=0;
unsigned long time_a=0;
unsigned long time_e=0;
int left=0;
int right=0;
int front = 0;
int automat=0;
int emergency=0;
int adc=0;
boolean d1 = true;
boolean d2 = true;
boolean autoLightOn=false;
unsigned char t_array[8] = {0, 0, 0, 0, 0, 0, 0, 0};
uint16_t lux;

boolean adcCheck(int nr, unsigned char pin,INT32U id ){
  adc= analogRead(pin);
                Serial.println(adc);
                if(adc>1005){
                  
                  t_array[nr]=1;
                  CAN.sendMsgBuf(id,0, 8, t_array);
                }
                else{
                  t_array[nr]=0;
                  CAN.sendMsgBuf(id,0, 8, t_array);
                }
}



void loop()
{
    unsigned char len = 0;
    

    if(CAN_MSGAVAIL == CAN.checkReceive())            // check if data coming
    {
        CAN.readMsgBuf(&len, buf);    // read data,  len: data length, buf: data buf

        unsigned char canId = CAN.getCanId();

        Serial.println("-----------------------------");
        Serial.println("get data from ID: ");
        Serial.println(canId);

        if (canId==16){
          canId=0;
          digitalWrite(A0,buf[0]);
          digitalWrite(A1,buf[0]);
          front=buf[0];
          
        }
        if (canId==32){
          canId=0;
          
          
        }
        if (canId==48){ //lewy
          canId=0;
          left=buf[2];
          digitalWrite(A2,buf[2]); 
            if(left==1){
              time_l=millis();
               adcCheck(4,A2,0x32);
            }
          
        }
        if (canId==64){ //prawy
          canId=0;
          right=buf[3];
          digitalWrite(A3,buf[3]); 
            if(right==1){
              time_r=millis();
              adcCheck(5,A3,0x42);
            }
          
        }

        if (canId==80){ //automatycznie
          canId=0;
          automat=buf[5];
          if(buf[5]==0) {
            digitalWrite(A0,LOW);
            digitalWrite(A1,LOW);
            autoLightOn=false;
          }
          
        }
       if (canId==96){ //emergency
          canId=0;
          emergency=buf[6];
          digitalWrite(A2,buf[6]);
          digitalWrite(A3,buf[6]); 
           if(emergency==1){
              time_e=millis();
              adcCheck(5,A3,0x42);
              adcCheck(4,A2,0x32);
            }
        }
        


    }
     if( left==1){
          
          if(millis() - time_l> 500){
            left=0;
            time_l=0;
             digitalWrite(A2,LOW);
          }
        }
     



       if (right ==1){
          if(millis() - time_r> 500){
            right=0;
            time_r=0;
             digitalWrite(A3,LOW);
          }
            
       } 
           if (emergency ==1){
          if(millis() - time_e> 500){
            emergency=0;
            time_e=0;
             digitalWrite(A2,LOW);
             digitalWrite(A3,LOW);
          }
            
       } 

      if (front==1){
        if(millis() - time_f> 1000){
            
         time_f=millis();
          adcCheck(0,A0,0x11);
          adcCheck(0,A1,0x12);
                
            }
          }
      if(automat==1){
        if(millis() - time_a> 700){
           time_a=millis();
             lux = lightMeter.readLightLevel();
             
             if(lux<=10){
              autoLightOn=true;
              digitalWrite(A0,HIGH);
              digitalWrite(A1,HIGH);
              t_array[6]=1;
              CAN.sendMsgBuf(0x51,0, 8, t_array);
              
             }
             if(lux>10){
              
              autoLightOn=false;
              digitalWrite(A0,LOW);
              digitalWrite(A1,LOW);
               t_array[6]=0;
              CAN.sendMsgBuf(0x51,0, 8, t_array);
             }
             if(t_array[6]==1){

              adcCheck(0,A0,0x11);
              adcCheck(0,A1,0x12);
              //adcCheck(7,A0,0x52);
              //adcCheck(7,A1,0x53);
             }
        }
      }
}









