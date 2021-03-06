#include <SoftwareSerial.h>
#include "RoboClaw.h"
#include <string.h>
#include <NASAMotorControl.h>

//SoftwareSerial serial(0, 1); // RX, TX
SoftwareSerial serial(2,3); //S2 2 S1 3 
RoboClaw roboclaw(&serial,10000);

#define address_drive 0x80 //address of roboclaw controlling drive motors
#define address_actuator 0x81 //address of roboclaw controlling actuators
#define address_loader 0x82 //address of roboclaw controlling bucket loader motors/other motors

String MotorName, Command, MotorSpeed; //Declares message components as global variables so they can be used in all functions
int speed_value, half_speed;

const byte EOT = 0x04;

void setup() {
  // Open
  pinMode(13, OUTPUT);
  Serial.begin(115200);
  delay(1000);

  roboclaw.begin(115200);
}

void motorsDrive()
{
  if(Command.equals(Forward) || Command.equals(Reverse))
  {
    roboclaw.ForwardBackwardM1(address_drive, speed_value); //set left motor to forward or reverse at speed value sent
    roboclaw.ForwardBackwardM2(address_drive, speed_value); //set right motor to forward or reverse at speed value sent
  }
  else if(Command.equals(Left)) //Soft Left Turn
  {
    roboclaw.ForwardBackwardM1(address_drive, half_speed); //set left motor to zero speed
    roboclaw.ForwardBackwardM2(address_drive, speed_value); //set right motor forward at speed value sent
  }
  else if(Command.equals(Right)) //Soft Right Turn
  {
    roboclaw.ForwardBackwardM1(address_drive, speed_value); //set left motor to forward at speed value sent
    roboclaw.ForwardBackwardM2(address_drive, half_speed); //set right motor set to zero speed
  }
  else if(Command.equals(CCW)) //Counter-Clockwise Point Turn
  {
    roboclaw.ForwardBackwardM1(address_drive, (127 - speed_value)); //set left motor to reverse at speed value sent
    roboclaw.ForwardBackwardM2(address_drive, speed_value); //set right motor to forward at speed value sent
  }
  else if(Command.equals(CW)) //Clockwise Point Turn
  {
    roboclaw.ForwardBackwardM1(address_drive, speed_value); //set left motor to forward at speed value sent
    roboclaw.ForwardBackwardM2(address_drive, (127 - speed_value)); //set right motor to reverse at speed value sent
  }
  else if(Command.equals(Stop))
  {
    roboclaw.ForwardBackwardM1(address_drive, 64); //set left motor to zero speed
    roboclaw.ForwardBackwardM2(address_drive, 64); //set right motor to zero speed
  }
}

void actuator1()
{
  if(Command.equals(Up) || Command.equals(Down))
  {
    roboclaw.ForwardBackwardM1(address_actuator, speed_value); //set actuator to forward or reverse at speed value sent
  }
  else if(Command.equals(Stop))
  {
    roboclaw.ForwardBackwardM1(address_actuator, 64); //set actuator to zero speed
  }
}

void actuator2()
{
  if(Command.equals(Up) || Command.equals(Down))
  {
    roboclaw.ForwardBackwardM2(address_actuator, speed_value); //set actuator to forward or reverse at speed value sent
  }
  else if(Command.equals(Stop))
  {
    roboclaw.ForwardBackwardM2(address_actuator, 64); //set actuator to zero speed
  }
}

void loop() { // run over and over
    //byte inByte = 3;
    //uint8_t answer[] = {0x44,0x72,0x69,0x76,0x65};
    //uint8_t answer = [D,r,i,v,e];
    //uint8_t answer[] = {'D','r','i','v','e'};
    delay(1);  
    if(Serial.available()>0){
      //inByte = Serial.read();
      delay(100);
      size_t len = Serial.available();
      uint8_t sbuf[len];
      Serial.readBytesUntil(EOT, sbuf, len);
      //delay(1000);
      String messageIn = "";      
      messageIn = String((char*)sbuf);
      Serial.print(messageIn);
      int commaOne = 0;
      int commaTwo = 0;
          
      for(int i = 0; i < messageIn.length(); i++)
      {
        if(messageIn.charAt(i) == ',' && commaOne == 0){
          commaOne = i;
        }
        else if(messageIn.charAt(i) == ',' && commaOne != 0 && commaTwo == 0){
          commaTwo = i; 
        }
      }
      
      MotorName = messageIn.substring(0, commaOne);
      Command = messageIn.substring((commaOne+2), commaTwo);
      MotorSpeed = messageIn.substring((commaTwo+1), (messageIn.length()-1));

      speed_value = MotorSpeed.toInt(); //Sets the integer speed_value to the value stored in the string MotorSpeed
      if (speed_value == 128) //Sets the full speed value to 127 as that's the upper limit of ForwardBackward() command
      {
        half_speed = 96;
        speed_value -= 1;
      }
      else
      {
        half_speed = (speed_value / 2 + 32);
      }

      Serial.print(MotorName + " " + Command + " " + MotorSpeed);
     // Serial.print(messageIn.substring(0, commaOne));

      if(MotorName.equals(DriveMotor))
      {
        motorsDrive();
      }
      else if(MotorName.equals(Actuator1)) //Name subject to change based on GUI
      {
        actuator1();
      }
      else if(MotorName.equals(Actuator2)) //Name subject to change based on GUI
      {
        actuator2();
      }
      else if(sbuf[0] == 'c'){
        roboclaw.ForwardBackwardM1(address_drive, 96);
        roboclaw.ForwardBackwardM2(address_drive, 96);
      }
      else if(sbuf[0] == 'd'){
        roboclaw.ForwardBackwardM1(address_drive, 64);
        roboclaw.ForwardBackwardM2(address_drive, 64);
      }
         
      /*
       if(((MotorName.equals(DriveMotor))) && Command.equals(Forward)){
        //digitalWrite(13, HIGH);
        roboclaw.ForwardBackwardM1(address, 80); //set to forward
        roboclaw.ForwardBackwardM2(address, 80);
      }
      else if((MotorName.equals(DriveMotor)) && Command.equals(Stop)){
        //digitalWrite(13, LOW);
        roboclaw.ForwardBackwardM1(address, 64); //set to zero
        roboclaw.ForwardBackwardM2(address, 64);
      }
      else if((MotorName.equals(DriveMotor)) && Command.equals(Reverse)){
        roboclaw.ForwardBackwardM1(address, 48);
        roboclaw.ForwardBackwardM2(address, 48);
          //digitalWrite(13, LOW);
      }
      else if(sbuf[0] == 'c'){
        roboclaw.ForwardBackwardM1(address, 96);
      }
      */
    }
}
