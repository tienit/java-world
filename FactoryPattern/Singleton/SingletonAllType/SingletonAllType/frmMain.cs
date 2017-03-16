using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingletonAllType
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Singleton4 abc = new Singleton4();

        }

        private void btn_Version_01_Click(object sender, EventArgs e)
        {
            frmPic m_Pic = new frmPic();
            m_Pic.Text = "First version – not thread-safe";
            m_Pic.picView.Image = Properties.Resources.Singleton_Level_01;
            m_Pic.ShowDialog();
        }

        private void btn_Version_02_Click(object sender, EventArgs e)
        {
            frmPic m_Pic = new frmPic();
            m_Pic.Text = "Second version – simple thread safety";
            m_Pic.picView.Image = Properties.Resources.Singleton_Level_02;
            m_Pic.ShowDialog();
        }

        private void btn_Version_03_Click(object sender, EventArgs e)
        {
            frmPic m_Pic = new frmPic();
            m_Pic.Text = "Third version – attempted thread-safety using double-check locking";
            m_Pic.picView.Image = Properties.Resources.Singleton_Level_03;
            m_Pic.ShowDialog();
        }

        private void btn_Version_04_Click(object sender, EventArgs e)
        {
            frmPic m_Pic = new frmPic();
            m_Pic.Text = "Fourth version – not quite as lazy, but thread-safe without using locks";
            m_Pic.picView.Image = Properties.Resources.Singleton_Level_04;
            m_Pic.ShowDialog();
        }

        private void btn_Version_05_Click(object sender, EventArgs e)
        {
            frmPic m_Pic = new frmPic();
            m_Pic.Text = "Fifth version – fully lazy instantiation";
            m_Pic.picView.Image = Properties.Resources.Singleton_Level_05;
            m_Pic.ShowDialog();
        }
    }
}
