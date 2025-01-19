using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using Guna.UI2.WinForms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
namespace Vøro
{
    public partial class Main : Form
    {
        private const bool n = false;
        public Point mouseLocation;
        public Main()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            try
            {
                await Editor.EnsureCoreWebView2Async(null);
                Editor.CoreWebView2.Navigate(new Uri($"file:///{Directory.GetCurrentDirectory()}/Editor/index.html").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing WebView2: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Editor.ExecuteScriptAsync($"SetText(``);");
        }

        private async void Execute_Click(object sender, EventArgs e)
        {
            string scriptToExecute = await Editor.ExecuteScriptAsync("GetText();");
            string rawScript = JsonConvert.DeserializeObject<string>(scriptToExecute);
            VoroAPI.VoroAPI.ExecuteScript(rawScript);
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            VoroAPI.VoroAPI.AttachAPI();
        }

        private void Editor_Click(object sender, EventArgs e)
        {

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Guna2button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void WindowBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/6KzamqYD");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show(this); // pass in this instance of Main as the "owner" of settings
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
             Form3 areyousure = new Form3();
             areyousure.Show();
            //var selectedOption = MessageBox.Show("Are you sure you'd like to close Vøro?", "Vøro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the no button was pressed ...
          //  if (selectedOption == DialogResult.Yes)
          //  {
          //      Application.Exit();
         //   }
         //   else if (selectedOption == DialogResult.No)
            {
               
            }
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        internal class WebViewInTab : WebView2
        {
            TabControl tabCtrl;
            private object tabControl1;

            public WebViewInTab(TabControl tabCtrl) : base()
            {
                Dock = DockStyle.Fill; // necessary for showing 
                this.tabCtrl = tabCtrl; // for adding new TabPage controls
                CoreWebView2InitializationCompleted += WebViewInTab_CoreWebView2InitializationCompleted;
            }

            private void WebViewInTab_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
            {
                CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested; // This is the man
                CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged; // Just cosmetic code
            }

            private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
            {
                e.Handled = true; // let the default new window 

                TabPage tpage = new TabPage(); // boy

                tpage.Controls.Add(new WebViewInTab(tabCtrl) { Source = new Uri(e.Uri) }); // toy

                tabCtrl.TabPages.Add(tpage); // daddy
                tabCtrl.SelectedTab = tpage; // user expectation
            }

            //Just cosmetic code
            private void CoreWebView2_DocumentTitleChanged(object sender, object e)
            {
                int last = tabCtrl.TabPages.Count - 1;
                tabCtrl.TabPages[last].Text = CoreWebView2.DocumentTitle;
            }

        }
        // ... in Form Main ...
        private void Guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show(this); // pass in this instance of Main as the "owner" of settings
        }

        private Guna2CheckBox GetTopMost()
        {
            return topmostcheckbox;
        }

        private void Guna2CheckBox1_CheckedChanged(object sender, EventArgs e, Guna2CheckBox topmost, Guna2CheckBox v, Guna2CheckBox n)
        {
            if (this.Owner != null && this.Owner is Main)
            {
                Main main = (Main)this.Owner;
                Guna2CheckBox v1 = v;
                main.topmostcheckbox = topmostcheckbox;
            }

        }

        private void TopMost_CheckedChanged(object sender, EventArgs e)
        {
            if (topmostcheckbox.Checked)
           {
                this.TopMost = true;
                this.Focus();
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
                this.Focus();
                this.TopMost = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


