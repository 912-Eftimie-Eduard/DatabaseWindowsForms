using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Ass1
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlDataAdapter DataAdapterParent;
        SqlDataAdapter DataAdapterChild;
        SqlCommandBuilder cmdBuilder;
        DataSet dset;

        string FormCaption;
        string ConnectionString;
        string ChildQuery;
        string ChildString;
        string ChildFillQuery;

        string ParentQuery;
        string ParentString;
        string ParentFillQuery;

        string OTMString;
        string Key;

        void FillData()
        {
            try
            {
                this.connection = new SqlConnection(this.ConnectionString);

                ParentFillQuery = this.ParentQuery;
                ChildFillQuery = this.ChildQuery;

                DataAdapterParent = new SqlDataAdapter(ParentFillQuery, connection);
                DataAdapterChild = new SqlDataAdapter(ChildFillQuery, connection);
                dset = new DataSet();

                // Log information
                Console.WriteLine("Executing Parent query: " + ParentFillQuery);
                Console.WriteLine("Executing Child query: " + ChildFillQuery);

                DataAdapterParent.Fill(dset, this.ParentString);
                DataAdapterChild.Fill(dset, this.ChildString);

                // Log data count
                Console.WriteLine("Parent data count: " + dset.Tables[this.ParentString].Rows.Count);

                // Check if ChildString table exists in the dataset
                if (dset.Tables.Contains(this.ChildString))
                {
                    Console.WriteLine("Child data count: " + dset.Tables[this.ChildString].Rows.Count);

                    cmdBuilder = new SqlCommandBuilder(DataAdapterChild);

                    dset.Relations.Add(this.OTMString,
                        dset.Tables[this.ParentString].Columns[Key],
                        dset.Tables[this.ChildString].Columns[Key]);
                    this.teamGrid.DataSource = dset.Tables[this.ParentString];
                    this.playerGrid.DataSource = this.teamGrid.DataSource;
                    this.playerGrid.DataMember = this.OTMString;
                }
                else
                {
                    MessageBox.Show("Child table '" + this.ChildString + "' does not exist in the dataset.");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Invalid operation: " + ex.Message);
                Console.WriteLine(ex.StackTrace); // Print the stack trace for detailed information
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during data filling: " + ex.Message);
                Console.WriteLine(ex.StackTrace); // Print the stack trace for detailed information
            }
        }



        public Form1()
        {
            InitializeComponent();

            this.FormCaption = ConfigurationManager.AppSettings["FormCation"];
            this.Text = FormCaption;
            this.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

            this.ParentQuery = ConfigurationManager.AppSettings["ParentQuery"];
            this.ChildQuery = ConfigurationManager.AppSettings["ChildQuery"];

            this.ParentString = ConfigurationManager.AppSettings["ParentString"];
            this.ChildString = ConfigurationManager.AppSettings["ChildString"];
            this.OTMString = ConfigurationManager.AppSettings["OTMString"];

            this.Key = ConfigurationManager.AppSettings["Key"];

            FillData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormCaption = ConfigurationManager.AppSettings["FormCation"];
            this.Text = FormCaption;
            this.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

            this.ParentQuery = ConfigurationManager.AppSettings["ParentQuery"];
            this.ChildQuery = ConfigurationManager.AppSettings["ChildQuery"];

            this.ParentString = ConfigurationManager.AppSettings["ParentString"];
            this.ChildString = ConfigurationManager.AppSettings["ChildString"];
            this.OTMString = ConfigurationManager.AppSettings["OTMString"];

            this.Key = ConfigurationManager.AppSettings["Key"];

            //string sqlCommand = "SELECT * FROM Teams";

            //SqlCommand getTeams = new SqlCommand(sqlCommand, connection);
            //DataAdapterChild = new SqlDataAdapter(getTeams);
            //DataAdapterChild.Fill(dset, "Teams");
            //teamGrid.DataSource = dset.Tables["Teams"];
            //MessageBox.Show(ConfigurationManager.AppSettings["greeting"]);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.playersTableAdapter.FillBy(this.homeworkDataSet.Players);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void playerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.RowIndex < teamGrid.Rows.Count - 1)
        //    {
        //        var id = teamGrid.Rows[e.RowIndex].Cells[0].Value;

        //        string sqlCommand = "SELECT * FROM Players WHERE team_id = " + id;

        //        SqlCommand getPlayersByTeam = new SqlCommand(sqlCommand, connection);
        //        getPlayersByTeam.Parameters.AddWithValue("@team_id", id);
        //
        //       dset = new DataSet();
        //        DataAdapterParent = new SqlDataAdapter(getPlayersByTeam);
        //        DataAdapterParent.Fill(dset, "Players");
        //        playerGrid.DataSource = dset.Tables["Players"];
        //    }
        //}

        private void teamGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    playerGrid_CellClick(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
           try{
                playerGrid.EndEdit();
                if (dset.HasChanges()){
                    SqlCommandBuilder builerChild = new SqlCommandBuilder(DataAdapterChild);
                    SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapterParent);
                    //dat.Update(ds, "Teams");
                    //foreach (DataRow row in dset.Tables["Players"].Rows){

                    //    if (row.RowState == DataRowState.Deleted) {
                            //in the DataRowCollection
                     //       var playerId = row["player_id", DataRowVersion.Original];
                      //      DeleteRelatedPositions(playerId);
                     //       row.Delete();
                     //   }
                    ///}
                    DataAdapterParent.Update(dset, this.ParentString);
                    DataAdapterChild.Update(dset, this.ChildString);
                    MessageBox.Show("Changes saved");
                } else {
                    MessageBox.Show("No changes to save");
                }
            } catch (Exception ex){
                MessageBox.Show("Error on edit: " + ex.Message);
            }
        }

        //private void DeleteRelatedPositions(object playerId){
        //    //MessageBox.Show("aici");
        //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LQ1SO6G\\SQLEXPRESS;Initial Catalog=Homework;Integrated Security=True")){
        //        connection.Open();
        //        string sqlCommand = "DELETE FROM MergedPlayersPositions WHERE player_id = @player_id";
        //        using (SqlCommand deletePositions = new SqlCommand(sqlCommand, connection)){
        //            deletePositions.Parameters.AddWithValue("@player_id", playerId);
        //            deletePositions.ExecuteNonQuery();
        //        }
        //    }
        //} 
    }
}
