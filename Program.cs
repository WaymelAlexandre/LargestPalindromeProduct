using System;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        { 
            //-user choose the range of the numbre
            System.Console.WriteLine("How Many carater you whant a know ?");
            int lenghtNumbreCHoisie = int.Parse(Console.ReadLine());  
            int maxNum = 0, total = 0; // maximun lengh choisi  and variable for the total of the multiplication 
            List<int> palindromeList = new List<int>(); //list of all numbre palindrome with duplicated
           
            for (int i = 1; i <= lenghtNumbreCHoisie; i++) //loop to know the max numbre 
            {
                maxNum *=10;
                maxNum += 9; 
            }
            // -calcule until max range atteind 
                        
            for (int i = 1; i <= maxNum; i++)
            {
                for (int a = 1; a <= maxNum; a++)
                {
                    total = i * a ;
                    if (checkpalindrom(total) == true){palindromeList.Add(total);}
                }
            }
            palindromeList.Sort();
            for (int r = 0; r < palindromeList.Count(); r++)
            {System.Console.WriteLine(palindromeList[r]);}
            
            System.Console.WriteLine(maxNum); // check to see all palindrom Numbre
            System.Console.WriteLine($" Palindrom Numbre Minimun:  {palindromeList[0]} \n Palindrome Numbre Maximun:  {palindromeList[palindromeList.Count()-1]}"); //write the smallest and bignumbre paladrome numbre

            }
        // check if is it palindrome function
            private static bool checkpalindrom(int numbre){
                string checkreverse;
                char[] numbrearray = numbre.ToString().ToCharArray();
                Array.Reverse(numbrearray);
                checkreverse = new string(numbrearray);

                if(checkreverse == numbre.ToString())
                {return true;} 
                return false;

        }
    }
}
