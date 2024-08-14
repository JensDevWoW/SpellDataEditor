public class SpellListItem
{
    public int SpellId { get; set; }
    public string SpellName { get; set; }

    public SpellListItem(int spellId, string spellName)
    {
        SpellId = spellId;
        SpellName = spellName;
    }

    public override string ToString()
    {
        return $"{SpellId} - {SpellName}";
    }
}
