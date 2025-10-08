namespace Task22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Aqua;
            lblName.ForeColor = Color.Magenta;
            lblAge.ForeColor = Color.Magenta;
            lblId.ForeColor = Color.Magenta;
        }
        List<Student> students = [
            new Student(){Id = 1 , Name = "Osama" , Age = 13},
            new Student(){Id = 2 , Name = "Ali" , Age = 14},
            new Student(){Id = 3 , Name = "Mohamed" , Age = 15}
            ];
        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show( ((Student)cmbStudents.SelectedItem).Name);
            MessageBox.Show(cmbDepartments.SelectedItem.ToString());

            Student student = new Student();
            student.Age = int.Parse(txtAge.Text);
            student.Name = txtName.Text;
            student.Id = int.Parse(txtId.Text);

            if ((MessageBox.Show(student.ToString(), "Student Info", MessageBoxButtons.OKCancel) == DialogResult.OK))
                Text = student.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbStudents.DataSource = students;
            cmbStudents.ValueMember = "Id";
            cmbStudents.DisplayMember = "Name";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
