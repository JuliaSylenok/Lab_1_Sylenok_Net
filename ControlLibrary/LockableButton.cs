using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    [ToolboxBitmap(@"C:\VARIANT 19\2 course\АППЗ\Lab_1_Button\ControlLibrary\LockableButton.ico")]
    public partial class LockableButton : UserControl
    {
        public LockableButton()
        {
            InitializeComponent();
            button.Click += Button_Click;
        }
        private bool isLocked = false;
        private int lockDurationSeconds = 5;

        public event EventHandler MyUnlocked;
        private async void Button_Click(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                Lock();
                await Task.Delay(lockDurationSeconds * 1000);
                Unlock();
            }
        }
        private void Lock()
        {
            isLocked = true;
            button.Enabled = false;
        }

        private void Unlock()
        {
            isLocked = false;
            button.Enabled = true;
            OnUnlocked(EventArgs.Empty);
        }
        protected virtual void OnUnlocked(EventArgs e)
        {
            MyUnlocked?.Invoke(this, e);
        }
        public int MyLockDurationSeconds
        {
            get { return lockDurationSeconds; }
            set { lockDurationSeconds = value; }
        }


    }
}
