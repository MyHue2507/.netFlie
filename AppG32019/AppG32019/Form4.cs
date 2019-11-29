using AppG32019.Model;
using AppG32019.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG32019
{
    public partial class Form4 : Form
    {
        bool LaThemMoi;
        LearningHistory learningHistory;
        Student student;
        public Form4(Student student)
        {
            InitializeComponent();
            this.Text = "Thêm mới quá trình học tập";
            this.student = student;
            LaThemMoi = true;
        }
        public Form4(LearningHistory history)
        {
            InitializeComponent();
            this.Text = "Chỉnh sửa quá trình học tập";

            this.learningHistory = history;
            numTuNam.Value = history.YearFrom;
            numDenNam.Value = history.YearEnd;
            txtHocTai.Text = history.Address;

            LaThemMoi = false;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (LaThemMoi)
            {
                var history = new LearningHistory
                {
                    Id = Guid.NewGuid().ToString(),
                    YearFrom = (int)numTuNam.Value,
                    YearEnd = (int)numDenNam.Value,
                    Address = txtHocTai.Text,
                    IdStudent = student.Id
                };
                LearningHistoryService.Add(Form3.pathDataHistory, history);
                DialogResult = DialogResult.OK;
            }
            else
            {
                learningHistory.YearFrom =(int) numTuNam.Value;
                learningHistory.YearEnd = (int)numDenNam.Value;
                learningHistory.Address = txtHocTai.Text;
                LearningHistoryService.Update(Form3.pathDataHistory, learningHistory);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
