using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml;
namespace _7DayToDie_ServerControlPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] Description = {"服务器名称",
                                "服务器描述",
                                "服务器网站",
                                "密码",
                                "欢迎信息",
                                "端口",
                                "可见性",
                                "网络协议",
                                "最大人数",
        };
        XmlNodeList personNodes;
        XmlDocument doc;
        XmlElement rootElem;
        static string  AppPath = Application.StartupPath;
        string file = AppPath+@"\serverconfig.xml";
        string StartBat = AppPath + @"\startdedicated.bat";
        Dictionary<string, int> ServerItem = new Dictionary<string, int>();
        string[] Server_Tag = new string[3] { "ServerPort", "ControlPanelPort", "TelnetPort" };
        
        /// <summary>
        /// 读取本地配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Read_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ServerView.Rows.Clear();
                GetValue(file);
                for (int i = 0; i < personNodes.Count; i++)
                {
                    int index=this.ServerView.Rows.Add();//向dataGridView添加新行
                    ServerView.Rows[index].Cells[0].Value = ((XmlElement)personNodes.Item(i)).GetAttribute("name");
                    ServerView.Rows[index].Cells[1].Value= ((XmlElement)personNodes.Item(i)).GetAttribute("value");
                    
                    //ServerView.Rows[index].Cells[2].Value = Description[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveOptions();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public void GetValue(string xmlPath)
        {
            doc = new XmlDocument();
            doc.Load(xmlPath);
            rootElem = doc.DocumentElement;
            personNodes = rootElem.GetElementsByTagName("property"); //获取property子节点集合
        }

        public void SetServerItem() {
            for (int i = 0; i < personNodes.Count; i++)
            {
                if (((IList)Server_Tag).Contains(((XmlElement)personNodes.Item(i)).GetAttribute("name")))
                {
                    ServerItem[((XmlElement)personNodes.Item(i)).GetAttribute("name")] = Convert.ToInt32(((XmlElement)personNodes.Item(i)).GetAttribute("value"));
                }
            }
        }

        public static bool PortInUse(int port)
        {
            bool inUse = false;

            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                if (endPoint.Port == port)
                {
                    inUse = true;
                    break;
                }
            }
            return inUse;
        }



        public  void SaveOptions()
        {

            for (int i = 0; i < ServerView.Rows.Count; i++)
            {
                object tmp = ServerView.Rows[i].Cells[1].Value;
                if (tmp == null)
                {
                    tmp = "";
                }
                    ((XmlElement)personNodes.Item(i)).SetAttribute("value", tmp.ToString());
            }
            doc.Save(file);
            Log_richTextBox.AppendText(DateTime.Now.ToString() + "\n保存配置成功!\n");
        }

        private void KillProcess(bool flag)
        {
            //获得进程对象，以用来操作  
            System.Diagnostics.Process myproc = new System.Diagnostics.Process();
            //得到所有打开的进程   
            try
            {
                //获得需要杀死的进程名  
                foreach (System.Diagnostics.Process thisproc in System.Diagnostics.Process.GetProcessesByName("7DaysToDie"))
                {
                    //立即杀死进程
                    thisproc.Kill();
                }
                if (flag)
                {
                    Log_richTextBox.AppendText(DateTime.Now.ToString() + "\n清理冲突进程!\n");
                    return;
                }
                Log_richTextBox.AppendText(DateTime.Now.ToString() + "\n服务已停止!\n");
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }

        public void RunServer()
        {
            try
            {
                Process pro = new Process();
                FileInfo file = new FileInfo(StartBat);
                pro.StartInfo.WorkingDirectory = file.Directory.FullName;
                pro.StartInfo.FileName = StartBat;
                pro.StartInfo.CreateNoWindow = false;
                pro.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void ShowPort()
        {
            ServerPort_Label.Text = string.Format("端口:{0}", ServerItem["ServerPort"]);
            WebPort_Label.Text = string.Format("端口:{0}", ServerItem["ControlPanelPort"]);
            TelnetPort_Label.Text = string.Format("端口:{0}", ServerItem["TelnetPort"]);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetValue(file);
            SetServerItem();
            ShowPort();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PortInUse(ServerItem["ControlPanelPort"]))
                Web_Status.ImageLocation = AppPath + "/resource/running.png"; 
            else
                Web_Status.ImageLocation = AppPath + "/resource/stop.png";

            if (PortInUse(ServerItem["TelnetPort"]))
                Tel_Status.ImageLocation = AppPath + "/resource/running.png";
            else
                Tel_Status.ImageLocation = AppPath + "/resource/stop.png";

            if (PortInUse(ServerItem["ServerPort"]))
                Server_Status.ImageLocation = AppPath + "/resource/running.png";
            else
                Server_Status.ImageLocation = AppPath + "/resource/stop.png";

        }

        private void SaveRe_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveOptions();
                SetServerItem();
                KillProcess(false);
                RunServer();
                ShowPort();
                Log_richTextBox.AppendText(DateTime.Now.ToString() + "\n正在重新启动!\n请等待...\n如长时间未启动,请检查配置后.重新启动!\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            KillProcess(false);
        }

        private void Run_btn_Click(object sender, EventArgs e)
        {
            KillProcess(true);
            RunServer();
            Log_richTextBox.AppendText(DateTime.Now.ToString() + "\n正在启动!\n请等待...\n如长时间未启动,请检查配置后.重新启动!\n");
        }

        private void Reboot_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SetServerItem();
                KillProcess(false);
                RunServer();
                ShowPort();
                Log_richTextBox.AppendText(DateTime.Now.ToString() + "\n正在重新启动!\n请等待...\n如长时间未启动,请检查配置后.重新启动!\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Log_richTextBox_TextChanged(object sender, EventArgs e)
        {
            Log_richTextBox.ScrollToCaret();
        }
    }
}
