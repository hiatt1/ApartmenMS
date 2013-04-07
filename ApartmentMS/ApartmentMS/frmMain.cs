using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Data.OleDb;
using System.Configuration;
using System.IO;

// Name:   frmMain.cs has the C# code for XXXX
// Author: Alka Harriger
// Date:   1/20/13
//
// This application gets XXX and then produces XXXX.

public partial class frmMain : Form
{
    private string mUserFile;
    private OleDbConnection mDB;
    private ArrayList mEmployees = new ArrayList();
    [STAThread]
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
    }

    // The btnExit_Click method terminates the program when the EXIT button is clicked.
    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles int data.)
    private bool validateInput(TextBox txtInput, int min, int max, out int userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (int.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles double data.)
    private bool validateInput(TextBox txtInput, double min, double max, out double userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0D;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (double.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The overloaded validateInput helper methods handle the existence check, type check, and range check for a given 
    // input form object and assigns the equivalent value to its corresponding variable. (This one handles decimal data.)
    private bool validateInput(TextBox txtInput, decimal min, decimal max, out decimal userInput)
    {
        string fieldName;
        fieldName = txtInput.Name.Substring(3);
        userInput = 0M;
        if (txtInput.Text == "")
        {
            ShowMessage("Please enter a value for " + fieldName);
            txtInput.Focus();
            return false;
        }
        if (decimal.TryParse(txtInput.Text, out userInput) == false)
        {
            ShowMessage("Only numbers are allowed for " + fieldName + ". Please re-enter:");
            txtInput.Focus();
            return false;
        }
        if (userInput < min || userInput > max)
        {
            ShowMessage(fieldName + " must be between " + min.ToString() + " and " + max.ToString());
            txtInput.Focus();
            return false;
        }
        return true;
    }

    // The ShowMessage helper method displays an error message with a standard title and an OK button.
    private void ShowMessage(string msg)
    {
        MessageBox.Show(msg, "Problem found", MessageBoxButtons.OK);
    }

    private void openDatabaseConnections()
    {
        string ConnectionString = ConfigurationManager.AppSettings["DBConnectionString"] + mUserFile;
        mDB = new OleDbConnection(ConnectionString);
    }

    private void closeDatabaseConnections()
    {
        if (mDB != null)
        {
            mDB.Close();
        }
    }

    private void LoadDBTable(string sql)
    {
        try
        {
            mEmployees.Clear();
            openDatabaseConnections();
            mDB.Open();
            OleDbCommand cmd;
            OleDbDataReader rdr;
            cmd = new OleDbCommand(sql, mDB);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                clsFileHandler tempRecord = new clsFileHandler((string)rdr["Plant"], (string)rdr["Dept"], (string)rdr["EmployeeID"], (string)rdr["LastName"], (string)rdr["FirstName"], (DateTime)rdr["DateHired"], (bool)rdr["SalaryInd"], (string)rdr["Gender"], (decimal)rdr["PayRate"]);
                mEmployees.Add(tempRecord);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("There was an unexpected error: " + ex.Message);
        }
    }

    private void showArrayInList()
    {
        string outputLine;

        lstData.Items.Clear();
        outputLine = "LastName  FirstName   Plant     Dept              EmployeeID     DateHired       SalaryInd    Gender      PayRate";
        lstData.Items.Add(outputLine);
        lstData.Items.Add("".PadRight(100,'='));
        foreach (clsFileHandler tempContact in mEmployees)
        {
            lstData.Items.Add(tempContact.Serialize());
        }

    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd;
        try
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select the database files to open";
            ofd.Filter = "Database Files (*.accdb)|*.accdb|All Files (*.*)|*.*";
            ofd.InitialDirectory = Path.Combine(Application.StartupPath,@"\Databases");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mUserFile = ofd.FileName;
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("There was an unexpected error: " + ex.Message);
        }
        finally
        {
            LoadDBTable("SELECT * FROM Employees");
            showArrayInList();
        }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        LoadDBTable("SELECT * FROM Employees ORDER BY LastName");
        showArrayInList();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        LoadDBTable("SELECT * FROM Employees ORDER BY DateHired");
        showArrayInList();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        LoadDBTable("SELECT * FROM Employees ORDER BY Plant, Dept");
        showArrayInList();
    }

}