namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new()
            {
                new Account(1, 25),
                new Account(25, 0.5),
                new Account(345, 314),
                new Account(9, 84)
            };
            JSONSerializer<Account> JSONSerializer = new("json.json");
            JSONSerializer.Save(accounts);
            Console.WriteLine("Saved to JSON:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }
            accounts = JSONSerializer.Load();
            Console.WriteLine("Loaded from JSON:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }


            CustomSerializer<Account> CustomSerializer = new("custom.txt");
            CustomSerializer.Save(accounts);
            Console.WriteLine("Saved to Custom:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }
            accounts = CustomSerializer.Load();
            Console.WriteLine("Loaded from Custom:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            XMLSerializer<Account> XMLSerializer = new("xml.xml");
            XMLSerializer.Save(accounts);
            Console.WriteLine("Saved to XML:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }
            accounts = XMLSerializer.Load();
            Console.WriteLine("Loaded from XML:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            BinarySerializer<Account> BinarySerializer = new("binary.bin");
            BinarySerializer.Save(accounts);
            Console.WriteLine("Saved to Binary:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }
            accounts = BinarySerializer.Load();
            Console.WriteLine("Loaded from Binary:");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }
        }
    }
}