namespace MyWinFormsApp1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc(object sender, EventArgs e)
        {
            string name;
            double a,b,c;
            Worker wrkr;

            name = textBox1.Text;
            double.TryParse(textBox2.Text, out a);
            double.TryParse(textBox3.Text, out b);
            double.TryParse(textBox4.Text, out c);

            wrkr = new Worker(name, a, b, c);

            textBox5.Text = wrkr.taxCalc().ToString();
            textBox6.Text = wrkr.bonusCalc().ToString();
            textBox7.Text = wrkr.raiseSalary().ToString();
            textBox8.Text = (wrkr.salary + wrkr.bonusCalc() - wrkr.taxCalc() + wrkr.raiseSalary()).ToString();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Worker
    {
        public string name { get; set; }
        public double salary { get; set; }
        public double workHours { get; set; }
        public double hireYear { get; set; }
        public double tax { get; set; }
        public double bonus { get; set; }
        public double salaryIncrease { get; set; }
        public double totalSlary { get; set; }

        public Worker(string name ,double salary ,double workHours ,double hireYear)
        {
            this.name = name;
            this.salary = salary;
            this.workHours = workHours;
            this.hireYear = hireYear;
        }

        public double taxCalc()
        {
            double temp = 0;
            if (salary < 1000)
            {
                temp = 0;
            }
            if (salary >= 1000)
            {
                temp = salary * 3 / 100;
            }
            return temp;
        }

        public double bonusCalc()
        {
            double temp = 0;
            if (workHours < 40)
            {
                temp = 0;
            }
            if (workHours >= 40)
            {
                temp = ((workHours - 40) * 30);
            }
            return temp;
        }

        public double raiseSalary()
        {
            double temp = 0;
            double yeraOfWork = 2021 - hireYear;

            if (yeraOfWork < 10)
            {
                temp = salary * 5 / 100;
            }if (yeraOfWork >= 10 && yeraOfWork < 20)
            {
                temp = salary * 10 / 100;
            }if (yeraOfWork >= 20)
            {
                temp = salary * 15 / 100;
            }

            return temp;
        }


    }
}