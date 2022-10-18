using System.Security.Cryptography.X509Certificates;

namespace Week3
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        int[] grades = new int[2];
        List<Clerk> clerkList = new List<Clerk>();
        
        public Form1()
        {
            InitializeComponent();
            clerkList.Add(new Clerk("Alex", "Password"));
            clerkList.Add(new Clerk("Bill", "Password"));
            clerkList.Add(new Clerk("Takis", "Password"));
            clerkList.Add(new Clerk("Maria", "Password"));
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_loginName.Text != "" && tb_password.Text != "")
            {
                for(int i =0; i< clerkList.Count;i++)
                {
                    //&& AND , || OR
                    if (clerkList[i].Name == tb_loginName.Text && tb_password.Text == clerkList[i].Password)
                    {
                        Inventory inv = new Inventory();
                        inv.Show();
                    }
                }
            }
        }
    }
}