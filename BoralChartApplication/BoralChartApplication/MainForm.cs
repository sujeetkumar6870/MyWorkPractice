using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BoralChartApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Choose Input File";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Excel files (*.xls)|*.xls|Excel files (*.xlsx)|*.xlsx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = fdlg.FileName;
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = @"c:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = dialog.SelectedPath;
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            //this.DisplayInExcel();
            this.ReadExcel(this.txtInput.Text, ".xlsx");
        }
        public void ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    //string sql = "select F10 from [Raw Data filtered$]";//"select * from [Raw Data filtered$]"
                    string sql = "select * from [Raw Data filtered$]";//"select * from [Raw Data filtered$]"
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter(sql, con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                    this.dataGridView1.DataSource = dtexcel;
                }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
            //DataRow[] res = dtexcel.Select();
            //-----------------------------------------------------------------------------------
            MessageBox.Show("row count: "+dtexcel.Rows.Count+"\n"+"column count: "+ dtexcel.Columns.Count);
            object misValue = System.Reflection.Missing.Value;
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template. 
            // Because no argument is sent in this example, Add creates a new workbook. 
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            Microsoft.Office.Interop.Excel._Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelApp.ActiveSheet;
            // Establish column headings in cells A1 and B1.
            //add data 
            //try
            //{
            //    xlWorkSheet.Cells[14, 1] = "";
            //    xlWorkSheet.Cells[14, 2] = dtexcel.Rows[14][1];
            //    xlWorkSheet.Cells[14, 3] = dtexcel.Rows[14][2];
            //    xlWorkSheet.Cells[14, 4] = dtexcel.Rows[14][3];
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}

            //try
            //{
            //    for (int i = 0; i < dtexcel.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dtexcel.Columns.Count; j++)
            //        {
            //            xlWorkSheet.Cells[i, j] = dtexcel.Rows[i][j];
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}







            //----------------------------------------------------------------------------------------
            //return dtexcel;
        }


        //http://csharp.net-informations.com/excel/csharp-excel-chart.htm
        public void DisplayInExcel()
        {
            object misValue = System.Reflection.Missing.Value;
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template. 
            // Because no argument is sent in this example, Add creates a new workbook. 
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            Microsoft.Office.Interop.Excel._Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelApp.ActiveSheet;
            // Establish column headings in cells A1 and B1.
            //add data 
            xlWorkSheet.Cells[1, 1] = "";
            xlWorkSheet.Cells[1, 2] = "Student1";
            xlWorkSheet.Cells[1, 3] = "Student2";
            xlWorkSheet.Cells[1, 4] = "Student3";

            xlWorkSheet.Cells[2, 1] = "Term1";
            xlWorkSheet.Cells[2, 2] = "80";
            xlWorkSheet.Cells[2, 3] = "65";
            xlWorkSheet.Cells[2, 4] = "45";

            xlWorkSheet.Cells[3, 1] = "Term2";
            xlWorkSheet.Cells[3, 2] = "78";
            xlWorkSheet.Cells[3, 3] = "72";
            xlWorkSheet.Cells[3, 4] = "60";

            xlWorkSheet.Cells[4, 1] = "Term3";
            xlWorkSheet.Cells[4, 2] = "82";
            xlWorkSheet.Cells[4, 3] = "80";
            xlWorkSheet.Cells[4, 4] = "65";

            xlWorkSheet.Cells[5, 1] = "Term4";
            xlWorkSheet.Cells[5, 2] = "75";
            xlWorkSheet.Cells[5, 3] = "82";
            xlWorkSheet.Cells[5, 4] = "68";

            xlWorkSheet.Cells[6, 1] = "sele";
            xlWorkSheet.Columns.Insert();

            //data adding end

            //excelApp.Range
            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(100, 80, 400, 350);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A1", "d5");
            chartPage.SetSourceData(chartRange, misValue);

            //chartPage.ChartType = Excel.XlChartType.xl3DColumn;

            //chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            chartPage.ChartType = Excel.XlChartType.xl3DColumnClustered;
            chartPage.Perspective = 0;
            chartPage.HasTitle = true;
            chartPage.ChartTitle.Text = "Students Details";
            chartPage.ChartTitle.Font.Color = ColorTranslator.ToOle(Color.Green);
            chartPage.HasDataTable = true;
            chartPage.HasLegend = false;

            chartPage.Rotation = 20;
            chartPage.Elevation = 15;
            
            

            //excelApSaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);

            //MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void PopulateColumn(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    string sql = "select F10 from [Raw Data filtered$]";//"select * from [Raw Data filtered$]"
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter(sql, con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                    this.dataGridView1.DataSource = dtexcel;
                }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }
    }
}
