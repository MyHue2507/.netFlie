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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            try
            {
                errProvider.Clear();
                double temp = 0;
                if (!double.TryParse(txtSoThuNhat.Text, out temp))
                {
                    //MessageBox.Show("Số thứ nhất của bạn không đúng định dạng");
                    errProvider.SetError(txtSoThuNhat, "Số thứ nhất của bạn không đúng định dạng");
                    txtSoThuNhat.Focus();
                    return;
                }
                if (!double.TryParse(txtSoThuHai.Text, out temp))
                {
                    //MessageBox.Show("Số thứ hai của bạn không đúng định dạng");
                    errProvider.SetError(txtSoThuHai, "Số thứ hai của bạn không đúng định dạng");
                    txtSoThuHai.Focus();
                    return;
                }

                var soThuNhat = double.Parse(txtSoThuNhat.Text);
                var soThuHai = double.Parse(txtSoThuHai.Text);
                var ketQua = 0d;
                var ketQuaPhepTinh = "";
                switch (cmbPhepToan.SelectedIndex)
                {
                    case 0:
                        {
                            MessageBox.Show("Vui lòng chọn phép tính trước");
                            return;
                        }
                    case 1:
                        {
                            ketQua = soThuNhat + soThuHai;
                            ketQuaPhepTinh = "Tổng";
                            break;
                        }
                    case 2:
                        {
                            ketQua = soThuNhat - soThuHai;
                            ketQuaPhepTinh = "Hiệu";
                            break;
                        }
                    case 3:
                        {
                            ketQua = soThuNhat * soThuHai;
                            ketQuaPhepTinh = "Tích";
                            break;
                        }
                    case 4:
                        {
                            ketQua = soThuNhat / soThuHai;
                            ketQuaPhepTinh = "Thương";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Vui lòng chọn phép tính trước");
                            return;
                        }
                }

                var chuoiKetQua = string.Format("{0} của {1} và {2} là {3}",
                  ketQuaPhepTinh, soThuNhat, soThuHai, ketQua);
                MessageBox.Show(chuoiKetQua);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi bạn ơi. Chi tiết lỗi: " + ex.Message);
            }
        }
    }
}
