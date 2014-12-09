using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using System.IO;

namespace MyNoteBook_v1._0
{
    public partial class MainForm : Form
    {
        #region Connection String
        string le = "MyNoteBook_v1._0.Properties.Settings.largedbConnectionString";
        #endregion

        #region Main Form Loads
        public MainForm()
        {
            InitializeComponent();
            dataFillinListBox_(); 
                 
          
            
            reminddateTimePicker1.MinDate = System.DateTime.Today;

         
            button1.Enabled = false;
           
        }
        #endregion

        public void webBrowser_() 
        {

            webBrowser1.AllowNavigation = true;
       
           

        
        
        }

        #region Save Button
        private void saveButton__Click(object sender, EventArgs e)
        {
            if (noteTitle_.Text.Length > 0)
            {
                if(reminddateTimePicker1.Checked)
                {
                    SaveMe(noteTitle_.Text, notes.Text,reminddateTimePicker1.Value);
                }
                else
                {
                    SaveMe(noteTitle_.Text, notes.Text);
                }
                progressBar1.Value = 0;
                //Class for saving Log status in Database
                TimeClass log = new TimeClass();
                log.getandsettaskdone(noteTitle_.Text + " saved");
                notes.Text = "";
                noteTitle_.Text = "";
                dataFillActivityLogStatus_();
                
            }
            else 
            {

                MessageBox.Show("Enter Title ", "Error ", MessageBoxButtons.OK);
            
            }
        }//Save button.
        #endregion

        #region Fill Notes title in Listbox.
        private void dataFillinListBox_() {
            if (prenotes.Items.Count > 0)
            {

                prenotes.Items.Clear();
            }
            
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
            {

                SqlCommand cmd = new SqlCommand("DisplayNoteTitles", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    prenotes.Items.Add(dr["title"].ToString());
                    
                
                    
                }
            
            
            
            
            }
        
        
        
        
        }
        #endregion

        #region Dropdown List Item Selected.
        private void prenotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text.Equals("Read Notes"))
            {
            
                if (this.DatasetForReportViewer.mydocs.Rows.Count > 0) { this.DatasetForReportViewer.mydocs.Clear(); }
               // MessageBox.Show("Read Notes Opened");
                // this.mydocsTableAdapter.Fill(this.DatasetForReportViewer.mydocs);
                //  this.reportViewer1.RefreshReport();
                //  this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
                {


                    //string s = "select title,stuff from mydocs where title='" + prenotes.SelectedItem.ToString() + "'";
                    SqlDataAdapter da=new SqlDataAdapter("DisplaySelectedNoteData",cn);
                   // SqlCommand cmd = new SqlCommand("DisplaySelectedNoteData", cn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                   // cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@title", prenotes.SelectedItem.ToString());
                   // cmd.Parameters.AddWithValue("@title", prenotes.SelectedItem.ToString());
                    cn.Open();
                  
                    da.Fill(this.DatasetForReportViewer.mydocs);
                    this.reportViewer1.RefreshReport();
                    this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                    
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    noteTitle_.Text = dr["title"].ToString();
                    //    notes.Text = dr["stuff"].ToString();
                    //    mydate.Text = "Last edited on : " + dr["mydate"].ToString();
                    //}






                }

            }
            else 
            {
                saveButton_.Enabled = false;
                saveButton_.Visible = false;
              
                noteTitle_.ReadOnly = true;
                button1.Enabled = true;

                if (noteTitle_.TextLength > 0 && notes.TextLength > 0)
                {


                    // MessageBox.Show("There is already Note file opened, Do you want to save the file ?","   Application Confirmation    ",MessageBoxButtons.YesNo);

                    DialogResult confirm = MessageBox.Show("There is already Note file opened, Do you want to save the file ?", "   Application Confirmation    ", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.No)
                    {
                        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
                        {


                            //string s = "select title,stuff from mydocs where title='" + prenotes.SelectedItem.ToString() + "'";
                            SqlCommand cmd = new SqlCommand("DisplaySelectedNoteData", cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@title", prenotes.SelectedItem.ToString());
                            cn.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                noteTitle_.Text = dr["title"].ToString();
                                notes.Text = dr["stuff"].ToString();
                                mydate.Text = "Last edited on : " + dr["mydate"].ToString();
                            }






                        }



                    }
                    else
                    {

                        MessageBox.Show(" Update your open file", "   Application Message: ");

                    }


                }
                else
                {

                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
                    {


                        //string s = "select title,stuff from mydocs where title='" + prenotes.SelectedItem.ToString() + "'";
                        SqlCommand cmd = new SqlCommand("DisplaySelectedNoteData", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@title", prenotes.SelectedItem.ToString());
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            noteTitle_.Text = dr["title"].ToString();
                            notes.Text = dr["stuff"].ToString();
                            mydate.Text = "Last edited on : " + dr["mydate"].ToString();
                        }






                    }
                }
           
           
            
            
            }

            
           
        }
        #endregion

        #region Update Button
        private void button1_Click(object sender, EventArgs e)
        {
          
           // string s= prenotes.SelectedItem.ToString();
            
            if (prenotes.SelectedIndex > -1)
            {

                if (noteTitle_.Text.Length > 0)
                {

                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
                    {

                        SqlCommand cmd = new SqlCommand("UpdateSelectedNoteData", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@oldtitle", prenotes.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@title", noteTitle_.Text);
                        cmd.Parameters.AddWithValue("@stuff", notes.Text);
                        cmd.Parameters.AddWithValue("@date", System.DateTime.Now.ToString());
                        cn.Open();
                        int i = cmd.ExecuteNonQuery();
                        MessageBox.Show("Note Updated", "Update Confirmation", MessageBoxButtons.OK);
                    }
                    dataFillinListBox_();
                    saveButton_.Enabled = true;
                    saveButton_.Visible = true;
                    //Class for saving Log status of updating task in Database
                    TimeClass log = new TimeClass();
                    log.getandsettaskdone(noteTitle_.Text + " updated ");
                    //----------------------------------------------
                    notes.Text = "";
                    noteTitle_.Text = "";
                    noteTitle_.ReadOnly = false;
                    button1.Enabled = false;
                  
                   
                    dataFillActivityLogStatus_();
                }
                else
                {

                    MessageBox.Show("Enter Title ", " MyNoteBook Says .... ", MessageBoxButtons.OKCancel);

                }
            }
            else
            {
                MessageBox.Show("You have not selected any 'Note' from right side list ", " MyNoteBook Says .... ", MessageBoxButtons.OKCancel);
                prenotes.Focus();
            }
        }
        #endregion

        #region  Delete button
        private void delete__Click(object sender, EventArgs e)
        {
           using(SqlConnection cn=new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString)){



               SqlCommand cd = new SqlCommand("DeleteNote", cn);
               cd.CommandType = CommandType.StoredProcedure;
               cd.Parameters.AddWithValue("@title", noteTitle_.Text);
               cn.Open();
               int result = cd.ExecuteNonQuery();
               if (result == 1)
               {
                   MessageBox.Show(result+" File Deleted." , "Application Message");
               }
               else if (result == 0)
               {
                   MessageBox.Show("Select file from list to delete.", "Application Message");
               }


               noteTitle_.Text = "";
               notes.Text = "";
               dataFillinListBox_();
               saveButton_.Enabled = true;
               mydate.ResetText();
           
           
           }
        }
        #endregion

        #region Get PDF button
        private void button2_Click(object sender, EventArgs e)
        {
            if (notes.Text.Length > 0 && noteTitle_.Text.Length > 0)
            {
                var doc = new iTextSharp.text.Document();

                string myPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                PdfWriter.GetInstance(doc, new FileStream(myPath + "/" + noteTitle_.Text + ".pdf", FileMode.Create));

                doc.Open();
                doc.AddTitle(noteTitle_.Text);
                doc.AddHeader("Header", noteTitle_.Text);


                //Description
                doc.AddLanguage("English");
                doc.AddCreator("MyNoteBook");





                var content = new iTextSharp.text.Paragraph(notes.Text);
                doc.Add(content);
                doc.Close();
                MessageBox.Show("   File Saved on Desktop.   ", "   Application Message", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You have to select Note from list or write something in textboxes to get PDF", "   Application Message", MessageBoxButtons.OK);
            }
            
        }
        #endregion


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();  
        }//Exit button

        private void docToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

           // MessageBox.Show("Work in Pending..   ", "Application Says ", MessageBoxButtons.OKCancel);

            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();

            var doc = new iTextSharp.text.Document();

            string myPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            PdfWriter.GetInstance(doc, new FileStream(myPath + "/" + noteTitle_.Text + ".pdf", FileMode.Create));

            doc.Open();
            doc.AddTitle(noteTitle_.Text);
            doc.AddHeader("Header", noteTitle_.Text);


            //Description
            doc.AddLanguage("English");
            doc.AddCreator("MyNoteBook");





            var content = new iTextSharp.text.Paragraph(notes.Text);
            doc.Add(content);
            doc.Close();
            MessageBox.Show("   File Saved on Desktop   ", "    MyNoteBook says..   ", MessageBoxButtons.OKCancel);

          

        }//Doc to Pdf

        private void saveTextFileToNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //System.IO.File.Exists()
            openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader str = new StreamReader(openFileDialog1.OpenFile());
                string FileTitle = openFileDialog1.SafeFileName.Replace(".txt", "");
                var FileContent = str.ReadToEnd();
                noteTitle_.Text = FileTitle;
                notes.Text = FileContent;
                MessageBox.Show("  FileName ► " + FileTitle + " is ready for Saving/Editing.", "   Application Message    ", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("► No file selected.", "   Application Message    ", MessageBoxButtons.OK);
            }
         
        }//Opening Text File for Saving

        private void textToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*
         * Methods -----------------------------
         * 1) SaveMe(string noteTitle, string notes) - save data( i.e - Note Title & Note content).
         * 2) SaveMe(string noteTitle, string notes, date myreminder) - save data with reminder service used by user.
         * 3) dataFillinListBox2_() - Display Reminder in listbox on right-hand side.
         * 4) dataFillActivityLogStatus_() - Display Log of tasks done by user.
       
         */

        //1) Method Name - SaveMe
        private void SaveMe(string mynotetitle, string mynote) {



            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
            {

                SqlCommand cd = new SqlCommand("NoteExist", cn);
                cd.CommandType = CommandType.StoredProcedure;
                cd.Parameters.AddWithValue("@mytitle", mynotetitle);
                cd.Parameters.Add("@return", SqlDbType.NVarChar, 3000);
                cd.Parameters["@return"].Direction = ParameterDirection.Output;
                cn.Open();
                cd.ExecuteNonQuery();
                if (mynotetitle != cd.Parameters["@return"].Value.ToString())
                {

                    SqlCommand cmd = new SqlCommand("InsertNotes", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@noteTitle", mynotetitle);
                    cmd.Parameters.AddWithValue("@noteStuff", mynote);
                    cmd.Parameters.AddWithValue("@myDate", System.DateTime.Now.ToString());

                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i + " Note saved.", "Application Message:", MessageBoxButtons.OK);
                    dataFillinListBox_();
                   
                }
                else
                {
                    MessageBox.Show("Note already exist, use different name for file to save. ", "Error ", MessageBoxButtons.OK);
                    noteTitle_.Focus();
                }

            }


        
        
        
        
        }

        //2) Method Name - SaveMe( Overloaded Version )
        private void SaveMe(string mynotetitle, string mynote, DateTime myreminder) {



            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
            {

                SqlCommand cd = new SqlCommand("NoteExist", cn);
                cd.CommandType = CommandType.StoredProcedure;
                cd.Parameters.AddWithValue("@mytitle", mynotetitle);
                cd.Parameters.Add("@return", SqlDbType.NVarChar, 3000);
                cd.Parameters["@return"].Direction = ParameterDirection.Output;
                cn.Open();
                cd.ExecuteNonQuery();
                if (mynotetitle != cd.Parameters["@return"].Value.ToString())
                {

                    SqlCommand cmd = new SqlCommand("InsertNotesWithReminder", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@noteTitle", mynotetitle);
                    cmd.Parameters.AddWithValue("@noteStuff", mynote);
                    cmd.Parameters.AddWithValue("@myDate", System.DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@myreminderdate", reminddateTimePicker1.Value);

                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show(" Note saved.", "Application Message:", MessageBoxButtons.OK);
                    dataFillinListBox_();
                   
                    dataFillinListBox2_(System.DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Note already exist, use different name for file to save. ", "Error ", MessageBoxButtons.OK);
                    noteTitle_.Focus();
                }

            }
        
        
        
        
        
        
        
        }

        //3) Method Name - dataFillinListBox2_
        private void dataFillinListBox2_(DateTime dt)
        {
            if (reminderlist.Items.Count > 0)
            {

                reminderlist.Items.Clear();
            }

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
            {

                SqlCommand cmd = new SqlCommand("GetReminder", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                int totalReminders_ = 0;
                while (dr.Read())
                {
                    reminderlist.Items.Add("Note: " + dr["Note"].ToString() +" | Date: "+ dr["On Date"].ToString());
                    totalReminders_ += 1;
                }

                ReminderLabelTotal.Text = " "+ totalReminders_ ; 


            }




        }

        //4) Method Name - dataFillActivityLogStatus_
        private void dataFillActivityLogStatus_()
        {
            if (reminderlist.Items.Count > 0)
            {

                ActiviyLogStatus.Items.Clear();
                
            }

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
            {

                SqlCommand cmd = new SqlCommand("sp_DisplayLog", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
             
                while (dr.Read())
                {
                    ActiviyLogStatus.Items.Add("Documnet name: " + dr["Taskdone"].ToString() + " on " + dr["AtDate"].ToString()+"  "+ dr["AtTime"].ToString());
                 
                }

               


            }




        }

        private void notes_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("You just drag and file will be saved", "Application Message ..", MessageBoxButtons.OK);
        }       

        private void notes_Leave(object sender, EventArgs e)
        {
            if ( noteTitle_.TextLength > 0 && notes.TextLength > 0)
            {
                progressBar1.Value = 100;
            }

            else if (noteTitle_.TextLength == 0 && notes.TextLength > 0)
            {
                progressBar1.Value = 60;
            
            }

            else if (notes.TextLength == 0)
            {


                if (progressBar1.Value.Equals(0))
                { }
                else if (progressBar1.Value > 50)
                {

                    progressBar1.Value -= 50;
                }

            }
        }

        private void noteTitle__Leave(object sender, EventArgs e)
        {
            if (noteTitle_.TextLength == 0 && notes.TextLength > 0)
            {
                progressBar1.Value = 60;
            }
            else if (noteTitle_.TextLength > 0 && notes.TextLength > 0)
            {
                progressBar1.Value = 100;

            }
            else if (noteTitle_.TextLength == 0 && notes.TextLength ==0)
            {
            
             if(progressBar1.Value.Equals(0))
             {}
             else  {

                 progressBar1.Value = 0;
             }

            
            }
            else if (noteTitle_.TextLength > 0 && notes.TextLength == 0)
            
            {
                progressBar1.Value = 40;
            
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'DatasetForReportViewer.mydocs' table. You can move, or remove it, as needed.
           // this.mydocsTableAdapter.Fill(this.DatasetForReportViewer.mydocs);
           //  this.reportViewer1.RefreshReport();
           //  this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            //this.mydocsTableAdapter.Fill(this.DatasetForReportViewer.mydocs);
            reportViewer1.RefreshReport();
        }

        private void BrowserBackBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void BrowserForwardBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {



            const string FolderName = "MyNotesBackup";
            string MyFolderDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
  
            Directory.SetCurrentDirectory(MyFolderDirectory);  
            bool FolderExists = Directory.Exists( FolderName);
            if (FolderExists)
            {
               // MessageBox.Show("Folder Exists.");
            }
            else if (FolderExists == false )
            {
                MessageBox.Show("Creating a folder on Desktop name: " + FolderName);
                         
                Directory.CreateDirectory(FolderName);
                Directory.SetCurrentDirectory(FolderName); 
              
            }
            
               
                string title , contents;
                int totalFiles = 0;
            
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[le].ConnectionString))
                {

                    SqlCommand cmd = new SqlCommand("ForExportingData", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr;
                    cn.Open();
                    dr = cmd.ExecuteReader();
                  
                    
                    while (dr.Read())
                    {
                        using(var doc = new iTextSharp.text.Document()){


                            title = dr["title"].ToString();
                            contents = dr["stuff"].ToString();
                            PdfWriter.GetInstance(doc, new FileStream(MyFolderDirectory + "/" + FolderName + "/" + title + ".pdf", FileMode.Create));
                            doc.Open();



                            doc.AddTitle(title);
                            doc.AddHeader("Header", title);


                            //Description
                            doc.AddLanguage("English");
                            doc.AddCreator("MyNoteBook");

                            var content = new iTextSharp.text.Paragraph(contents);
                            doc.Add(content);
                        
                        
                        
                        }
                       

                      
                        totalFiles++;
                    }
                  

                    MessageBox.Show(totalFiles + " files saved on desktop folder named " + FolderName, "   Application Message", MessageBoxButtons.OK);
                }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.ShowDialog();
        }

        #region Button to show reminders.
        private void showReminderbtn_Click(object sender, EventArgs e)
        {
            dataFillinListBox2_(System.DateTime.Now);
        } 
        #endregion

        #region Show Internet
        private void showInternetbtn_Click(object sender, EventArgs e)
        {
            webBrowser_();
        }
        #endregion

        #region PDF file for editing
        private void pDFToNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.IO.File.Exists()
            openFileDialog1.Filter = "Pdf files(*.pdf)|*.pdf";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
            //    StreamReader str = new StreamReader(openFileDialog1.OpenFile());
            //    string FileTitle = openFileDialog1.SafeFileName.Replace(".pdf", "");
            //    var FileContent = str.ReadToEnd();
            //    noteTitle_.Text = FileTitle;
            //    notes.Text = FileContent;
            //    MessageBox.Show("  FileName ► " + FileTitle + " is ready for Saving/Editing.", "   Application Message    ", MessageBoxButtons.OK);
            //
                var doc = new iTextSharp.text.Document();

                string myPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                PdfWriter.GetInstance(doc, new FileStream(myPath + "/" + noteTitle_.Text + ".pdf", FileMode.Open));
                
                doc.Open();
                doc.AddTitle(noteTitle_.Text);
                doc.AddHeader("Header", noteTitle_.Text);


                //Description
                doc.AddLanguage("English");
                doc.AddCreator("MyNoteBook");





                var content = new iTextSharp.text.Paragraph(notes.Text);
                doc.Add(content);
                doc.Close();
                MessageBox.Show("   File Saved on Desktop.   ", "   Application Message", MessageBoxButtons.OK);



            }
            else
            {
                MessageBox.Show("► No file selected.", "   Application Message    ", MessageBoxButtons.OK);
            }
        }
        #endregion


    }
}
