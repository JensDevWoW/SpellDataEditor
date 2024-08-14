using System;
using System.Windows.Forms;

namespace SpellDataEditor
{
    public partial class AuraForm : Form
    {
        private AuraData auraData;

        public AuraForm(AuraData aura)
        {
            InitializeComponent();
            auraData = aura;
            LoadAuraData();
        }

        private void LoadAuraData()
        {
            if (auraData != null)
            {
                auraIdChange.Text = auraData.auraId.ToString();
                auraNameChange.Text = auraData.name;
                durationChange.Text = auraData.duration.ToString();
                periodicCheckBox.Checked = auraData.periodic;
                timeTimeChange.Text = auraData.ticktime.ToString();
                stacksChange.Text = auraData.stacks.ToString();
                auraEffectsChange.Text = auraData.effects;
                auraPositiveCheckBox.Checked = auraData.isPositive;
                auraTypeChange.Text = auraData.type;
                auraScriptChange.Text = auraData.aurascript;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update the auraData object with the form values
            auraData.auraId = int.Parse(auraIdChange.Text);
            auraData.name = auraNameChange.Text;
            auraData.duration = float.Parse(durationChange.Text);
            auraData.periodic = periodicCheckBox.Checked;
            auraData.ticktime = float.Parse(timeTimeChange.Text);
            auraData.stacks = int.Parse(stacksChange.Text);
            auraData.effects = auraEffectsChange.Text;
            auraData.isPositive = auraPositiveCheckBox.Checked;
            auraData.type = auraTypeChange.Text;
            auraData.aurascript = auraScriptChange.Text;

            // Close the form after saving
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
