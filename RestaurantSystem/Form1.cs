using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Threading; 

namespace RestaurantSystem
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);
        private Thread demoThread = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void ThreadProcSafe() //Thread handeling for clock on mouse move
        {
            this.SetText(DateTime.Now.ToString());
        }

        private void SetText(string text)
        {

            if (this.textBox9.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox9.Text = text;
            }
        }

        private void Pharmacy_MouseMove(object sender, MouseEventArgs e)
        {
            this.demoThread =
                new Thread(new ThreadStart(this.ThreadProcSafe)); // starts thread for clock on mouse movment

            this.demoThread.Start();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox9.Text == "Dessert")
            {
                Meal m = new Meal();
                m.setmealName(textBox4.Text);
                m.setmealType(comboBox9.Text);
                m.setmealPrice(Convert.ToInt32(textBox1.Text));

                m.setmealCategory(comboBox6.Text);
                XML.saveDessert(m);
                MessageBox.Show("Meal added");
            }
            else if (comboBox9.Text == "Main Corse")
            {
                Meal m = new Meal();
                m.setmealName(textBox4.Text);
                m.setmealType(comboBox9.Text);
                m.setmealPrice(Convert.ToInt32(textBox1.Text));

                m.setmealCategory(comboBox6.Text);
                XML.saveMain(m);
                MessageBox.Show("Meal added");
            }
            if (comboBox9.Text == "Salad")
            {
                Meal m = new Meal();
                m.setmealName(textBox4.Text);
                m.setmealType(comboBox9.Text);
                m.setmealPrice(Convert.ToInt32(textBox1.Text));

                m.setmealCategory(comboBox6.Text);
                XML.saveSalad(m);
                MessageBox.Show("Meal added");
            }
            if (comboBox9.Text == "Appetizer")
            {
                Meal m = new Meal();
                m.setmealName(textBox4.Text);
                m.setmealType(comboBox9.Text);
                m.setmealPrice(Convert.ToInt32(textBox1.Text));
                
                m.setmealCategory(comboBox6.Text);
                XML.saveAppetizer(m);
            }
            if (comboBox9.Text == "Alcoholic Drinks")
            {
                Meal m = new Meal();
                m.setmealName(textBox4.Text);
                m.setmealType(comboBox9.Text);
                m.setmealPrice(Convert.ToInt32(textBox1.Text));

                m.setmealCategory(comboBox6.Text);
                XML.saveAlcoholic(m);
                MessageBox.Show("Meal added");
            }
            if (comboBox9.Text == "Hot Beverages")
            {
                Meal m = new Meal();
                m.setmealName(textBox4.Text);
                m.setmealType(comboBox9.Text);
                m.setmealPrice(Convert.ToInt32(textBox1.Text));

                m.setmealCategory(comboBox6.Text);
                XML.saveHot(m);
            }
            if (comboBox9.Text == "Soft Drinks")
            {
                Meal m = new Meal();
                m.setmealName(textBox4.Text);
                m.setmealType(comboBox9.Text);
                m.setmealPrice(Convert.ToInt32(textBox1.Text));

                m.setmealCategory(comboBox6.Text);
                XML.saveSoft(m);
                
            }
            try
            {
                int priceM = Convert.ToInt32(textBox1.Text);
                string categoryM = comboBox6.Text;
                string typeM = comboBox9.Text;
                string nameM = textBox4.Text;
                MessageBox.Show("Meal added");
            }

            catch (Exception)
            {
                if (textBox1.Text == "")
                    MessageBox.Show(" The value for Price can not be blank! ");
                else if (textBox2.Text == "0")
                    MessageBox.Show(" The value for Price can not be zero! ");

               
                if (comboBox9.Text == "")
                    MessageBox.Show(" The value for Type can not be blank! ");
                if (comboBox6.Text == "")
                    MessageBox.Show(" The value for Category can not be blank!");
                if (textBox4.Text == "")
                    MessageBox.Show(" The value for Name can not be blank! ");  

            }
               


        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox4.Text == "Soft Drinks")
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Soft.xml");
                this.dataGridView1.DataSource = ds.Tables[0];
                DataSet dsSet = new DataSet();
            }
            else if (comboBox4.Text == "Hot Beverages")
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Hot.xml");
                this.dataGridView1.DataSource = ds.Tables[0];
                DataSet dsSet = new DataSet();
            }
            else if (comboBox4.Text == "Alcoholic Drinks")
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Alcoholic.xml");
                this.dataGridView1.DataSource = ds.Tables[0];
                DataSet dsSet = new DataSet();
            }
            else if (comboBox4.Text == "Appetizer")
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Appetizer.xml");
                this.dataGridView1.DataSource = ds.Tables[0];
                DataSet dsSet = new DataSet();
            }
            else if (comboBox4.Text == "Salad")
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Salad.xml");
                this.dataGridView1.DataSource = ds.Tables[0];
                DataSet dsSet = new DataSet();
            }
            else if (comboBox4.Text == "Main Corse")
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Main.xml");
                this.dataGridView1.DataSource = ds.Tables[0];
                DataSet dsSet = new DataSet();
            }
            else if (comboBox4.Text == "Dessert")
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Dessert.xml");
                this.dataGridView1.DataSource = ds.Tables[0];
                DataSet dsSet = new DataSet();

                
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
              
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price;
            int quantity;
            double finalprice=0;
            double finalprice1=0;

            price = Convert.ToInt32(textBox3.Text);
            quantity = Convert.ToInt32(textBox2.Text);
            if (comboBox3.Text == "Medium")
            {
                price = price + 2;
            }
            else if (comboBox3.Text == "Large")
            {
                price = price + 4;
            }


            finalprice = price * quantity;

            if (checkBox1.Checked)
            {
                finalprice = finalprice - (finalprice * 0.15);
            }

         

                finalprice1 = finalprice1 + finalprice;

                textBox6.Text = finalprice1.ToString();
            

        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            Meal m = new Meal();
            m.setmealName(textBox5.Text);
            m.setmealType(comboBox2.Text);
            m.setFinalPrice(Convert.ToDouble(textBox6.Text));

            m.setmealCategory(comboBox1.Text);
            XML.saveMeal(m);
            MessageBox.Show("Meal added to the bill");
           
           
       


            try
            {
                int Mealquantity=Convert.ToInt32(textBox2.Text);
                int Mealprice=Convert.ToInt32(textBox3.Text);
                string Mealname=textBox5.Text;
                string Mealtype=comboBox2.Text;
                string Mealportion=comboBox3.Text;
                string Mealcategory=comboBox1.Text;
                MessageBox.Show("Added to the bill");
              
            }
            catch (Exception)
            {
                if (textBox2.Text == "")
                    MessageBox.Show(" The value for Quantity can not be blank! ");
                else if (textBox2.Text == "0")
                    MessageBox.Show(" The value for Quantity can not be zero! ");
               
                if (textBox3.Text == "")
                    MessageBox.Show(" The value for Price can not be blank! ");
                else if (textBox3.Text == "0")
                    MessageBox.Show(" The value for Price can not be zero! ");
                if (textBox5.Text == "")
                    MessageBox.Show(" The value for Name can not be blank! ");
                if (comboBox5.Text == "")
                    MessageBox.Show(" The value for Type can not be blank! ");
                if (comboBox9.Text == "")
                    MessageBox.Show(" The value for Portion can not be blank!");
                if (comboBox1.Text == "")
                    MessageBox.Show(" The value for Category can not be blank! ");  

            }



        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Reservation.xml");
            XmlNode Reserve = doc.CreateElement("Reserve");
            XmlNode name = doc.CreateElement("Name");
            name.InnerText = comboBox5.Text;
            Reserve.AppendChild(name);

            XmlNode table = doc.CreateElement("Table");
            table.InnerText = textBox8.Text;
            Reserve.AppendChild(table);
           

            XmlNode date = doc.CreateElement("Date");
            date.InnerText = textBox7.Text = monthCalendar1.SelectionStart.ToString();
            Reserve.AppendChild(date);
            doc.DocumentElement.AppendChild(Reserve);

            doc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Reservation.xml");
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Meals.xml");
            this.dataGridView2.DataSource = ds.Tables[0];
            DataSet dsSet = new DataSet();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1.ReadXml("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Reservation.xml");
            this.dataGridView3.DataSource = ds1.Tables[0];
            DataSet ds1Set = new DataSet();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Reservation.xml");
            XmlNode Reserve = doc.CreateElement("Reserve");
            XmlNode name = doc.CreateElement("Table");
            name.InnerText = comboBox5.Text;
            Reserve.AppendChild(name);

            XmlNode table = doc.CreateElement("Name");
            table.InnerText = textBox8.Text;
            Reserve.AppendChild(table);


            XmlNode date = doc.CreateElement("Date");
            date.InnerText = textBox7.Text = monthCalendar1.SelectionStart.ToString();
            Reserve.AppendChild(date);
            doc.DocumentElement.AppendChild(Reserve);

            doc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Reservation.xml");

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }


        
    }
}
