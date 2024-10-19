using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private StudentBLL studentBLL = new StudentBLL();
        private BindingSource bindingSource = new BindingSource();

        private int currentIndex = 0;
        private List<Students> studentsList;
        public Form1()
        {
            InitializeComponent();
        }

        private void txb_MSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Diem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_ChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txb_HoTen.Text;
                int age = int.Parse(txb_Diem.Text);
                string major = cmb_ChuyenNganh.SelectedItem?.ToString();

                studentBLL.AddStudent(fullName, age, major);
                LoadData(); // Tải lại dữ liệu sau khi thêm mới
                MessageBox.Show("Thêm sinh viên thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource.Current != null)
                {
                    Students currentStudent = (Students)bindingSource.Current;
                    currentStudent.FullName = txb_HoTen.Text;

                    // Kiểm tra giá trị của txb_Diem trước khi gán cho Age
                    if (!string.IsNullOrEmpty(txb_Diem.Text))
                    {
                        currentStudent.Age = int.Parse(txb_Diem.Text);
                    }
                    else
                    {
                        currentStudent.Age = null; // Nếu không có giá trị thì gán null
                    }

                    currentStudent.Major = cmb_ChuyenNganh.SelectedItem?.ToString();

                    studentBLL.UpdateStudent(currentStudent.StudentId, currentStudent.FullName, currentStudent.Age ?? 0, currentStudent.Major);
                    LoadData(); // Tải lại dữ liệu sau khi sửa
                    MessageBox.Show("Sửa sinh viên thành công.");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sinh viên: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource.Current != null)
                {
                    Students currentStudent = (Students)bindingSource.Current;
                    studentBLL.DeleteStudent(currentStudent.StudentId);
                    LoadData(); // Tải lại dữ liệu sau khi xóa
                    MessageBox.Show("Xóa sinh viên thành công.");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
            }
        }

        private void dgv_ThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_ThongTin.Rows[e.RowIndex];

                    // Hiển thị StudentId lên TextBox txb_MSSV
                    txb_MSSV.Text = row.Cells[0].Value.ToString();

                    // Hiển thị các trường khác lên các TextBox tương ứng
                    txb_HoTen.Text = row.Cells[1].Value.ToString();
                    txb_Diem.Text = row.Cells[2].Value.ToString();
                    cmb_ChuyenNganh.SelectedItem = row.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn sinh viên: " + ex.Message);
            }
        }
        private void DisplayCurrentStudent()
        {
            if (studentsList != null && studentsList.Count > 0 && currentIndex >= 0 && currentIndex < studentsList.Count)
            {
                Students currentStudent = studentsList[currentIndex];
                txb_MSSV.Text = currentStudent.StudentId.ToString();
                txb_HoTen.Text = currentStudent.FullName;
                txb_Diem.Text = currentStudent.Age.ToString();
                cmb_ChuyenNganh.SelectedItem = currentStudent.Major;

                // Cập nhật dòng được chọn trong DataGridView theo chỉ số của sinh viên hiện tại
                dgv_ThongTin.ClearSelection(); // Xóa lựa chọn hiện tại
                dgv_ThongTin.Rows[currentIndex].Selected = true; // Chọn dòng tương ứng với currentIndex
                dgv_ThongTin.FirstDisplayedScrollingRowIndex = currentIndex; // Đảm bảo dòng được chọn luôn hiển thị
            }
        }


        private void LoadData()
        {
            try
            {
                studentsList = studentBLL.GetStudents(); // Lưu danh sách sinh viên vào biến studentsList
                bindingSource.DataSource = studentsList; // Gán danh sách sinh viên vào BindingSource

                // Liên kết BindingSource với DataGridView
                dgv_ThongTin.DataSource = bindingSource;

                // Điều chỉnh kích thước cột để phù hợp với DataGridView
                dgv_ThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Sử dụng Data Binding để liên kết các TextBox và ComboBox với các thuộc tính của đối tượng
                txb_MSSV.DataBindings.Clear();
                txb_HoTen.DataBindings.Clear();
                txb_Diem.DataBindings.Clear();
                cmb_ChuyenNganh.DataBindings.Clear();

                txb_MSSV.DataBindings.Add("Text", bindingSource, "StudentId");
                txb_HoTen.DataBindings.Add("Text", bindingSource, "FullName");
                txb_Diem.DataBindings.Add("Text", bindingSource, "Age");
                cmb_ChuyenNganh.DataBindings.Add("SelectedItem", bindingSource, "Major");
                dgv_ThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_ThongTin.Refresh(); // Làm mới DataGridView để hiển thị dữ liệu mới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu vào DataGridView: " + ex.Message);
            }
        }


        private void LoadMajors()
        {
            try
            {
                List<string> majors = studentBLL.GetMajors();
                cmb_ChuyenNganh.DataSource = majors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ngành học: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.schoolDBDataSet.Students);
            try
            {
                LoadData();  // Tải dữ liệu sinh viên vào danh sách
                LoadMajors();  // Tải danh sách ngành học vào ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.MovePrevious(); // Di chuyển đến bản ghi trước đó
            }
            else
            {
                MessageBox.Show("Bạn đang ở sinh viên đầu tiên.");
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.MoveNext(); // Di chuyển đến bản ghi tiếp theo
            }
            else
            {
                MessageBox.Show("Bạn đang ở sinh viên cuối cùng.");
            }
        }
    }
}
