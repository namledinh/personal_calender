using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Personal_Calendar
{
    public partial class Form1 : Form
    {
        #region

        private string filePath = "data.xml";


        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private int appTime;
        public int AppTime
        {
            get { return appTime; }
            set { appTime = value; }
        }

        private PlanData job;
        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        private List<string> dateofWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday", "Sunday"};
        #endregion
        public Form1()
        {
            InitializeComponent();

            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\Personal_Calendar");
            //mo registry khoi dong cung win
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            //string subkey = "Software\\ManhQuyen";
            try
            {
                //chen gia tri key
                regkey.SetValue("Index", keyvalue);
                //regstart.SetValue("taoregistrytronghethong", "E:\\Studing\\Bai Tap\\CSharp\\Channel 4\\bai temp\\tao registry trong he thong\\tao registry trong he thong\\bin\\Debug\\tao registry trong he thong.exe");
                regstart.SetValue("Personal_Calendar", Application.StartupPath + "\\Personal_Calendar.exe");
                ////dong tien trinh ghi key
                //regkey.Close();
            }
            catch (System.Exception ex)
            {
            }

            tmNotify.Start();
            appTime = 0;
            LoadMatrix();
            // Kiểm tra nếu đã có file.xml thì mở dữ liệu từ file lên.
            try
            {
               Job = DeserializeFromXLM(filePath) as PlanData;
            }
            // Nếu không có file.xml thì chạy hàm SetDefaultJob() với dữ liệu cho trước.
            catch
            {
                SetDefaultJob(); 
            }
        }
        void SetDefaultJob()
        {
            job = new PlanData();
            Job.Job = new List<PlanIteam>();
            Job.Job.Add(new PlanIteam() 
            { 
                Date = DateTime.Now, 
                FromTime = new Point(4,0), 
                ToTime = new Point(5,0), 
                Job = "Data mẫu", 
                Status = PlanIteam.ListStatus[(int)EPlanIteam.COMING] 
            });
        }

        /// <summary>
        /// /
        /// </summary>
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() {Width =0, Height = 0, Location = new Point(-Cons.margin, 0) };

            for(int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for(int j = 0; j<Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight};
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);

                    btn.Click += Btn_Click;

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight + Cons.margin) };
            }
            SetDefauDate();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            daily.ShowDialog();
        }
        int DayOfMonth(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                    case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int line = 0;

            for(int i = 1; i <= DayOfMonth(date); i++)
            {

                int column = dateofWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if(isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.LightPink;
                } 

                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }
        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        void ClearMatrix()
        {
            for(int i=0; i<Matrix.Count; i++)
            {
                for(int j=0; j<Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }
        
        void SetDefauDate()
        {
            dtpkDate.Value = DateTime.Now;
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }
        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefauDate();
        }
        //Lưu trữ dữ liệu xuống file
        private void SeriallizeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs, data);
            fs.Close();
        }
        //Lấy dữ liệu dưới file lên
        private object DeserializeFromXLM(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception e)
            {
                fs.Close();
                throw new NotFiniteNumberException();
            }
        }
        //Khi form đóng lại thì sẽ lưu dữ liệu xuống file xml
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SeriallizeToXML(Job, filePath);
        }
        private void tmNotify_Tick(object sender, EventArgs e)
        {
            if(!cbThongbao.Checked)
                return;
            AppTime++;

            if (AppTime < Cons.notifyTime)
                return;
            if (Job == null || Job.Job == null)
                return;

            DateTime currentDate = DateTime.Now;
            List<PlanIteam> todayjob = Job.Job.Where(x =>x.Date.Year == currentDate.Year && x.Date.Month == currentDate.Month && x.Date.Day == currentDate.Day).ToList();
            Notify.ShowBalloonTip(Cons.notifyTimeOut, "Công việc cần làm hôm nay", string.Format("Bạn có {0} việc trong ngày hôm nay", todayjob.Count), ToolTipIcon.Info);
            
            AppTime = 0;
        }
        private void nmNodify_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)nmNodify.Value;
        }
        private void cbThongbao_CheckedChanged(object sender, EventArgs e)
        {
            nmNodify.Enabled = cbThongbao.Checked;
        }
    }
}
