using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e) {
            colorEdit1.ShowPopup();
        }

        private void Form1_Load(object sender, EventArgs e) {
            colorEdit1.Properties.ShowCustomColors = false;
        }

    }
}