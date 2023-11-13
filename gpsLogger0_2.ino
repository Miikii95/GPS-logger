#include <SPI.h>
#include <SD.h>
#include <SoftwareSerial.h>
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
#include <TinyGPS.h>
/* This sample code demonstrates the normal use of a TinyGPS object.
   It requires the use of SoftwareSerial, and assumes that you have a
   4800-baud serial GPS device hooked up on pins 4(rx) and 3(tx).
*/


LiquidCrystal_I2C lcd(0x27,20,4);

const int rx = 3, tx = 4;
SoftwareSerial ss (tx,rx);

const int SDcs = 8;
TinyGPS gps;
////////////////////////////////////////////////////////////////////////////////////////////////
static void smartdelay(unsigned long ms);
void Msg2LcdNSerial(String s);
void showDataLcd(byte hour, byte minute, byte second, float flat, float flon);
String smartNum2Str(int num);
String filename ="";
void setup()
{
  Serial.begin(115200);
  delay(100);
  lcd.init();
  lcd.backlight();
  Msg2LcdNSerial("Program started");
  delay(1000);
  if (!SD.begin(SDcs)) 
  {
    Msg2LcdNSerial("card failed");
    delay(1000);
  }
  else  {
          Msg2LcdNSerial("SDcard init");
          delay(500);
        }

  ss.begin(9600);

}//setup

void loop()
{
  float flat, flon;
  unsigned long age;

  gps.f_get_position(&flat, &flon, &age);
 
  int year;
  byte month, day, hour, minute, second, hundredths;

  gps.crack_datetime(&year, &month, &day, &hour, &minute, &second, &hundredths, &age);
  if (age == TinyGPS::GPS_INVALID_AGE)
    {
      Msg2LcdNSerial("connecting 2 gps");
    }
  else
  {
    showDataLcd( hour,  minute,  second,  flat,  flon);
    String strH, strM, strS;
    strH = smartNum2Str(hour);
    strM = smartNum2Str(minute);
    strS = smartNum2Str(second);

    String dataString = strH+":"+strM+":"+strS+" ; Lat: "+String(flat,4) + " ; Lon: "+String(flon,4);
    Serial.println(dataString);

    if (filename == "") {filename = strH+strM+strS+".txt";
    Serial.println(filename);}
    
    File dataFile = SD.open(filename, FILE_WRITE);
    if (dataFile) 
      {
    dataFile.println(dataString);
    dataFile.close();
      }
      else {
            delay(500);
            Msg2LcdNSerial("SDcard error");
           }

  
}
smartdelay(1000);
}//loop

static void smartdelay(unsigned long ms)
{
  unsigned long start = millis();
  do 
  {
    while (ss.available())
      gps.encode(ss.read());
  } while (millis() - start < ms);
}


void Msg2LcdNSerial(String s)
{
  lcd.clear();
  lcd.print(s);
  Serial.println(s);
}

void showDataLcd(byte hour, byte minute, byte second, float flat, float flon)
{
    lcd.clear();
    if(hour<10){lcd.print("0");}
    lcd.print(hour);
    lcd.print(":");
    if(minute<10){lcd.print("0");}
    lcd.print(minute);
    lcd.print(":");
    if(second<10){lcd.print("0");}
    lcd.print(second);
    lcd.setCursor(0,1);
    lcd.print(String(flat,4));
    lcd.print(" ");
    lcd.print(String(flon,4));
}

String smartNum2Str(int num)
{
  String res ="";
  if (num<10) {res+="0";}
  res+=String(num);
  return res;
}