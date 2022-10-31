using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLtoCSV
{
    public partial class MainForm : Form
    {
        private string str = "";
        public MainForm()
        {
            InitializeComponent();
            saveButton.Enabled = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog of = new OpenFileDialog())
                {
                    of.Filter = "XML File | *.xml";
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        XMLFilePath.Text = of.FileName;

                        using (XmlReader reader = XmlReader.Create(of.FileName))
                        {
                            while (reader.Read())
                            {
                                str = string.Concat(str, reader);
                            }
                        }
                        saveButton.Enabled = true;
                    }
                }

                Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(XMLFilePath.TextLength > 0)
                {
                    saveButton.Enabled = true;
                    using (SaveFileDialog of = new SaveFileDialog())
                    {
                        of.Filter = "CSV File | *.csv";
                        if (of.ShowDialog() == DialogResult.OK)
                        {

                            XElement dataElement = XElement.Parse(str);
                            var csvData = GetCSVFromXML(dataElement);

                            File.WriteAllText(of.FileName, csvData.ToString());

                            CSVFilePath.Text = of.FileName;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error!", "You have to choose the XML file before you can save!");
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object GetCSVFromXML(XElement dataElement)
        {
            StringBuilder sb = new StringBuilder();
            var lines = from d in dataElement.Elements()
                        let line = string.Join(",", d.Elements().Select(s => s.Value))
                        select line;
            sb.Append(string.Join(Environment.NewLine, lines));


            return sb.ToString();
        }
    }
}
