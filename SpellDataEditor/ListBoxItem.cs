public class ListBoxItem
{
    public string DisplayText { get; set; }
    public int SpellId { get; set; }

    public ListBoxItem(string displayText, int spellId)
    {
        DisplayText = displayText;
        SpellId = spellId;
    }

    public override string ToString()
    {
        return DisplayText;
    }
}
