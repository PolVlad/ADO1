using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace datenbank
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConOpen_Click(object sender, EventArgs e)
        {
            OleDbConnectionStringBuilder bldr = new OleDbConnectionStringBuilder();
            bldr.Provider = "Microsoft.ACE.OLEDB.12.0";
            bldr.DataSource = "Bestellung.accdb";
            con = new OleDbConnection(bldr.ConnectionString);
            try
            {
                con.Open();
                buttonSQLCommand.Enabled = true;
            }
            catch (OleDbException es)
            {

                MessageBox.Show(es.Message,"Verbindungsfehler!",MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void buttonSQLCommand_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from tArtikel";
            cmd.CommandType = CommandType.TableDirect;
            try
            {
                reader = cmd.ExecuteReader();
                buttonRead.Enabled = true;
            }
            catch (OleDbException ie)
            {

                MessageBox.Show(ie.Message, "Kommando Fehler!",MessageBoxButtons.OK);
            }

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            while(reader.Read())
            {
                String zeile = reader["ArtikelOid"].ToString();
                listBoxDatenbank.Items.Add(zeile);
            }
        }
    }
}
