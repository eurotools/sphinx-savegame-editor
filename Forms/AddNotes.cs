using SavegameEditor.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SavegameEditor.Forms
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class AddNotes : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public AddNotes()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddNotes_Load(object sender, EventArgs e)
        {
            Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Text_");
            string[] hashcodesArray = itemsSection.Values.ToArray();

            //Note title
            cbxTitle.BeginUpdate();
            cbxTitle.Items.AddRange(hashcodesArray);
            if (cbxTitle.Items.Count > 0)
            {
                cbxTitle.SelectedIndex = 0;
            }
            cbxTitle.EndUpdate();

            //Note description
            cbxDescription.BeginUpdate();
            cbxDescription.Items.AddRange(hashcodesArray);
            if (cbxDescription.Items.Count > 0)
            {
                cbxDescription.SelectedIndex = 0;
            }
            cbxDescription.EndUpdate();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
