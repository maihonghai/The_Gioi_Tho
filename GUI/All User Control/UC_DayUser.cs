using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.All_Calendar_Control
{
    public partial class UC_DayUser : UserControl
    {
        private FlowLayoutPanel _flowLayoutPanel;

        public event EventHandler<DateTime> DaySelected;

        public bool IsBusy { get; set; }

        public string DayText // Thêm thuộc tính này để truy cập vào Text của label1 từ bên ngoài
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public int Year { get; set; }
        public int Month { get; set; }

        public DateTime SelectedDate { get; private set; }

        public UC_DayUser(DateTime date)
        {
            InitializeComponent();
            SelectedDate = date;
            label1.Text = date.Day.ToString();
        }

        public UC_DayUser(FlowLayoutPanel flowLayoutPanel, string day)
        {
            InitializeComponent();
            label1.Text = day;
            _flowLayoutPanel = flowLayoutPanel;
            checkBox1.Hide();
            //SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, int.Parse(day));

            // Kiểm tra và chuyển đổi chuỗi day sang kiểu số nguyên
            int dayValue;
            if (int.TryParse(day, out dayValue))
            {
                // Nếu chuyển đổi thành công, sử dụng giá trị dayValue để tạo đối tượng DateTime
                SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayValue);
            }
            else
            {
                // Nếu không thành công, gán ngày hiện tại cho SelectedDate
                SelectedDate = DateTime.Today;
                // Hoặc có thể xử lý thông báo lỗi hoặc hành động phù hợp khác ở đây
            }
        }

        public UC_DayUser(FlowLayoutPanel flowLayoutPanel, string day, bool isBusy)
        {
            /*InitializeComponent();
            label1.Text = day;
            _flowLayoutPanel = flowLayoutPanel;
            checkBox1.Hide();

            IsBusy = isBusy;

            SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, int.Parse(day));

            // Đặt màu và trạng thái cho UC_DayUser dựa trên trạng thái bận rộn của ngày
            if (isBusy)
            {
                this.panel1.BackColor = Color.Orange; // Đặt màu cam cho ngày thợ bận
                this.Enabled = false; // Không cho phép chọn ngày thợ bận
            }*/

            InitializeComponent();
            label1.Text = day;
            _flowLayoutPanel = flowLayoutPanel;
            checkBox1.Hide();

            IsBusy = isBusy;

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int dayValue;

            // Kiểm tra và chuyển đổi chuỗi day sang kiểu số nguyên
            if (int.TryParse(day, out dayValue))
            {
                // Kiểm tra xem ngày có hợp lệ không
                if (dayValue >= 1 && dayValue <= DateTime.DaysInMonth(year, month))
                {
                    SelectedDate = new DateTime(year, month, dayValue);

                    // Đặt màu và trạng thái cho UC_DayUser dựa trên trạng thái bận rộn của ngày
                    if (isBusy)
                    {
                        this.panel1.BackColor = Color.Orange; // Đặt màu cam cho ngày thợ bận
                        this.Enabled = false; // Không cho phép chọn ngày thợ bận
                    }
                }
                else
                {
                    // Nếu ngày không hợp lệ, sử dụng ngày mặc định là ngày hiện tại
                    SelectedDate = DateTime.Today;
                    // Hoặc có thể xử lý thông báo lỗi hoặc hành động phù hợp khác ở đây
                }
            }
            else
            {
                // Nếu không chuyển đổi được, sử dụng ngày mặc định là ngày hiện tại
                SelectedDate = DateTime.Today;
                // Hoặc có thể xử lý thông báo lỗi hoặc hành động phù hợp khác ở đây
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(Year, Month, int.Parse(label1.Text));
            DateTime currentDate = DateTime.Today;

            if (selectedDate < currentDate)
            {
                MessageBox.Show("Không thể chọn ngày trong quá khứ.");
                return;
            }


            foreach (Control control in _flowLayoutPanel.Controls)
            {
                if (control is UC_DayUser ucDay)
                {
                    // Loại bỏ chọn các UC_DayUser ngoại trừ sender
                    if (ucDay != sender && ucDay.IsBusy == false)
                    {
                        ucDay.checkBox1.Checked = false;
                        ucDay.panel1.BackColor = Color.White;
                    }
                }
            }

            checkBox1.Checked = true; // Đặt checkBox1.Checked thành true khi người dùng nhấp vào ngày
            this.panel1.BackColor = Color.Green;

            // Kích hoạt sự kiện DaySelected và truyền ngày được chọn
            DaySelected?.Invoke(this, SelectedDate);
        }

        public void XuLyNgayTrongQuaKhu(DateTime current)
        {
            if (current < DateTime.Today)
            {
                this.label1.ForeColor = Color.LightGray; // Đặt màu xams cho ngày trong qua khu
                this.Enabled = false; // Không cho phép chọn ngày trong qua khu
            }
        }

    }
}
