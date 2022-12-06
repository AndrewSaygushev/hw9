// TASK 64

/*Console.WriteLine("Please enter a natural number greater than 1");
int Number = Convert.ToInt32(Console.ReadLine());

void EnteredNumber(int Number)
{
    if (Number < 0)
    {
        Console.WriteLine($"{Number} - is not a natural number");
        return;
    }
    else if (Number == 0) return;

    else
    {
        Console.Write("{0,4}", Number);
        EnteredNumber(Number - 1);
    }   
}

Console.WriteLine();
EnteredNumber(Number);*/


// TASK 66

/*Console.Write("Please enter the number A - ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the number B -  ");
int B = Convert.ToInt32(Console.ReadLine());

void SumNumber(int A, int B, int sum)
{
    if (A > B)
    {
        Console.WriteLine($"The sum = {sum}");
        return;
    }
    sum = sum + (A++);
    SumNumber(A, B, sum);
}

Console.WriteLine();
SumNumber(A, B, 0);*/


// TASK 68

int A = InputNumbers("Please enter Number A - ");
int B = InputNumbers("Please enter Number B - ");

int functionAkkerman = Ack(A, B);

Console.WriteLine($"Ackermann function = {functionAkkerman}");

int Ack(int A, int B)
{
  if (A == 0)
  {
    return B + 1;
  }
  else 
  {
    if (B == 0)
    {
        return Ack(A - 1, 1);
    }
    else 
    {
        return Ack(A - 1, Ack(A, B - 1));
    }
  }
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.WriteLine();