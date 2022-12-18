
int num, i, flag, N1, N2;

Console.Write("write the first number: ");
N1 = int.Parse(Console.ReadLine());
Console.Write("write the last number: ");
N2 = int.Parse(Console.ReadLine());
Console.Write("The prime numbers between {0} and {1} are : \n", N1, N2);

for (num = N1; num <= N2; num++)
{
    flag = 0;

    for (i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            flag++;
            break;
        }
    }

    if (flag == 0 && num != 1)
        Console.Write("{0} ", num);
}
