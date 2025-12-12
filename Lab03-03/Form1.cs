using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class Form1 : Form
    {
        private const string DATA_FILE = "students.txt";
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentID", HeaderText = "MSSV", DataPropertyName = "StudentID" });
            dgvStudent.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", HeaderText = "Họ tên", DataPropertyName = "FullName" });
            dgvStudent.Columns.Add(new DataGridViewTextBoxColumn { Name = "AverageScore", HeaderText = "Điểm TB", DataPropertyName = "AverageScore" });
            dgvStudent.Columns.Add(new DataGridViewTextBoxColumn { Name = "Faculty", HeaderText = "Khoa", DataPropertyName = "Faculty" });

            dgvStudent.CellDoubleClick += dgvStudent_CellDoubleClick;

            LoadStudentsFromFile();
            RefreshGrid();
        }

        private void LoadStudentsFromFile()
        {
            studentList.Clear();

            if (!File.Exists(DATA_FILE))
            {
                CreateSampleData();
                SaveStudentsToFile();
            }

            try
            {
                using (StreamReader sr = new StreamReader(DATA_FILE, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 4)
                        {
                            studentList.Add(new Student
                            {
                                StudentID = parts[0],
                                FullName = parts[1],
                                AverageScore = double.Parse(parts[2]),
                                Faculty = parts[3]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateSampleData()
        {
            studentList = new List<Student>
            {
                new Student { StudentID = "SV001", FullName = "Nguyễn Văn A", AverageScore = 8.5, Faculty = "Công nghệ thông tin" },
                new Student { StudentID = "SV002", FullName = "Trần Thị B", AverageScore = 7.2, Faculty = "Ngôn ngữ Anh" },
                new Student { StudentID = "SV003", FullName = "Lê Văn C", AverageScore = 9.0, Faculty = "Công nghệ thông tin" },
                new Student { StudentID = "SV004", FullName = "Phạm Thị D", AverageScore = 6.8, Faculty = "Quản trị kinh doanh" },
                new Student { StudentID = "SV005", FullName = "Hoàng Văn E", AverageScore = 8.0, Faculty = "Công nghệ thông tin" }
            };
        }

        private void SaveStudentsToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(DATA_FILE, false, Encoding.UTF8))
                {
                    foreach (var student in studentList)
                    {
                        sw.WriteLine($"{student.StudentID}|{student.FullName}|{student.AverageScore:F2}|{student.Faculty}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshGrid()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var filtered = string.IsNullOrEmpty(keyword)
                ? studentList
                : studentList.Where(s => s.FullName.ToLower().Contains(keyword)).ToList();

            dgvStudent.DataSource = null;
            dgvStudent.DataSource = filtered;
        }

        // === THÊM MỚI ===
        private void OpenAddStudentForm()
        {
            FormAddStudent form = new FormAddStudent();
            form.OnAddStudent += (student) =>
            {
                if (studentList.Any(s => s.StudentID == student.StudentID))
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                studentList.Add(student);
                RefreshGrid();
                SaveStudentsToFile();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            form.ShowDialog();
        }

        // === CẬP NHẬT ===
        private void OpenEditStudentForm(Student studentToEdit)
        {
            FormAddStudent form = new FormAddStudent(studentToEdit);
            form.OnUpdateStudent += (updatedStudent) =>
            {
                var existing = studentList.FirstOrDefault(s => s.StudentID == updatedStudent.StudentID);
                if (existing != null)
                {
                    existing.FullName = updatedStudent.FullName;
                    existing.AverageScore = updatedStudent.AverageScore;
                    existing.Faculty = updatedStudent.Faculty;
                    RefreshGrid();
                    SaveStudentsToFile();
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            form.ShowDialog();
        }

        // === DOUBLE-CLICK ĐỂ SỬA ===
        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                Student selected = new Student
                {
                    StudentID = row.Cells["StudentID"].Value?.ToString() ?? "",
                    FullName = row.Cells["FullName"].Value?.ToString() ?? "",
                    AverageScore = double.Parse(row.Cells["AverageScore"].Value?.ToString() ?? "0"),
                    Faculty = row.Cells["Faculty"].Value?.ToString() ?? ""
                };
                OpenEditStudentForm(selected);
            }
        }

        // === XÓA SINH VIÊN ===
        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvStudent.SelectedRows[0];
            string studentID = selectedRow.Cells["StudentID"].Value?.ToString();

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                studentList.RemoveAll(s => s.StudentID == studentID);
                RefreshGrid();
                SaveStudentsToFile();
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // === MENU & TOOLBAR ===
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddStudentForm();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            OpenAddStudentForm();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                OpenAddStudentForm();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvStudent.SelectedRows[0];
            string studentID = selectedRow.Cells["StudentID"].Value?.ToString();

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                studentList.RemoveAll(s => s.StudentID == studentID);
                RefreshGrid();
                SaveStudentsToFile();
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}