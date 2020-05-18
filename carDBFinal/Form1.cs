using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using CarInventory;

namespace carDBFinal
{
    public partial class Form1 : Form
    {
        List<Car> carsList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            readerMethod();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            writerMethod();
        }

        public void readerMethod()
        {
            string newYear, newMake, newColour, newMileage;

            XmlReader reader = XmlReader.Create("Resources/carXMLFile.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    reader.ReadToNextSibling("year");
                    newYear = reader.ReadString();

                    reader.ReadToNextSibling("make");
                    newMake = reader.ReadString();

                    reader.ReadToNextSibling("mileage");
                    newColour = reader.ReadString();

                    reader.ReadToNextSibling("colour");
                    newMileage = reader.ReadString();

                    Car newCar = new Car(newYear, newMake, newColour, newMileage);
                    carsList.Add(newCar);
                }
            }

            reader.Close();
        }
        public void writerMethod()
        {
            XmlWriter writer = XmlWriter.Create("Resources/carXMLFile", null);

            writer.WriteStartElement("Cars:");

            foreach (Car c in carsList)
            {
                writer.WriteStartElement("Car");

                writer.WriteElementString("Year", c.year);
                writer.WriteElementString("Make", c.make);
                writer.WriteElementString("Mileage", c.mileage);
                writer.WriteElementString("Colour", c.colour);

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string year, make, colour, mileage;

            year = yearInput.Text;
            make = makeInput.Text;
            colour = colourInput.Text;
            mileage = mileageInput.Text;

            Car car = new Car(year, make, colour, mileage);

            carsList.Add(car);

            outputLabel.Text = "";

            foreach (Car c in carsList)
            {
                outputLabel.Text += c.year + " "
                    + c.make + " "
                    + c.colour + " "
                    + c.mileage + "\n";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
