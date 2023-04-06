using System;

namespace NImpSaikumar
{
    public class Program
    {

        public static void Main(string[] args)
        {


            string mainstring = "sai";

            string substing = "vinay";

            Program programobj = new Program();

            int data = programobj.LetterCount(mainstring, substing);

            Console.WriteLine(data);

        }
        public  int  LetterCount(string mainString , string subSting)
        {
            int count = 0;
            for (int i = 0; i < mainString.Length; i++)
            {
                count = 0;
                 
                for (int j = 0; j < subSting.Length; j++)
                {
                    if(mainString.Length==subSting.Length)
                    {
                        if (mainString[i] == subSting[j])
                        {
                         //	Character of Main string matching with the character of sub string
                            count += 1;
                        //	Partial character of substring matching with characters of man string 
                            Console.WriteLine(mainString[i]);
                        }
                    }
                    
                    //	Character of Main string not matching with the character of sub string
                    if (mainString[i] != subSting[j])
                    {
                        
                        Console.WriteLine(mainString[i] + "This Letter is not Matched in subString");
                        break;
                    }
                }
            }
            return count;
        }
    
        //public static int CountSubstring(string mainStr, string subStr)
        //{
        //    int count = 0;
        //    int index = 0;
        //    while (true)
        //    {
        //        // find the next occurrence of the substring starting from the current index
        //        index = mainStr.IndexOf(subStr, index);
        //        if (index == -1) // if there are no more occurrences, exit the loop
        //        {
        //            break;
        //        }
        //        count++; // increment the count and continue searching from the next character
        //        index++;
        //    }
        //    return count;
        //}
        //console.writeline("hello world!");
        //console.writeline( countsubstring("sainath", "vinay"));
        //console.writeline(locate("sainath", "vinay"));
        //public static int Locate(string mainString, string subString)
        //{
        //    int mainLength = mainString.Length;
        //    int subLength = subString.Length;
        //    int count = 0;

        //    for (int i = 0; i <= mainLength - subLength; i++)
        //    {
        //        int j;
        //        for (j = 0; j < subLength; j++)
        //        {
        //            if (mainString[i + j] != subString[j])
        //            {
        //                break;
        //            }
        //        }
        //        if (j == subLength)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
    }
}
