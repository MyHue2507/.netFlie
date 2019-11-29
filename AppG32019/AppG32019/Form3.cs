using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG32019.Service;
using AppG32019.Model;
namespace AppG32019
{
    public partial class Form3 : Form
    {
        private string pathDataStudent;
        public static string pathDataHistory;
        Student student;
        public Form3(string idStudent)
        {
            InitializeComponent();
            picAnhDaiDien.AllowDrop = true;
            dgvQuaTrinhHocTap.AutoGenerateColumns = false;
            pathDataStudent = Application.StartupPath + @"\Data\student.husc";
            pathDataHistory = Application.StartupPath + @"\Data\history.husc";

            //var student = StudentService.GetStudent(idStudent);
            student = StudentService.GetStudent(pathDataStudent, idStudent);
            if (student != null)
            {
                txtMaSinhVien.Text = student.Id;
                txtHo.Text = student.LastName;
                txtTen.Text = student.FirstName;
                dtpNgaySinh.Value = student.DateOfBirth;
                txtNoiSinh.Text = student.PlaceOfBirth;
                cmbGioiTinh.SelectedIndex = (int)student.Gender;

                student.ListLearningHistory 
                    = LearningHistoryService.GetListFromFile(pathDataHistory, idStudent);
                bdsQuaTrinhHocTap.DataSource = student.ListLearningHistory;
                dgvQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
                lblTongSoMuc.Text = student.ListLearningHistory.Count().ToString();
            }
            else
            {
                throw new Exception("Sinh viên này không tồn tại");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lnkChonAnhDaiDien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chonAnhDaiDien();
        }

        private void picAnhDaiDien_DoubleClick(object sender, EventArgs e)
        {
            chonAnhDaiDien();
        }

        /// <summary>
        /// Chọn ảnh đại diện từ OpenFileDialog
        /// </summary>
        private void chonAnhDaiDien()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File ảnh (*.png, *.jpg)|*.png;*.jpg";
            dialog.Title = "Chọn ảnh đại diện";
            var rs = dialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                picAnhDaiDien.Image = Image.FromFile(fileName);
            }
        }

        private void picAnhDaiDien_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picAnhDaiDien_DragDrop(object sender, DragEventArgs e)
        {
            var listFileName = (string[])e.Data.GetData(DataFormats.FileDrop);
            var fileName = listFileName.FirstOrDefault();
            picAnhDaiDien.Image = Image.FromFile(fileName);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var history = bdsQuaTrinhHocTap.Current as LearningHistory;
            if (history != null)
            {
                LearningHistoryService.Delete(pathDataHistory, history.Id);
                bdsQuaTrinhHocTap.RemoveCurrent();
                MessageBox.Show("Đã xóa thành công #id = " + history.Id);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new Form4(student);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                bdsQuaTrinhHocTap.DataSource = 
                    LearningHistoryService.GetListFromFile(pathDataHistory, student.Id);
                dgvQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var history = bdsQuaTrinhHocTap.Current as LearningHistory;
            if (history != null)
            {
                var f = new Form4(history);
                var rs = f.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    bdsQuaTrinhHocTap.DataSource =
                        LearningHistoryService.GetListFromFile(pathDataHistory, student.Id);
                    dgvQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
                }
            }
        }
    }
}
