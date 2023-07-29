namespace Lesson29_07_23
{
    public partial class Form1 : Form
    {
        List<Student> students;
        List<Aspirant> aspirants;
        List<Employe> employes;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            students = new List<Student>();
            aspirants = new List<Aspirant>();
            employes = new List<Employe>();

            students.Add(new Student("Иван", "Петров", new DateTime(2003, 5, 14), "АГУ", "ИМиИТ", 4510052));
            students.Add(new Student("Сергей", "Иванов", new DateTime(2002, 8, 24), "АГУ", "ИМиИТ", 7986797));
            students.Add(new Student("Иван", "Петров", new DateTime(2003, 3, 21), "АГУ", "ИМиИТ", 2357823));

            aspirants.Add(new Aspirant("Семен", "Егоров", new DateTime(2000, 5, 24), "АГУ", "ИМиИТ", 4572262, "Архитектуры баз данных"));
            aspirants.Add(new Aspirant("Андрей", "Шумаков", new DateTime(1999, 4, 7), "АГУ", "ИМиИТ", 5474577, "Программные технологии"));
            aspirants.Add(new Aspirant("Дмитрий", "Микушин", new DateTime(1997, 3, 1), "АГУ", "ИМиИТ", 5645644, "Архитектуры программных систем"));

            employes.Add(new Employe("Андрей", "Шумаков", new DateTime(1979, 4, 3), "АГУ", "Преподаватель"));
            employes.Add(new Employe("Дмитрий", "Микушин", new DateTime(1981, 3, 2), "АГУ", "Системный администратор"));


        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (students != null && students.Count > 0)
            {
                string output = "";

                foreach (var student in students)
                {
                    output += student.ToString();
                }

                MessageBox.Show(output);
            }

            if (aspirants != null && aspirants.Count > 0)
            {
                string output = "";

                foreach (var aspirant in aspirants)
                {
                    output += aspirant.ToString();
                }

                MessageBox.Show(output);
            }

            if (employes != null && employes.Count > 0)
            {
                string output = "";

                foreach (var employe in employes)
                {
                    output += employe.ToString();
                }

                MessageBox.Show(output);
            }
        }

        private void personInfoButton_Click(object sender, EventArgs e)
        {
            List<Person> personsList = new List<Person>();

            personsList.AddRange(students);
            personsList.AddRange(aspirants);
            personsList.AddRange(employes);

            string output = "";
            foreach (var person in personsList)
                output += person.ToString();

            MessageBox.Show(output);
        }
    }
}