using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachineMk2.Core;

namespace VendingMachineMk2 {
    public partial class VendingMachine : Form {
        
        public VendingMachine() {
            InitializeComponent();
            Initialize();
        }

        private void Initialize() {
            T2WindowsFormController.SetView(this);
        }

        private void button1_Click(object sender, EventArgs e) {
        }



    }
}
