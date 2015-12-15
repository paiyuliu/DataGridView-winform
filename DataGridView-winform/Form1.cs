﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_winform {
    public partial class Form1 : Form {

        private DataTable sampleData() {
            using (DataTable table = new DataTable()) {
                // Add columns.
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Gender", typeof(string));
                table.Columns.Add("Married ", typeof(int));
                table.Columns.Add("Birthday", typeof(DateTime));

                // Add rows.
                table.Rows.Add("Allen", "Male", 0, DateTime.Now);
                table.Rows.Add("Kevin", "Male", 1, DateTime.Now);
                table.Rows.Add("Dean", "Male", 0, DateTime.Today);
                table.Rows.Add("Jenny", "Female", 1, DateTime.Today);
                return table;
            }
        }

        public DataTable dt;
        public Form1() {
            InitializeComponent();
            dt = dt ?? sampleData();
            gvInit();
        }

        private void gvInit() {
            gvSample.DataSource = dt;
        }

    }
}