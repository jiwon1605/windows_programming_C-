namespace Palindromic_number
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하시오: ");
            string number = Console.ReadLine();
            bool isPalindromic = true;

            for(int i = 0; i < number.Length; i++)
            {
                if (number[i]!= number[number.Length-1-i])
                { 
                    isPalindromic = false;
                    break;
                }
            }

            if (isPalindromic == true)
                Console.WriteLine(number + "회문수 입니다.");
            else
                Console.WriteLine(number + "회문수가 아닙니다.");
        }
    }
}