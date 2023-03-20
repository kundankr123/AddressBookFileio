namespace AddressBook3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the master branch of Address Book File i/o Problem");

            AddressBook myAddressBook = new AddressBook();
            Contacts newContact1 = new Contacts("Kundan", "Kumar", "Inadia", "7975461361", "kundan.kr@example.com");
            Contacts newContact2 = new Contacts("Thor", "Odinson", "USA", "1234567890", "thor.odinson@example.com");
            

            myAddressBook.AddContact(newContact1);
            myAddressBook.AddContact(newContact2);

            myAddressBook.PrintContacts();


            string path = "C:\\Users\\kundan\\Desktop\\Bridgelab\\rfp257\\AddressBook3\\AddressBook3\\Newfile.txt";


            myAddressBook.WriteToFile(path);
            myAddressBook.ReadFromFile(path);
        }
    }
}