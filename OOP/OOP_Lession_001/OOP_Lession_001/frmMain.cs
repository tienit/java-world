using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_Lession_001
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_Dogs_Click(object sender, EventArgs e)
        {
            try
            {
                //Extend
                Dogs obj = new Dogs();

                obj.Name = "Dogs 1088";
                obj.Age = 10;
                obj.Color = "Yellow";

                rtb_Dogs_Inheritance.AppendText("Name: " + obj.Name + Environment.NewLine);
                rtb_Dogs_Inheritance.AppendText("Age: " + obj.Age.ToString() + Environment.NewLine);
                rtb_Dogs_Inheritance.AppendText("Color: " + obj.Color + Environment.NewLine);

                rtb_Dogs_Inheritance.AppendText("GetNumberOfLegs: " + obj.Get_Number_Of_Legs().ToString() + Environment.NewLine);
                rtb_Dogs_Inheritance.AppendText("GetDeclaration: " + obj.Get_Declaration() + Environment.NewLine);

                //Implement
                txt_Dogs_Runnable.AppendText(obj.Run() + Environment.NewLine);
                //txt_Dogs_Flyable.AppendText("Not implement" + Environment.NewLine);
                //txt_Dogs_Climbable.AppendText("Not implement" + Environment.NewLine);
                txt_Dogs_Eatable.AppendText(obj.CanEat() + Environment.NewLine);
            }
            catch (Exception ex)
            {
                rtb_Dogs_Inheritance.Text = ex.Message + Environment.NewLine + ex.StackTrace;
            }
        }

        private void btn_Cats_Click(object sender, EventArgs e)
        {
            try
            {
                //Extend
                Cats obj = new Cats();

                obj.Name = "Cats 2017";
                obj.Age = 3;
                obj.Color = "Black-White";

                rtb_Cats_Inheritance.AppendText("Name: " + obj.Name + Environment.NewLine);
                rtb_Cats_Inheritance.AppendText("Age: " + obj.Age.ToString() + Environment.NewLine);
                rtb_Cats_Inheritance.AppendText("Color: " + obj.Color + Environment.NewLine);

                rtb_Cats_Inheritance.AppendText("GetNumberOfLegs: " + obj.Get_Number_Of_Legs().ToString() + Environment.NewLine);
                rtb_Cats_Inheritance.AppendText("GetDeclaration: " + obj.Get_Declaration() + Environment.NewLine);

                //Implement
                txt_Cats_Runnable.AppendText(obj.Run() + Environment.NewLine);
                //txt_Cats_Flyable.AppendText("Not implement" + Environment.NewLine);
                txt_Cats_Climbable.AppendText(obj.Climb() + Environment.NewLine);
                txt_Cats_Eatable.AppendText(obj.CanEat() + Environment.NewLine);
            }
            catch (Exception ex)
            {
                rtb_Cats_Inheritance.Text = ex.Message + Environment.NewLine + ex.StackTrace;
            }
        }

        private void btn_Birds_Click(object sender, EventArgs e)
        {
            try
            {
                Birds obj = new Birds();

                obj.Name = "Birds 1066";
                obj.Age = 2;
                obj.Color = "White";

                rtb_Birds_Inheritance.AppendText("Name: " + obj.Name + Environment.NewLine);
                rtb_Birds_Inheritance.AppendText("Age: " + obj.Age.ToString() + Environment.NewLine);
                rtb_Birds_Inheritance.AppendText("Color: " + obj.Color + Environment.NewLine);

                rtb_Birds_Inheritance.AppendText("GetNumberOfLegs: " + obj.Get_Number_Of_Legs().ToString() + Environment.NewLine);
                rtb_Birds_Inheritance.AppendText("GetDeclaration: " + obj.Get_Declaration() + Environment.NewLine);

                //Implement
                txt_Birds_Runnable.AppendText(obj.Run() + Environment.NewLine);
                txt_Birds_Flyable.AppendText(obj.Fly() + Environment.NewLine);
                //txt_Birds_Climbable.AppendText("Not implement" + Environment.NewLine);
                txt_Birds_Eatable.AppendText(obj.CanEat() + Environment.NewLine);
            }
            catch (Exception ex)
            {
                rtb_Birds_Inheritance.Text = ex.Message + Environment.NewLine + ex.StackTrace;
            }
        }

        private void btn_Plane_Click(object sender, EventArgs e)
        {
            try
            {
                Plane obj = new Plane();

                obj.Name = "Boeing 747";
                obj.Original = "USA";
                obj.Production_year = new DateTime(1969, 1, 1);
                obj.Type = "BOEING_747";
                obj.Version = "747-8";
                obj.Weight = 306;

                rtb_Plane_Inheritance.AppendText("Name: " + obj.Name + Environment.NewLine);
                rtb_Plane_Inheritance.AppendText("Original: " + obj.Original + Environment.NewLine);
                rtb_Plane_Inheritance.AppendText("Production_year: " + obj.Production_year.ToString("yyyy") + Environment.NewLine);
                rtb_Plane_Inheritance.AppendText("Type: " + obj.Type + Environment.NewLine);
                rtb_Plane_Inheritance.AppendText("Version: " + obj.Version + Environment.NewLine);
                rtb_Plane_Inheritance.AppendText("Weight: " + obj.Weight.ToString() + " tons" + Environment.NewLine);

                rtb_Plane_Inheritance.AppendText("GetPrice: " + obj.Get_Price().ToString() + " USD" + Environment.NewLine);
                rtb_Plane_Inheritance.AppendText("GetCapacity: " + obj.Get_Capacity().ToString() + " passengers" + Environment.NewLine);

                //Implement
                txt_Plane_Runnable.AppendText(obj.Run() + Environment.NewLine);
                txt_Plane_Flyable.AppendText(obj.Fly() + Environment.NewLine);
                //txt_Plane_Climbable.AppendText("Not implement" + Environment.NewLine);
                //txt_Plane_Eatable.AppendText("Not implement" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                rtb_Birds_Inheritance.Text = ex.Message + Environment.NewLine + ex.StackTrace;
            }
        }
    }
}
