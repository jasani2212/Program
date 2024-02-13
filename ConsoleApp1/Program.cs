// See https://aka.ms/new-console-template for more information

#region Palindrome Number
/*int n = 0, c, s = 0, r;
Console.WriteLine("enter number :");
n = Convert.ToInt32(Console.ReadLine());
c = n;
while (n > 0)
{
    r = n % 10;
    s = (s * 10) + r;
    n = n / 10;
}
if (c == s)
    Console.WriteLine("Palindrome number");
else
    Console.WriteLine("Not Palindrome number");
Console.ReadLine();*/
#endregion Palindrome Number

#region Armstrong Number
/*int n = 0, c, arm = 0, rem;                                        
Console.WriteLine("enter any number :");
n = Convert.ToInt32(Console.ReadLine());
c = n;
while (n > 0)
{
    rem = n % 10;
    arm = (rem * rem * rem) + arm;
    n = n / 10;
}
if (c == arm)
    Console.WriteLine("Armstrong Number");

else
    Console.WriteLine("Not Armstrong Number");
Console.ReadLine();*/
#endregion Armstrong number

#region Prime Number
/*int n, count = 0;
Console.WriteLine("enter any number :");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        count++;
    }
}
if (count == 2)
    Console.WriteLine("Prime Number");
else
    Console.WriteLine("Not Prime Nummber");
Console.ReadLine();*/
#endregion Prime Number

#region String Reverse
/*Console.WriteLine("Enter any String");
string str = Console.ReadLine();
string reverse = " ";
for (int i = str.Length - 1; i >= 0; i--)
{
    reverse += str[i];
}
Console.WriteLine(reverse);*/
#endregion String Reverse

#region String Palindrome
/*Console.WriteLine("enter any string for check its palidrome or not :");
string str = Console.ReadLine();
string res = " ";
char[] arr = str.ToCharArray();
Array.Reverse(arr);
string str_res = new string(arr);
if (str == str_res)
{
    Console.WriteLine( "string is palindrome");
}
else
{
    Console.WriteLine("string is not palindrome");
}
Console.ReadLine();*/

#endregion String Palindrome