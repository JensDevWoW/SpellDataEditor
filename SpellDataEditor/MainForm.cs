using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpellDataEditor
{
    public partial class MainForm : Form
    {
        private SpellDataHandler spellDataHandler;

        public MainForm()
        {
            InitializeComponent();
            spellDataHandler = new SpellDataHandler();
            LoadSpells();
        }

        private void LoadSpells()
        {
            lstSpells.Items.Clear();
            foreach (var spell in spellDataHandler.Spells)
            {
                lstSpells.Items.Add(new SpellListItem(spell.id, spell.name));
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (lstSpells.SelectedItem != null)
            {
                var spell = spellDataHandler.GetSpellById(int.Parse(idChange.Text));
                spell.name = nameChange.Text;
                spell.castTime = float.Parse(castTimeChange.Text);
                spell.type = typeChange.Text;
                spell.manaCost = int.Parse(manaCostChange.Text);
                spell.spellTime = spellTimeCheckBox.Checked;
                spell.speed = float.Parse(speedChange.Text);
                spell.positive = positiveCheckBox.Checked;
                spell.basepoints = int.Parse(basePointsChange.Text);
                spell.damageclass = damageClassChange.Text;
                spell.effects = effectsChange.Text;
                spell.spellscript = spellScriptChange.Text;
                spell.cooldown = int.Parse(cooldownChange.Text);
                spell.attributes = attributesChange.Text;
                spell.flags = flagsChange.Text;

                // Handle aura data
                /*if (spell.aura != null)
                {
                    spell.aura.auraId = int.Parse(auraIdChange.Text);
                    spell.aura.name = auraNameChange.Text;
                    spell.aura.duration = float.Parse(auraDurationChange.Text);
                    spell.aura.periodic = periodicCheckBox.Checked;
                    spell.aura.ticktime = float.Parse(tickTimeChange.Text);
                    spell.aura.stacks = int.Parse(stacksChange.Text);
                    spell.aura.effects = auraEffectsChange.Text;
                    spell.aura.isPositive = isPositiveCheckBox.Checked;
                    spell.aura.type = auraTypeChange.Text;
                    spell.aura.aurascript = auraScriptChange.Text;
                }*/

                spellDataHandler.SaveSpellData();
                LoadSpells(); // Refresh the list
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Add logic to reset fields here if needed
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (lstSpells.SelectedItem != null)
            {
                var spell = spellDataHandler.GetSpellById(int.Parse(idChange.Text));
                spellDataHandler.RemoveSpell(spell);
                LoadSpells(); // Refresh the list
                ClearSpellDetails(); // Clear the details from the form
            }
        }

        private void ClearSpellDetails()
        {
            idChange.Clear();
            nameChange.Clear();
            castTimeChange.Clear();
            typeChange.Clear();
            manaCostChange.Clear();
            spellTimeCheckBox.Checked = false;
            speedChange.Clear();
            positiveCheckBox.Checked = false;
            basePointsChange.Clear();
            damageClassChange.Clear();
            effectsChange.Clear();
            spellScriptChange.Clear();
            cooldownChange.Clear();
            attributesChange.Clear();
            flagsChange.Clear();

            // Clear aura data fields
            /*auraIdChange.Clear();
            auraNameChange.Clear();
            auraDurationChange.Clear();
            periodicCheckBox.Checked = false;
            tickTimeChange.Clear();
            stacksChange.Clear();
            auraEffectsChange.Clear();
            isPositiveCheckBox.Checked = false;
            auraTypeChange.Clear();
            auraScriptChange.Clear();*/
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var foundSpell = spellDataHandler.Spells.FirstOrDefault(spell => spell.name.ToLower().Contains(searchText));

            if (foundSpell != null)
            {
                for (int i = 0; i < lstSpells.Items.Count; i++)
                {
                    var item = (SpellListItem)lstSpells.Items[i];
                    if (item.SpellId == foundSpell.id)
                    {
                        lstSpells.SelectedIndex = i;
                        // Manually trigger the SelectedIndexChanged event
                        lstSpells_SelectedIndexChanged(lstSpells, EventArgs.Empty);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Spell not found.");
            }
        }

        private void lstSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSpells.SelectedItem != null)
            {
                var selectedSpellItem = (SpellListItem)lstSpells.SelectedItem;
                var selectedSpell = spellDataHandler.Spells.FirstOrDefault(spell => spell.id == selectedSpellItem.SpellId);

                if (selectedSpell != null)
                {
                    // Bind spell data to the form controls
                    idChange.Text = selectedSpell.id.ToString();
                    nameChange.Text = selectedSpell.name;
                    castTimeChange.Text = selectedSpell.castTime.ToString();
                    typeChange.Text = selectedSpell.type;
                    manaCostChange.Text = selectedSpell.manaCost.ToString();
                    spellTimeCheckBox.Checked = selectedSpell.spellTime;
                    speedChange.Text = selectedSpell.speed.ToString();
                    positiveCheckBox.Checked = selectedSpell.positive;
                    basePointsChange.Text = selectedSpell.basepoints.ToString();
                    damageClassChange.Text = selectedSpell.damageclass;
                    effectsChange.Text = selectedSpell.effects;
                    spellScriptChange.Text = selectedSpell.spellscript;
                    cooldownChange.Text = selectedSpell.cooldown.ToString();
                    attributesChange.Text = selectedSpell.attributes;
                    flagsChange.Text = selectedSpell.flags;

                    // Handle aura data
                    /*if (selectedSpell.aura != null)
                    {
                        auraIdChange.Text = selectedSpell.aura.auraId.ToString();
                        auraNameChange.Text = selectedSpell.aura.name;
                        auraDurationChange.Text = selectedSpell.aura.duration.ToString();
                        periodicCheckBox.Checked = selectedSpell.aura.periodic;
                        tickTimeChange.Text = selectedSpell.aura.ticktime.ToString();
                        stacksChange.Text = selectedSpell.aura.stacks.ToString();
                        auraEffectsChange.Text = selectedSpell.aura.effects;
                        isPositiveCheckBox.Checked = selectedSpell.aura.isPositive;
                        auraTypeChange.Text = selectedSpell.aura.type;
                        auraScriptChange.Text = selectedSpell.aura.aurascript;
                    }
                    else
                    {
                        ClearAuraFields();
                    }*/
                }
            }
        }

        /*private void ClearAuraFields()
        {
            auraIdChange.Clear();
            auraNameChange.Clear();
            auraDurationChange.Clear();
            periodicCheckBox.Checked = false;
            tickTimeChange.Clear();
            stacksChange.Clear();
            auraEffectsChange.Clear();
            isPositiveCheckBox.Checked = false;
            auraTypeChange.Clear();
            auraScriptChange.Clear();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            // Find the highest spellId currently in the list
            int maxId = spellDataHandler.Spells.Max(spell => spell.id);

            // Create a new spell with the next available ID
            SpellData newSpell = new SpellData
            {
                id = maxId + 1,
                name = "New Spell",
                schoolMask = "",
                type = "",
                manaCost = 0,
                castTime = 0.0f,
                spellTime = false,
                speed = 0.0f,
                positive = true,
                basepoints = 0,
                damageclass = "",
                effects = "",
                spellscript = "",
                cooldown = 0,
                attributes = "",
                flags = "",
                aura = new AuraData()
            };

            // Add the new spell to the list of spells
            spellDataHandler.AddSpell(newSpell);

            // Add the new spell to the ListBox
            lstSpells.Items.Add(new SpellListItem(newSpell.id, newSpell.name));

            // Select the newly created spell in the ListBox
            lstSpells.SelectedIndex = lstSpells.Items.Count - 1;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpSpellDetails_Enter(object sender, EventArgs e)
        {

        }

        private void auraDataButton_Click(object sender, EventArgs e)
        {
            if (lstSpells.SelectedItem != null)
            {
                var selectedSpellItem = (SpellListItem)lstSpells.SelectedItem;
                var selectedSpell = spellDataHandler.Spells.FirstOrDefault(spell => spell.id == selectedSpellItem.SpellId);

                if (selectedSpell != null && selectedSpell.aura != null)
                {
                    using (var auraForm = new AuraForm(selectedSpell.aura))
                    {
                        if (auraForm.ShowDialog() == DialogResult.OK)
                        {
                            // The aura data was updated in the AuraForm
                            // You might want to save the changes or update the UI
                            spellDataHandler.SaveSpellData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No aura information available for this spell.");
                }
            }

        }
    }
}
