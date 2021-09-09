using System;

namespace Pr
{
   public class Activity
    {
        public string String1;
        public string String2;
        public char Operator;
        public Activity(string str1,string str2,char op)
        {
            String1 = str1;
            String2 = str2;
            Operator = op;
        }
    }
    class Source:Exception
    {
       
        static void Main()
        {
            Source s = new Source();
            Activity a = new Activity("Hello","world",'+');


          

        }
        public string HandleException(Activity a)
        {
            try
            {

                if (a.String1 == null || a.String2 == null)
                {

                    throw new System.ArgumentNullException("String1");


                }
            }
            catch (Exception)
            {
                throw;
            }

            return 
        }
        public string Operate(Activity a)
        {

        }
        static void Main(string[] args)
        {
            
        }
    }
   
}
