using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO.Packaging;
using System.Data.OleDb;




namespace CouseScheduleVerifier
{



    public partial class Form1 : Form
    {

        public struct courseDetails
        {
            public string key;
            public string title;
            public string instructor;
            public string room;
            public string day;
            public string time;
        }
        
        //keeps track of how many classes were added 
        int classCounter = 0;
        public List<courseDetails> courseList = new List<courseDetails>();                  

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remove.Enabled = false;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            //create instance of OpenFileDialog box
            OpenFileDialog ofd = new OpenFileDialog();
            
            //Filter to excel files only
            ofd.Filter = "Excel Files (.xlsx)|*.xlsx|All Files (*.*)|*.*";          
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
              
                string filePath = ofd.FileName;
                
                //Loop for Instructor
                for (int i = 2; i <= 4; i++)
                {
                    string cell = "A" + i;
                    this.instructor.Items.Add(GetCellValues(filePath, "Sheet1", cell));
                }
                //Loop for Room
                for (int i = 2; i <= 4; i++)
                {
                    string cell = "B" + i;
                    this.room.Items.Add(GetCellValues(filePath, "Sheet1", cell));
                }
                //Loop for Day
                for (int i = 2; i <= 3; i++)
                {
                    string cell = "C" + i;
                    this.day.Items.Add(GetCellValues(filePath, "Sheet1", cell));
                }
                //Loop for Time
                for (int i = 2; i <= 4; i++)
                {
                    string cell = "D" + i;
                    this.time.Items.Add(GetCellValues(filePath, "Sheet1", cell));
                }

       
                
                
            }   
                                                
          
        }
        private void instructor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void courseTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void room_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void time_SelectedIndexChanged(object sender, EventArgs e)
        {

        }  

        public static string GetCellValues(string fileName, string sheetName, string addressName)
        {
            string value = null;

            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart wbPart = document.WorkbookPart;
                Sheet theSheet = wbPart.Workbook.Descendants<Sheet>().
                    Where(s => s.Name == sheetName).FirstOrDefault();

                if (theSheet == null)
                {
                    throw new ArgumentException("sheetName");
                }

                WorksheetPart wsPart = (WorksheetPart)(wbPart.GetPartById(theSheet.Id));
                Cell theCell = wsPart.Worksheet.Descendants<Cell>().
                    Where(c => c.CellReference == addressName).FirstOrDefault();

                if (theCell != null)
                {
                    value = theCell.InnerText;
                }

                if (theCell.DataType != null)
                {
                    switch (theCell.DataType.Value)
                    {
                        case CellValues.SharedString:

                            // For shared strings, look up the value in the
                            // shared strings table.
                            var stringTable =
                                wbPart.GetPartsOfType<SharedStringTablePart>()
                                .FirstOrDefault();

                            // If the shared string table is missing, something 
                            // is wrong. Return the index that is in
                            // the cell. Otherwise, look up the correct text in 
                            // the table.
                            if (stringTable != null)
                            {
                                value =
                                    stringTable.SharedStringTable
                                    .ElementAt(int.Parse(value)).InnerText;
                            }
                            break;

                        case CellValues.Boolean:
                            switch (value)
                            {
                                case "0":
                                    value = "FALSE";
                                    break;
                                default:
                                    value = "TRUE";
                                    break;
                            }
                            break;
                    }
                    
                }
            }
            return value;
            
        }
              
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void remove_Click(object sender, EventArgs e)
        {           
           int removeNumber = listBox1.SelectedIndex;
           listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void enter_Click(object sender, EventArgs e)
        {
            courseDetails courseDetails1;
            courseDetails1.key = (classCounter + 1).ToString();
            courseDetails1.title = courseTitle.Text.ToString();
            courseDetails1.instructor = instructor.SelectedItem.ToString();
            courseDetails1.room = room.SelectedItem.ToString();
            courseDetails1.day = day.SelectedItem.ToString();
            courseDetails1.time = time.Text.ToString();

            courseList.Add(courseDetails1);

            if (classCounter > 0)
            {
                for (int j = 0; j < classCounter; j++)
                {
                    
                    if ((courseList[classCounter].instructor == courseList[j].instructor) && (courseList[classCounter].day == courseList[j].day) && (courseList[classCounter].time == courseList[j].time))
                    {
                        DialogResult instructorConflict = MessageBox.Show("Are you sure you want  " + courseList[classCounter].instructor + " to teach both " + courseList[classCounter].title + " and " + courseList[j].title + " on " + courseList[j].day + " at " + courseList[j].time + "?", "WARNING", MessageBoxButtons.YesNo);
                        if (instructorConflict == DialogResult.Yes)
                        {
                            listBox1.Items.Add(courseList[classCounter].key + ". " + courseList[classCounter].title + ", " + courseList[classCounter].instructor + ", " + courseList[classCounter].room + ", " + courseList[classCounter].day + ", " + courseList[classCounter].time);                       
                            return;
                        }
                        if (instructorConflict == DialogResult.No)
                        {                       
                            return;
                        }
                    }
                }
            }
            listBox1.Items.Add(courseList[classCounter].key + ". " + courseList[classCounter].title + ", " + courseList[classCounter].instructor + ", " + courseList[classCounter].room + ", " + courseList[classCounter].day + ", " + courseList[classCounter].time); //adds current list item to list box

            //clear out data
            courseTitle.Text = "";
            instructor.SelectedItem = "";
            room.Text = "";
            day.Text = "";
            time.Text = "";

            //increase class counter
            classCounter = classCounter + 1;
            
            remove.Enabled = true;
        }

        
        
         
        

                        

    }
}

    

    


