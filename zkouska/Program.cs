namespace zkouska
{
    internal class Program
    {
        
            
            

            public string GetName()
            {
                string random_Name = "";
                for (int i = 0; i > Random.Shared.Next(5, 11); i++)
                {
                    int ascii_index = Random.Shared.Next(65, 91);
                    random_Name += Convert.ToChar(ascii_index);
                }

                return random_Name;
            }
        static void Main(string[] args)
        {
            string GetName()
            {
                string letters = "qwertzuiopasdfghjklyxcvbm";
                string Name = "";

                int lenght = Random.Shared.Next(5, 10);
                for (int i = 0; i < lenght; i++)
                {
                    int rndpositon = Random.Shared.Next(letters.Length);
                    Name += letters[rndpositon];
                }
                return Name;
            }

            
            

            
            Console.WriteLine(GetName());
        }

    }
}