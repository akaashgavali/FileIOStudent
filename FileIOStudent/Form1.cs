using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;


namespace FileIOStudent
{
    public partial class Form1 : Form
    {
        FileStream fs;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Student std = new Student();
                std.StudentRollNo = Convert.ToInt32(txtRollNo.Text);
                std.StudentName = txtName.Text;
                std.Percentage = Convert.ToDouble(txtPercentag.Text);
                binaryFormatter.Serialize(fs, std);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Student std = new Student();
                std = (Student)binaryFormatter.Deserialize(fs);
                txtRollNo.Text = std.StudentRollNo.ToString();
                txtName.Text = std.StudentName;
                txtPercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student std = new Student();
                std.StudentRollNo = Convert.ToInt32(txtRollNo.Text);
                std.StudentName = txtName.Text;
                std.Percentage = Convert.ToDouble(txtPercentag.Text);

                xmlSerializer.Serialize(fs, std);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student std = new Student();
                std = (Student)xmlSerializer.Deserialize(fs);
                txtRollNo.Text = std.StudentRollNo.ToString();
                txtName.Text = std.StudentName;
                txtPercentage.Text = std.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Student std = new Student();
                std.StudentRollNo = Convert.ToInt32(txtRollNo.Text);
                std.StudentName = txtName.Text;
                std.Percentage = Convert.ToDouble(txtPercentag.Text);

                soapFormatter.Serialize(fs, std);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Student std = new Student();
                std = (Student)soapFormatter.Deserialize(fs);
                txtRollNo.Text = std.StudentRollNo.ToString();
                txtName.Text = std.StudentName;
                txtPercentage.Text = std.Percentage.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.json", FileMode.Create, FileAccess.Write);
                Student std = new Student();
                std.StudentRollNo = Convert.ToInt32(txtRollNo.Text);
                std.StudentName = txtName.Text;
                std.Percentage = Convert.ToDouble(txtPercentag.Text);
                JsonSerializer.Serialize<Student>(fs, std);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
