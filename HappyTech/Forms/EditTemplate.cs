using System;
using System.Data;
using System.Windows.Forms;

namespace HappyTech.Forms
{
    public partial class EditTemplate : Form
    {
        //Fill the listbox from the database
        public EditTemplate()
        {
            InitializeComponent();
            DataSet dataSet = DatabaseConnection.Instance().getData("SELECT * FROM Template WHERE Template_owner = '" + Login.loggedInEmployee + "'");
            templateChoice.DataSource = dataSet.Tables[0];
            templateChoice.DisplayMember = "Template_title";
        }
        //Display the text correlating to the title selected
        private void templateChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            templateTitle.Text = templateChoice.GetItemText(templateChoice.SelectedItem);
            DataSet dataSet = DatabaseConnection.Instance().getData("SELECT Template.Template_ID, Template.Template_title, Text.Text FROM Text INNER JOIN Template ON Template.Template_ID=Text.Template_ID WHERE Template.Template_title = '" + templateChoice.GetItemText(templateChoice.SelectedItem) + "'");
            previewTemplateText.DataSource = dataSet.Tables[0];
            previewTemplateText.DisplayMember = "Text";
        }
        //Display the selected text to update/delete
        private void previewTemplateText_SelectedIndexChanged(object sender, EventArgs e)
        {
            templateText.Text = previewTemplateText.GetItemText(previewTemplateText.SelectedItem);
        }
        //Update selected text
        private void updateText_Click(object sender, EventArgs e)
        {
            DatabaseConnection.Instance().insertDataNonQuery("UPDATE Text SET Text = '" + templateText.Text + "' WHERE Text = '" + previewTemplateText.GetItemText(previewTemplateText.SelectedItem) + "'");
        }
        //Delete selected text
        private void deleteText_Click(object sender, EventArgs e)
        {
            DatabaseConnection.Instance().insertDataNonQuery("DELETE FROM Text Where Text = '" + previewTemplateText.GetItemText(previewTemplateText.SelectedItem) + "'");
        }
    }
}
