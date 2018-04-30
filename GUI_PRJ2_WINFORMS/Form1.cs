using HomeAutomationLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PRJ2_WINFORMS
{
    public partial class Form1 : Form
    {
        private List<Apparat> myApparats = new List<Apparat>();
        
        public Form1()
        {
            InitializeComponent();
            //Set up dummy data
            SetupData();
            //Set up list view
            SetupListView();
        }
        
        /// <summary>
        /// Sets up the list view
        /// </summary>
        private void SetupListView()
        {
           
            listView1.FullRowSelect = true;
            //Call extender methods
            ListViewExtender extender = new ListViewExtender(listView1);
            // extend 2nd column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(1);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;

            extender.AddColumn(buttonAction);

            updateListView();
        }

        private void updateListView()
        {
            //Delete existing listview items
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Remove();
                i--;
            }

            //Add apparats
            for (int i = 0; i < myApparats.Count; i++)
            {
                ListViewItem item = listView1.Items.Add(myApparats[i].Navn_);
                item.SubItems.Add(myApparats[i].Port_.ToString());
            }

        }
        /// <summary>
        /// Private helper method for list view button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
        }
        /// <summary>
        /// Sets up dummy data
        /// </summary>
        private void SetupData()
        {
            myApparats.Add(new Apparat());
        }
        

        private void addApparat_Click(object sender, EventArgs e)
        {
            MainView.SelectTab(AddMenu);
            ApparatMenu.Enabled = false;
            AddMenu.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainView.SelectTab(ApparatMenu);
            ApparatMenu.Enabled = true;
            AddMenu.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Apparat apparatToAdd = new Apparat();
            apparatToAdd.Navn_ = apparatNameTextbox.Text;
            apparatToAdd.Port_ = ++portComboBox.SelectedIndex;
            foreach(object indexChecked in functionalityCheckBox.CheckedIndices)
            {
                apparatToAdd.Funktionalitet_ |= (Func)indexChecked;
            }
            myApparats.Add(apparatToAdd);
            updateListView();
            MainView.SelectTab(ApparatMenu);
            ApparatMenu.Enabled = true;
            AddMenu.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
