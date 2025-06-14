using ClientApp.common.Class;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ClientApp
{
    public partial class MainForm : Form
    {
        public Context Context { get; set; }
        public Controller Controller { get; set; }
        public bool IsLoginSuccess { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Context = new Context();
            Controller = new Controller(Context);
            LoginForm loginForm = new LoginForm(Context, this);
            flow_chat.Scroll += async (sender, e) =>
            {
                if (flow_chat.VerticalScroll.Value == VerticalScroll.Minimum)
                    await Controller.LoadConservation(this);
            };
            flow_chat.MouseWheel += async (sender, e) =>
            {
                if (flow_chat.VerticalScroll.Value == VerticalScroll.Minimum)
                    await Controller.LoadConservation(this);
            };
            loginForm.Show();
            Task reading = Task.Run(() =>
            {
                while (!IsLoginSuccess) { }
                try
                {
                    Controller.HandleReadingTask(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading data from the server: " + ex.Message, "Error");
                    MessageBox.Show(ex.StackTrace);
                }
            });

        }
        public void ShowUser(UserInfo userInfo)
        {
            UCcontacts btn = new UCcontacts
            {
                Size = new Size(flow_UserList.Width, 112),
                avt = IconChar.UserCircle,
                username = userInfo.Name,
                status = "Online"
            };
            //IconButton btn = new IconButton()
            //{
            //    Text = userInfo.Name,
            //    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(47))))),
            //    FlatStyle = FlatStyle.Flat,
            //    ForeColor = Color.LightGray,
            //    IconChar = IconChar.UserCircle,
            //    IconSize = 80,
            //    IconColor = System.Drawing.SystemColors.GradientInactiveCaption,
            //    IconFont = IconFont.Solid,
            //    ImageAlign = ContentAlignment.MiddleLeft,
            //    Size = new Size(flow_UserList.Width, 100),
            //    Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0),
            //    UseVisualStyleBackColor = false
            //};
            btn.Click += async (sender, e) =>
            {
                if (userInfo.Id != Context.DestinationId)
                {
                    lb_UserChat.Text = userInfo.Name;
                    lb_UserChat.Visible = true;
                    pic_User.Show();
                    flow_chat.Controls.Clear();
                    Context.Reset(userInfo.Id);
                    await Controller.LoadConservation(this);

                }
            };
            AddControlToPanel(flow_UserList, btn);
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            ((MainForm)sender).Hide();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Context.TcpClient.Dispose();
            Context.Writer.Dispose();
            Context.Reader.Dispose();
        }
        public void ShowUsers()
        {
            foreach (UserInfo userInfo in Context.Users)
            {
                if (userInfo.Id != Context.MyId)
                    ShowUser(userInfo);
            }
        }

        public void AddControlToPanel(Panel panel, Control control, bool IsPastObject = false)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new MethodInvoker(() => panel.Controls.Add(control)));
            }
            else
            {
                panel.Controls.Add(control);
            } 
            if (IsPastObject)
            {
                panel.Controls.SetChildIndex(control, 0);
            }
        }
        public void ShowChatObject(ChatObject chatObject, bool IsPastObject)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                AutoSize = true,
                MinimumSize = new Size(flow_chat.Width - 40, 0),
                Padding = new Padding(10, 0, 0, 0)
            };

            IconPictureBox icon = new IconPictureBox
            {
                IconChar = IconChar.UserCircle,
                IconColor = System.Drawing.SystemColors.GradientActiveCaption,
                IconFont = IconFont.Solid,
                Size = new Size(60, 60),
                Padding = new Padding(5)
            };

            if (chatObject.Source == Context.MyId)
            {
                flp.FlowDirection = FlowDirection.RightToLeft;
            }
            else
            {
                flp.Controls.Add(icon);
                flp.FlowDirection = FlowDirection.LeftToRight;
            }

            ToolTip tooltip = new ToolTip
            {
                BackColor = Color.Aqua
            };

            int height = 0;

            if (chatObject is HistoryMessage)
            {
                ((MsControl)chatObject.Control).MaximumSize = new Size(flow_chat.Width / 2 + 50, 0);
                height = (((MsControl)chatObject.Control)).Height;
            }
            else
            {
                MyFileInfo file = (MyFileInfo)chatObject;
                if (Controller.IsImageFile(file.fileName))
                {
                    ((PictureBox)chatObject.Control).Size = new Size(flow_chat.Width / 2 + 50, 200);
                    height = ((PictureBox)chatObject.Control).Height;
                }
                else
                {
                    ((Label)chatObject.Control).MaximumSize = new Size(flow_chat.Width / 2 + 50, 0);
                    height = ((Label)chatObject.Control).Height;
                }
            }

            try
            {
                tooltip.SetToolTip(chatObject.Control, "Gửi lúc : " + chatObject.CreateAt.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("[LỖI] Tooltip.SetToolTip thất bại: " + ex.Message);
            }
            AddControlToPanel(flp, chatObject.Control);

            AddControlToPanel(flow_chat, flp, IsPastObject);
            flow_chat.ScrollControlIntoView(flp);
        }

        private void AddControlToPanel(Guna2GradientPanel panel, FlowLayoutPanel control, bool IsPastObject)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new MethodInvoker(() => panel.Controls.Add(control)));
            }
            else
            {
                panel.Controls.Add(control);
            }
            if (IsPastObject)
            {
                panel.Controls.SetChildIndex(control, 0);
            }
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            if (Context.DestinationId == 0)
            {
                MessageBox.Show("Please choice a destination user to communicate", "Notification");
            }
            else
            {
                if (txt_Message.Text != "")
                {
                    Controller.SendMessage(txt_Message.Text, this);
                    txt_Message.Text = "";
                }
            }
        }

        private void bt_Gift_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_ChoiceFile = new OpenFileDialog
            {
                Title = "Chọn file cần gửi",
                Filter = "Hình ảnh|*.jpg|Hình ảnh|*.png|Hình ảnh|*.jpeg|text file|*.txt|word file|*.doc|excel file|*.xlsx|pdf file|*.pdf",
            };
            if (ofd_ChoiceFile.ShowDialog() == DialogResult.OK)
            {
                Controller.SendFile(ofd_ChoiceFile.FileName, this);
            }
        }

        private void txt_Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                if (Context.DestinationId == 0)
                {
                    MessageBox.Show("Please choice a destination user to communicate", "Notification");
                }
                else
                {
                    if (txt_Message.Text != "")
                    {
                        Controller.SendMessage(txt_Message.Text, this);
                        txt_Message.Text = "";
                    }
                }
            }
        }
    }
}
