using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_NHANSU
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmManHinhChinh());
        }

        
        //hàm xử lý bấm số và ký tự số, mặc định không truyền chiều dài thì mặc định là 200
        public static void HandleNumberKeyPress(object sender, KeyPressEventArgs e, string errorMessage, int? length = 200)
        {
            TextBox textBox = sender as TextBox;
            ToolTip toolTip = new ToolTip();
          
            // kiểm tra nếu không phải là số hoặc là phím điều khiển 
            if (textBox != null && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                //ngăn chặn kí tự nhập vào
                e.Handled = true;
                


                // Hiển thị thông báo lỗi bằng ToolTip
                toolTip.Show(errorMessage, textBox, 0, -20, 700);
                // kiểm tra nếu độ dài quy định thì báo lỗi
            } else if (textBox.Text.Length >= length && e.KeyChar != (char)Keys.Back)
            {
                
                e.Handled = true;
                toolTip.Show($"Chỉ được nhập {length} số thôi ", textBox, 0, -20, 700);
            }
           
           
        }
        public static void HandleDemicalNumberKeyPress(object sender, KeyPressEventArgs e, string errorMessage, int? length = 200)
        {
            TextBox textBox = sender as TextBox;
            ToolTip toolTip = new ToolTip();

            // Kiểm tra xem ký tự được nhập có phải là số, dấu chấm thập phân hoặc ký tự điều khiển không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                //ngăn chặn kí tự nhập vào
                e.Handled = true;



                // Hiển thị thông báo lỗi bằng ToolTip
                toolTip.Show(errorMessage, textBox, 0, -20, 700);
                
            }

            // Nếu có dấu chấm thập phân, chỉ cho phép một dấu chấm thập phân
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Từ chối thêm dấu chấm thập phân
                toolTip.Show($"Sai định dạng số thập phân", textBox, 0, -20, 700);
            }


        }


    }
   
}
