// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte b = 5;
sbyte c = 5;

short s = 5;
ushort us = 5;

int i = 2;      // 4 byte
Int16 i16 = 2;  // 2 byte
Int32 i32 = 2;  // 4 byte
Int64 i64 = 2;  // 9 byte

uint ui = 2;    // 4 byte
long l = 4;     // 8 byte
ulong ul = 4;   // 8 byte

// Reel sayılar
float f = 5;    // 4 byte
double d = 5;   // 8 byte
decimal de = 5; // 16 byte

char ch = '2';  // 2 byte
string str = "Omer"; // sınırsız

bool b1 = true;
bool b2 = false;

// date with time
DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

// string ifadeler
string str1 = "";
string str2 = null;
string str3 = string.Empty;
str1 = "Omer Kocar";
string name = "Omer";
string surname = "Kocar";
string fullName = name + " " + surname;

// integer tanımlama şekilleri
int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

// boolean
bool bl1 = 10<2;

// değişken dönüşümleri
string str20 = "20";
int int20 = 20;
string newValue = str20 + int20.ToString();
Console.WriteLine(newValue);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);


// date without time
string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

// hours
string hours = DateTime.Now.ToString("HH:MM");
Console.WriteLine(hours);






