namespace StudentApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Student Application Management System");

            //StudentApp.Banking.BankAccount ba;
            //ba = new Banking.BankAccount();
            //Console.WriteLine("Current balance {0}",ba.cbalance);
            //Console.Write("Enter amount to add: ");
            //double depo = Convert.ToDouble(Console.ReadLine());
            //ba.Deposit(depo);
            //Console.WriteLine($"After Depositing  {depo} current bal  :" + ba.cbalance);

            //Console.Write("Enter amount to withdraw: ");
            //double withd = Convert.ToDouble(Console.ReadLine());
            //ba.Withdraw(withd);
            //Console.WriteLine($"After Depositing {withd} current bal  :"+ ba.cbalance);

            //Console.Write("Enter Firstname: ");
            //string first_name = Console.ReadLine();

            //Console.Write("Enter Lastname: ");
            //string last_name = Console.ReadLine();

            //Console.Write("Enter City: ");
            //string city = Console.ReadLine();


            //Console.WriteLine($"{first_name} {last_name} is coming from {city}");
            //Console.WriteLine($"Name: {first_name} {last_name}");
            //Console.WriteLine($"City: {city}");

            //Student s1 = new Student();
            //Console.WriteLine("Rollno : " + Student.incrementID());
            //s1.rollno = Student.incrementID();
            ////s1.pname = "Aravindh";
            //s1.pname = Console.ReadLine();
            //s1.gender = Convert.ToChar(Console.ReadLine());
            //s1.showDetails();
            //s1.City = "Chennai";
            //s1.State = "Tamil Nadu";
            //s1.ZipCode = 603013;
            //Console.WriteLine(s1.getAddress());
            //s1.mobile = 9876556789;
            //s1.email = "rajkumar99@gmail.com";
            //Console.WriteLine(s1.showContact());

            //Console.WriteLine("=========================================");
            //Faculty f1 = new Faculty();
            //f1.pname = "Dhanush";
            //f1.gender = 'M';
            //f1.showDetails();
            //f1.City = "Perambalur";
            //f1.State = "Tamil Nadu";
            //f1.ZipCode = 621212;
            //Console.WriteLine(f1.getAddress());
            //f1.mobile = 9875348579;
            //f1.email = "dhanush69@gmail.com";
            //Console.WriteLine(f1.showContact());
            //Console.WriteLine("Name: " + s1.sname);
            //Console.WriteLine("Gender: " + s1.gender);
            //Console.WriteLine("=========================================");
            //Student s2 = new Student();
            //Console.WriteLine("Rollno : " + Student.incrementID());
            //s2.sname = "Priya";
            //s2.gender = 'F';
            //Console.WriteLine("Name: " + s2.sname);
            //Console.WriteLine("Gender: " + s2.gender);
            //Console.WriteLine("=========================================");
            //Student s3 = new Student();
            //Console.WriteLine("Rollno : " + Student.incrementID());
            //s3.sname = "Nithish";
            //s3.gender = 'F';
            //Console.WriteLine("Name: " + s3.sname);
            //Console.WriteLine("Gender: " + s3.gender);
            //Console.WriteLine("=========================================");
            //s3.displayDetails(sname: s3.sname, gender: s2.gender);

            //StringFunction f = new StringFunction();
            //f.showStringMethod();
            //f.stringinput();


            //Mathfunction m  = new Mathfunction();
            ////m.mathmethod();
            //m.smallarr();


            //Dateclass d = new Dateclass();
            //d.Datemethod();

            //Cfruits c = new Cfruits();
            //c.Choosefruit();
            //c.Countsent();

            //Arraymethods am = new Arraymethods();
            //am.showsArrayfunction();
            //am.Arraypresent();
            //am.StringArraypresent();
            //am.FruitsMenu();

            ListMethod listMethod = new ListMethod();
            //listMethod.ListMethods();
            listMethod.FruitsMenu();

            //Console.ReadKey();
        }
    }
}

