// See https://aka.ms/new-console-template for more information
const short NUM = 21; // CONSTANT (CANNOT CHANGE THE VALUE: ERROR!)

const string SCHOOL = "Estudonauta";
const float PI = 3.1416f;

// SCHOOL = "CursoEmVídeo" (NOT POSSIBLE, CAUSE "school" IS A CONSTANT)

Console.WriteLine("I study in " + SCHOOL + ".");
Console.WriteLine("The value of Pi is " + PI + '.');
Console.WriteLine("The type of Pi is " + PI.GetType());

// WE DON'T NEED TO DECLARE PI!!!
Console.WriteLine("The OFFICIAL value of Pi is " + Math.PI);
Console.WriteLine("The type of Pi in Math is " + Math.PI.GetType());

Console.ReadKey();
