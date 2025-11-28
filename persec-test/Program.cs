using persec_test;

test01 t1 = new test01();

string inputT1 = "([[{}]]]";
bool result = false;

Console.WriteLine("Test 01: " + t1.checkBracket(inputT1));
// ==================================================

test02 t2 = new test02();

string[] inputt2 = ["TH19", "SG20", "TH2"];
// string[] inputt2 = ["TH10", "TH3Netflix", "TH1", "TH7", "SG9"];
string[] sorted = t2.sort(inputt2);
Console.WriteLine("Test 02: " + string.Join(", ", sorted));
// ==================================================

test03 t3 = new test03();
string search = "th";
string[] items = ["Mother", "Think", "Worthy", "Apple", "Android"];
int maxResult = 2;
string[] resultt3 = t3.autoComplete(search, items, maxResult);
Console.WriteLine("Test 03: " + String.Join(", ", resultt3));

// // ==================================================
test04 t4 = new test04();

int number = 5200;
string resultRoman = t4.toRoman(number);
Console.WriteLine("Test 04: ");
Console.WriteLine(resultRoman);
string roman = "CIX";
int resultNumber = t4.toNumber(roman);
Console.WriteLine(resultNumber);
// ==================================================

test05 t5 = new test05();

int inputT5 = 10098123;
int resultt5 = t5.max(inputT5);
Console.WriteLine("Test 05: " + resultt5);
// ==================================================

test06 t6 = new test06();

int[] inputt61 = [];
int[] inputt62 = [5, 2, 0];
int[] inputt63 = [1];
int[] inputt64 = [3, 4, 1];

int[] resultt6 = t6.tribonacci(inputt61, 5);

Console.WriteLine("Test 06: " + String.Join(", ", resultt6));