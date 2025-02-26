namespace page1ex9
{
    internal class Program
    {

        public static int CountExsist(string str1, string str2)
        {
            int count = 0;
            bool flag = true;

            for (int i = 0; i < str2.Length; i++)
            {
                if(str2.Length>0)
                {
                    if (str2.IndexOf(str1[0]) != -1)
                    {
                        for (int j = 0; j < str1.Length; j++)
                        {
                            if ((i + j) < str2.Length)
                            {
                                if (str1[j] != str2[i + j])
                                {
                                    flag = false;
                                }
                            }

                        }
                        if (flag)
                        {
                            count++;
                            str2.Remove(i, str1.Length);
                            i--;
                        }
                    }
                }
                else
                    return count;

            }
            return count;
        }
        static void Main(string[] args)
        {
            string str1 = "",str2="";
            Console.WriteLine("Enter two strings ");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            Console.WriteLine(CountExsist(str1, str2)); 
        }
    }
}