﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccineTrackingSystem.DataStructures;

namespace VaccineTrackingSystem
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region  properties
        private String _Name;
        [Category("Custom Props")]
        public String name
        {
            get { return _Name; }
            set { _Name = value;  namelabel.Text = value; }
        }
        private String _ID;
        [Category("Custom Props")]
        public String id
        {
            get { return _ID; }
            set { _ID = value; IDlabel.Text = value; }
        }
        private  String _password;
        [Category("Custom Props")]
        public String pass
        {
            get { return _password; }
            set { _password = value;  Passwordlabel.Text = value ; }
        }
        [Category("Custom Props")]
        private String _gender;
         public String Gender
        {
            get { return _gender; }
            set { _gender = value; genderlabel.Text = value; }
        }
        [Category("Custom Props")]
        private int _Age;
        [Category("Custom Props")]
        public int age
        {
            get { return _Age; }
            set { _Age = value; Agelabel.Text = value.ToString() ; }
        }
        [Category("Custom Props")]
        private String _Country;
        public String country
        {
            get { return _Country; }
            set { _Country = value; countrylabel.Text = value; }
        }


        #endregion;


        private void ListItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
        
    }
}
