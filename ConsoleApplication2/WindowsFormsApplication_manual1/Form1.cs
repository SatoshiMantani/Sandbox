using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_manual1 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      MessageBox.Show("こんんちは！", "タイトル");

    }

    private void Form1_Load(object sender, EventArgs e) {
      Text = "練習プログラム";
    }

    private void button1_MouseEnter(object sender, EventArgs e) {
      button1.Text = "接近！";
    }
  }
}
