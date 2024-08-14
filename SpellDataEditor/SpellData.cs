using System;

namespace SpellDataEditor
{
    [Serializable]
    public class SpellData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string schoolMask { get; set; }
        public string type { get; set; }
        public int manaCost { get; set; }
        public float castTime { get; set; }
        public bool spellTime { get; set; }
        public float speed { get; set; }
        public bool positive { get; set; }
        public int basepoints { get; set; }
        public string damageclass { get; set; }
        public string effects { get; set; }
        public string spellscript { get; set; }
        public int cooldown { get; set; }
        public string attributes { get; set; }
        public string flags { get; set; }
        public AuraData aura { get; set; }
    }

    [Serializable]
    public class AuraData
    {
        public int auraId { get; set; }
        public string name { get; set; }
        public float duration { get; set; }
        public bool periodic { get; set; }
        public float ticktime { get; set; }
        public int stacks { get; set; }
        public string effects { get; set; }
        public bool isPositive { get; set; }
        public string type { get; set; }
        public string aurascript { get; set; }
    }
}
