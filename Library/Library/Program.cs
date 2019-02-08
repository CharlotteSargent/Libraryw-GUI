using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Library
{
    public partial class Program : Form
    {
        private TextBox word;
        private TextBox user;
        private Button LogOn;
        private Label Password;
        private Label Username;
        private Label welcome;

        public Program()
        {
            InitializeComponent();
        }

        static void Main(string[] args)
        {

            

            Library.members.Add(new Member(123, "Charlotte Sargent"));
            //Library.members.Add(new Member(321, "David Sommers"));
            //Library.members.Add(new Member(231, "Victoria MacDonald"));

            Library.bookCollection.Add(new Book(213, "Kingdom of Ash", "Sarah J Maas", 999));
            Library.bookCollection.Add(new Book(1234, "Good Omens", "Terry Prachet", 300));

            Library.admins.Add(new Admin(4321, "Joanne Sargent", "mango"));

            Console.WriteLine();

            displayMenu();

            Application.Run(new Program());

            Console.ReadKey();
        }

        public static void displayMenu()
        {

            int userChoice;

            do
            {
                Console.WriteLine("1. Create New Member");
                Console.WriteLine("2. Create New Book");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Print Members");
                Console.WriteLine("6. Print Books");
                Console.WriteLine("7. Loans");
                Console.WriteLine("8. Quit");

                userChoice = getUserChoice();

            }
            while (userChoice != 8);

           

        }

        public static int getUserChoice()
        {
            int userChoice;

            int.TryParse(Console.ReadLine(), out userChoice);

            if(userChoice == 1)
            {
                Console.WriteLine("Member ID: ");
                int memID;
                int.TryParse(Console.ReadLine(),out memID);
                Console.WriteLine("Name: ");
                string memName = Console.ReadLine();

                Library.members.Add(new Member(memID, memName));
            }

            else if(userChoice == 2)
            {
                Console.WriteLine("Book ID: ");
                int bookID;
                int.TryParse(Console.ReadLine(), out bookID);
                Console.WriteLine("Title: ");
                string bookTitle = Console.ReadLine();
                Console.WriteLine("Author: ");
                string bookAuthor = Console.ReadLine();
                Console.WriteLine("Number of Pages: ");
                int bookPages;
                int.TryParse(Console.ReadLine(), out bookPages);
                Library.bookCollection.Add(new Book(bookID, bookTitle, bookAuthor, bookPages));

            }

            else if (userChoice == 3)
            {
                Admin admin = null;
                Console.WriteLine("Admin ID: ");
                int adID;
                int.TryParse(Console.ReadLine(), out adID);
                for (int i = 0; i < Library.admins.Count; i++)
                {
                    if (adID == Library.admins[i].getAdminID())
                    {
                        admin = Library.admins[i];
                    }
                    
                }
                
                Member mem = null;
                Console.WriteLine("Member ID: ");
                int memID;
                int.TryParse(Console.ReadLine(), out memID);
                for (int i = 0; i < Library.members.Count; i++)
                {
                    if (memID == Library.members[i].getID())
                    {
                        mem = Library.members[i];
                    }
                }

                Book book = null;
                Console.WriteLine("Book title: ");
                string bookTitle = Console.ReadLine();
                for (int i = 0; i < Library.bookCollection.Count; i++)
                {
                    if (bookTitle == Library.bookCollection[i].getTitle())
                    {
                        book = Library.bookCollection[i];
                    }

                }

                

                admin.borrowBook(mem, book);
                Library.loans.Add(new Loan(1234567, mem, book));


            }

            else if (userChoice == 4)
            {
                Admin admin = null;
                Console.WriteLine("Admin ID: ");
                int adID;
                int.TryParse(Console.ReadLine(), out adID);
                for (int i = 0; i < Library.admins.Count; i++)
                {
                    if (adID == Library.admins[i].getAdminID())
                    {
                        admin = Library.admins[i];
                    }

                }

                Member mem = null;
                Console.WriteLine("Member ID: ");
                int memID;
                int.TryParse(Console.ReadLine(), out memID);
                for (int i = 0; i < Library.members.Count; i++)
                {
                    if (memID == Library.members[i].getID())
                    {
                        mem = Library.members[i];
                    }
                }

                Book book = null;
                Console.WriteLine("Book title: ");
                string bookTitle = Console.ReadLine();
                for (int i = 0; i < Library.bookCollection.Count; i++)
                {
                    if (bookTitle == Library.bookCollection[i].getTitle())
                    {
                        book = Library.bookCollection[i];
                    }

                }

                Loan lone = null;
                Console.WriteLine("Loan ID: ");
                int loanID;
                int.TryParse(Console.ReadLine(), out loanID);
                for (int i = 0; i < Library.loans.Count; i++)
                {
                    if (loanID == Library.loans[i].getLoanID())
                    {
                        lone = Library.loans[i];
                    }
                }

                admin.returnBook(mem, book);
                Library.loans.Remove(lone);
            }

            else if (userChoice == 5)
            {
                Library.printMembers();
            }

            else if (userChoice == 6)
            {
                Library.printBookCollection();
            }

            else if (userChoice == 7)
            {
                Library.printLoans();
            }

            else if (userChoice == 8)
            {
                Console.WriteLine("Thank you.");
            }

            return userChoice;
        }

        private void InitializeComponent()
        {
            this.word = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.LogOn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(288, 226);
            this.word.Name = "word";
            this.word.PasswordChar = '*';
            this.word.Size = new System.Drawing.Size(100, 26);
            this.word.TabIndex = 0;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(288, 146);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 26);
            this.user.TabIndex = 1;
            this.user.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LogOn
            // 
            this.LogOn.Location = new System.Drawing.Point(237, 297);
            this.LogOn.Name = "LogOn";
            this.LogOn.Size = new System.Drawing.Size(104, 42);
            this.LogOn.TabIndex = 2;
            this.LogOn.Text = "Log In";
            this.LogOn.UseVisualStyleBackColor = true;
            this.LogOn.Click += new System.EventHandler(this.LogOn_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(204, 229);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(199, 149);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(214, 63);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(171, 20);
            this.welcome.TabIndex = 5;
            this.welcome.Text = "Welcome to the Library";
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(569, 413);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LogOn);
            this.Controls.Add(this.user);
            this.Controls.Add(this.word);
            this.Name = "Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogOn_Click(object sender, EventArgs e)
        {
            Admin admin = null;
            int userID;
            int.TryParse(user.Text, out userID);
            for (int i = 0; i < Library.admins.Count; i++)
            {
                if (userID == Library.admins[i].getAdminID())
                {
                    admin = Library.admins[i];
                }
            }
            if (admin.getPassword() == word.Text)
            {
                MessageBox.Show("You have successfully logged in.");
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();

            }
        }
    }
}
