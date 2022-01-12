// See https://aka.ms/new-console-template for more information

byte age = 25;
ushort audience = 5_550;
/* 
 * We can use an underline symbol to make 
 * reading the number EASIER!!!
 */
float average = 4.5f; // DON'T FORGET THE "F" (in declarations)
decimal star = 4.12345678901234567890m; // DON'T FORGET THE "M" (in declarations)
Console.WriteLine(age + "; " + audience + "; " + average + "; " + star);

bool approved = false;
Console.WriteLine("Approved?? " + approved);
Console.WriteLine(approved.GetType()); // KNOW THE TYPE OF VARIABLE "approved"

var x = 0; // Needs a value
int y; // Doesn't need a value
bool z; // Doesn't need a value

ushort totalSalary = 7568;
// Variable with CamelCase (we can also write "total_salary" if we want to [not CamelCase]. )
Console.ReadKey();
