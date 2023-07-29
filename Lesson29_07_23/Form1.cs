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

            students.Add(new Student("����", "������", new DateTime(2003, 5, 14), "���", "�����", 4510052));
            students.Add(new Student("������", "������", new DateTime(2002, 8, 24), "���", "�����", 7986797));
            students.Add(new Student("����", "������", new DateTime(2003, 3, 21), "���", "�����", 2357823));

            aspirants.Add(new Aspirant("�����", "������", new DateTime(2000, 5, 24), "���", "�����", 4572262, "����������� ��� ������"));
            aspirants.Add(new Aspirant("������", "�������", new DateTime(1999, 4, 7), "���", "�����", 5474577, "����������� ����������"));
            aspirants.Add(new Aspirant("�������", "�������", new DateTime(1997, 3, 1), "���", "�����", 5645644, "����������� ����������� ������"));

            employes.Add(new Employe("������", "�������", new DateTime(1979, 4, 3), "���", "�������������"));
            employes.Add(new Employe("�������", "�������", new DateTime(1981, 3, 2), "���", "��������� �������������"));


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