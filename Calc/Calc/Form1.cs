using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using FileHelpers;

namespace Calc
{
    public partial class Form1 : Form
    {
        double par_k = 1.3806E-23;
        double par_q = 1.6022E-19;
        double pi = 3.1416;
        double Ksi=0;
        double Vbi = 0;
        double W = 0;
        double Eg = 0;
        string fName;
        DataGrid data = new DataGrid();
        DataTable dtdata=new DataTable();
        DataTable dtRESULT = new DataTable();
        DataRow newrow;
        int fieldCount=0;
        int rowcount = 0;
        string[] headers;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIMPORT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
                using (var csv = new CachedCsvReader(new StreamReader(fName), true))
                {
                    data.DataSource = csv;
                    dgvIMPORT.DataSource = csv;
                    dtdata=CommonEngine.CsvToDataTable(fName, "ImportRecord", ',', true);
                    fieldCount = csv.FieldCount;
                    rowcount = dgvIMPORT.RowCount;
                    headers = csv.GetFieldHeaders();
                }
            }
        }
        private double getf(string str)
        {
            string [] s=str.Split(new char[] { '^' })[1].Split(new char[] { ' '});
            return Convert.ToDouble(s[0]);
        }
        private void buttonCALCULATE_Click(object sender, EventArgs e)
        {
            if (txtEg.Text==""|| txtEg.Text == ""|| txtVbi.Text == ""|| txtW.Text == "")
            {
                MessageBox.Show("Please input parameters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(fieldCount==0)
            {
                MessageBox.Show("Please import csv file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(headers[0]!="T(K)"|| headers[1].Substring(0, 2)!="f=")
            {
                MessageBox.Show("The csv file imported is invalid, please import correct TCf Sweep csv file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Ksi = Convert.ToDouble(txtKsi.Text);
            Eg = Convert.ToDouble(txtEg.Text);
            W = Convert.ToDouble(txtW.Text);
            Vbi = Convert.ToDouble(txtVbi.Text);
            dtRESULT = new DataTable();
            dtRESULT.Columns.Add("item", typeof(String));
            for(int i =1;i<fieldCount;i++)
            {
                dtRESULT.Columns.Add(headers[i], typeof(System.Double));
            }
            for(int j=0;j<rowcount;j++)
            {
                dtRESULT.Rows.Add("T=" + dgvIMPORT.Rows[j].Cells[0].Value.ToString());
                double[] Ea=new double[fieldCount-1];
                double[] Nt = new double[fieldCount - 1];
                for(int k=1;k<fieldCount;k++)
                {
                    double T = Convert.ToDouble(dgvIMPORT.Rows[j].Cells[0].Value.ToString());
                    double c1 = Convert.ToDouble(dgvIMPORT.Rows[j].Cells[k].Value.ToString());
                    double c2 = Convert.ToDouble(dgvIMPORT.Rows[j].Cells[k+1<fieldCount?k+1:fieldCount-1].Value.ToString());
                    double lnw1 = System.Math.Log(2 * pi * getf(headers[k]));
                    double lnw2 = k + 1 < fieldCount ? System.Math.Log(2 * pi * getf(headers[k+1])) : 0;
                    Ea[k-1] = par_k * T * System.Math.Log(Ksi * T * T / pi / getf(headers[k]))/par_q;
                    Nt[k - 1] = -2 * System.Math.Pow(Vbi, 1.5) / (W * par_k * T * System.Math.Sqrt(par_q) * System.Math.Sqrt(par_q * Vbi - (Eg - Ea[k - 1]))) * (c2-c1) / (lnw2-lnw1);
                }
                newrow = dtRESULT.NewRow();
                newrow[0] = "Ea";
                for(int k=1;k<fieldCount;k++)
                {
                    newrow[k] = Ea[k - 1];
                }
                dtRESULT.Rows.Add(newrow);
                newrow = dtRESULT.NewRow();
                newrow[0] = "Nt";
                for (int k = 1; k < fieldCount; k++)
                {
                    newrow[k] = Nt[k - 1];
                }
                dtRESULT.Rows.Add(newrow);
            }
            dgvRESULT.DataSource = dtRESULT;
        }

        private void buttonEXPORT_Click(object sender, EventArgs e)
        {
            dataGridViewToCSV(dgvRESULT);
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DOS-EA Calculator \nDeveloped for TCf Sweep\nVersion 1.0\nBuilt on 02/28/2018", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
