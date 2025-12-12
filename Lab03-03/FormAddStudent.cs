using System;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class FormAddStudent : Form
    {
        public delegate void AddStudentHandler(Student student);
        public delegate void UpdateStudentHandler(Student student);

        public event AddStudentHandler OnAddStudent;
        public event UpdateStudentHandler OnUpdateStudent;

        private Student editingStudent = null;

        public FormAddStudent(Student studentToEdit = null)
        {
            InitializeComponent();

            cmbFaculty.Items.AddRange(new string[]
            {
                "Công nghệ thông tin",
                "Ngôn ngữ Anh",
                "Quản trị kinh doanh"
            });

            if (studentToEdit != null)
            {
                editingStudent = studentToEdit;
                this.Text = "Cập nhật sinh viên";
                btnAdd.Text = "Cập nhật";

                txtStudentID.Text = studentToEdit.StudentID;
                txtFullName.Text = studentToEdit.FullName;
                txtAverageScore.Text = studentToEdit.AverageScore.ToString("F2");
                cmbFaculty.SelectedItem = studentToEdit.Faculty;

                txtStudentID.Enabled = false;
            }
            else
            {
                cmbFaculty.SelectedIndex = 0;
                txtStudentID.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtAverageScore.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtAverageScore.Text, out double score) || score < 0 || score > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = new Student
            {
                StudentID = txtStudentID.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                AverageScore = Math.Round(score, 2),
                Faculty = cmbFaculty.SelectedItem?.ToString() ?? ""
            };

            if (editingStudent != null)
            {
                OnUpdateStudent?.Invoke(student);
            }
            else
            {
                OnAddStudent?.Invoke(student);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}