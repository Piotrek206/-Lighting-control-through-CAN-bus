#include <mcp_can.h>
#include <SPI.h>

const int SPI_CS_PIN = 10;
unsigned char buf[8]={0};

MCP_CAN CAN(SPI_CS_PIN); 

void setup() {
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(115200);
  while (CAN_OK != CAN.begin(CAN_500KBPS))              // init can bus : baudrate = 500k
    {
        Serial.println("CAN BUS Shield init fail");
        Serial.println(" Init CAN BUS Shield again");
        delay(100);
    }
    Serial.println("CAN BUS Shield init ok!");




}
boolean lsp =true;
boolean psp =true;
boolean lst =true;
boolean pst =true;
boolean lkp =true;
boolean lkt =true;
boolean pkp =true;
boolean pkt =true;
boolean aut = true;

unsigned char t_array[8] = {0, 0, 0, 0, 0, 0, 0, 0};
unsigned long time_l=0;
unsigned long time_r=0;
unsigned long time_e=0;
int left=0;
int right=0;
int emergency =0;

void loop() {
  unsigned char len = 0;
  int x=5;
  while(1){
  if (Serial.available()) {
    
      x = Serial.read();
      //Serial.println(x);
    }
   
    switch (x){
  
    case 49: //przod
        if(t_array[5]==1){
          t_array[5]=0;
          Serial.write(3);
          CAN.sendMsgBuf(0x50,0, 8, t_array);
        }
         
        t_array[0]= (t_array[0]+1)%2;
        if(!t_array[0]) {
          lsp=true;
          psp=true;
          
        }
        CAN.sendMsgBuf(0x10,0, 8, t_array);
        //delay(50);
        break;
     case 50: //tyl 
      
        t_array[1]= (t_array[1]+1)%2;
        if(!t_array[1]) {
          lst=true;
          pst=true;
          }
        CAN.sendMsgBuf(0x20,0, 8, t_array);
       // delay(50);
        break;
     case 51: // lewy
        if(right==1){
          right=0;
          t_array[3]=0;
          CAN.sendMsgBuf(0x40,0, 8, t_array); 
        }
        if(emergency==1){
          emergency=0;
          t_array[6]=0;
          CAN.sendMsgBuf(0x60,0, 8, t_array); 
        }
        left=(left+1)%2;
        if(!left) {
          lkp=true;
          lkt=true;
          }
        break;
   
      case 52: // prawy

        if(left==1){
          left=0;
          t_array[2]=0;
          CAN.sendMsgBuf(0x30,0, 8, t_array); 
        }
        if(emergency==1){
          emergency=0;
          t_array[6]=0;
          CAN.sendMsgBuf(0x60,0, 8, t_array); 
        }
        right=(right+1)%2;
         
        if(!right) {
          pkp=true;
          pkt=true;
          }
        break;
       
      case 53: //automatycznie przod
        if(t_array[0]==1){
          t_array[0]=0;
          CAN.sendMsgBuf(0x10,0, 8, t_array);
        }
          t_array[5]=(t_array[5]+1)%2;
          if(!t_array[5]) {
          aut=true;
          }
          CAN.sendMsgBuf(0x50,0, 8, t_array);
       /* if(t_array[5]==0){
          t_array[0]=0;
          CAN.sendMsgBuf(0x10,0, 8, t_array);
        }*/
      break;

      case 54: // awaryjne

        if(left==1){
          left=0;
          t_array[2]=0;
          CAN.sendMsgBuf(0x30,0, 8, t_array); 
        }
        if(right==1){
          right=0;
          t_array[3]=0;
          CAN.sendMsgBuf(0x40,0, 8, t_array); 
        }
        emergency=(emergency+1)%2;
        break;
      
    }
    
    x=0;
      if(left==1){
        if(millis() - time_l> 1000){
          time_l=millis();
          t_array[2]= 1;
          CAN.sendMsgBuf(0x30,0, 8, t_array);
        }
        
      }

      if(right==1){
        if(millis() - time_r> 1000){
          time_r=millis();
          t_array[3]= 1;
          CAN.sendMsgBuf(0x40,0, 8, t_array);
        }
      }

       if(emergency==1){
        if(millis() - time_e> 1000){
          time_e=millis();
          t_array[6]= 1;
          CAN.sendMsgBuf(0x60,0, 8, t_array);
        }
      }
      
      if(CAN_MSGAVAIL == CAN.checkReceive())            // check if data coming
    {
        CAN.readMsgBuf(&len, buf);    // read data,  len: data length, buf: data buf

        unsigned char canId = CAN.getCanId();

       
       // Serial.println("get data from ID: ");
       // Serial.println(canId);
        
        
        switch (canId){
        case 17:
          canId=0;
          if(buf[0]==1){
          //Serial.println("lewa przod spalona ");
            if(lsp==true){
              lsp=false;
              Serial.print(1);
            }
          }
          else{
          //Serial.println("lewa przod dziala ");
          if(lsp==false){
              lsp=true;
              Serial.print(2);
            }
          }
          break;
        case 18:
          canId=0;
          if(buf[0]==1){
         // Serial.println("prawa przod spalona ");
          if(psp==true){
              psp=false;
              Serial.print(3);
            }
          }
          else{
         // Serial.println("prawa przod dziala ");
          if(psp==false){
              psp=true;
              Serial.print(4);
            }
          }
          break;
        
        case 33:
          canId=0;
          if(buf[1]==1){
            //Serial.println("lampka tyl prawa spalona ");
          if(pst==true){
              pst=false;
              Serial.print(7);
            }
          
          }
          else{
          //Serial.println("lampka tyl prawa dziala ");
          if(pst==false){
              pst=true;
              Serial.print(8);
            }
          }
          
          break;
        case 34:
          canId=0;
          if(buf[1]==1){
          //Serial.println("lampka tyl lewa spalona ");
          if(lst==true){
              lst=false;
              Serial.print(5);
            }
          
          }
          else{
          //Serial.println("lampka tyl lewa dziala ");
          if(lst==false){
              lst=true;
              Serial.print(6);
            }
         
          }
          break;
          
        case 49:
          canId=0;
          if(buf[2]==1){
         // Serial.println("lewy kier tyl spalone  ");
         if(lkt==true){
              lkt=false;
              Serial.print(';');
            }
         
          }
          else{
         // Serial.println("lewy kier tyl dziala ");
         if(lkt==false){
              lkt=true;
              Serial.print('<');
            }
         
          }
          break;
        case 50:
          canId=0;
          if(buf[4]==1){
          
          //Serial.println("lewy kier przod spalone  ");
              if(lkp==true){
                  lkp=false;
                  Serial.print('9');
                }
          }
          else{
          //Serial.println("lewy kier przod dziala ");
              if(lkp==false){
                  lkp=true;
                  Serial.print(':');
                }
           }
          break;
          
        case 65:
          canId=0;
          if(buf[3]==1){
          //Serial.println("prawy kier tyl spalone");
           if(pkt==true){
                  pkt=false;
                  Serial.print('?');
                }
           
          }
          else{
         // Serial.println("prawy kier tyl dziala ");
         if(pkt==false){
                  pkt=true;
                  Serial.print('@');
                }
           
          }
          break;
        
         case 66:
          canId=0;
          if(buf[5]==1){
          //Serial.println("prawy kier przod spalone");
           if(pkp==true){
                  pkp=false;
                    Serial.print('=');
                }
         
         
          }
          else{
          //Serial.println("prawy kier przod dziala ");
            if(pkp==false){
                  pkp=true;
                    Serial.print('>');
                }
          
          }
          break;
        case 81:
          canId=0;
          if(buf[6]==1){
             //Serial.println("jest wystarczajaco ciemno");
             if(aut==false){
              aut=true;
              Serial.print('A');
             }
          }
          else{
           //Serial.println("jest za jasno ");
            if(aut==true){
              aut=false;
              Serial.print('B');
             }
          }
          
        break;
        
/*
        case 82:
          canId=0;
          if(buf[7]==1)
          Serial.println("automatyczne lewe spalone ");
          else
          Serial.println("automatyczne lewe dziala ");
        break;

        
        case 83:
          canId=0;
          if(buf[7]==1)
          Serial.println("automatyczne prawe spalone ");
          else
          Serial.println("automatyczne prawe dziala ");
        break;*/
        }
 
    }
  }
}
