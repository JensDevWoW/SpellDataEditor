using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace SpellDataEditor
{
    public class SpellDataHandler
    {
        public List<SpellData> Spells { get; private set; }

        public SpellDataHandler()
        {
            LoadSpellData();
        }

        public void LoadSpellData()
        {
            string json = File.ReadAllText("SpellData.json");
            var spellDataWrapper = JsonSerializer.Deserialize<SpellDataWrapper>(json);
            Spells = new List<SpellData>(spellDataWrapper.spells);
        }

        public void SaveSpellData()
        {
            // Check for duplicate spellIds
            var duplicateIds = Spells.GroupBy(spell => spell.id)
                                     .Where(group => group.Count() > 1)
                                     .Select(group => group.Key)
                                     .ToList();

            if (duplicateIds.Any())
            {
                string duplicateMessage = $"Cannot save. Duplicate spellId(s) found: {string.Join(", ", duplicateIds)}";
                MessageBox.Show(duplicateMessage, "Duplicate Spell ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Do not proceed with saving
            }

            // Proceed with saving if there are no duplicates
            var spellDataWrapper = new SpellDataWrapper { spells = Spells.ToArray() };
            string json = JsonSerializer.Serialize(spellDataWrapper, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("SpellData.json", json);
        }


        public SpellData GetSpellById(int id)
        {
            return Spells.Find(spell => spell.id == id);
        }

        public void AddSpell(SpellData spell)
        {
            Spells.Add(spell);
            SaveSpellData();
        }

        public void RemoveSpell(SpellData spell)
        {
            Spells.Remove(spell);
            SaveSpellData();
        }
    }
}
