namespace SpellDataEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstSpells = new ListBox();
            txtSearch = new TextBox();
            grpSpellDetails = new GroupBox();
            flagsChange = new TextBox();
            attributesChange = new TextBox();
            cooldownChange = new TextBox();
            spellScriptChange = new TextBox();
            effectsChange = new TextBox();
            damageClassChange = new TextBox();
            basePointsChange = new TextBox();
            positiveCheckBox = new CheckBox();
            spellTimeCheckBox = new CheckBox();
            speedChange = new TextBox();
            manaCostChange = new TextBox();
            typeChange = new TextBox();
            flagsLabel = new Label();
            attributesLabel = new Label();
            cdLabel = new Label();
            ssLabel = new Label();
            effectsLabel = new Label();
            dClassLabel = new Label();
            bpLabel = new Label();
            positiveLabel = new Label();
            speedLabel = new Label();
            spellTimeLabel = new Label();
            manaCostLabel = new Label();
            typeLabel = new Label();
            button1 = new Button();
            deleteButton = new Button();
            resetButton = new Button();
            saveButton = new Button();
            castTimeChange = new TextBox();
            castTime = new Label();
            nameChange = new TextBox();
            spellName = new Label();
            idChange = new TextBox();
            spellId = new Label();
            searchButton = new Button();
            auraDataButton = new Button();
            grpSpellDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lstSpells
            // 
            lstSpells.FormattingEnabled = true;
            lstSpells.Location = new Point(638, 128);
            lstSpells.Name = "lstSpells";
            lstSpells.Size = new Size(150, 284);
            lstSpells.TabIndex = 0;
            lstSpells.SelectedIndexChanged += lstSpells_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(638, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 27);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Enter Spell Id";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // grpSpellDetails
            // 
            grpSpellDetails.Controls.Add(auraDataButton);
            grpSpellDetails.Controls.Add(flagsChange);
            grpSpellDetails.Controls.Add(attributesChange);
            grpSpellDetails.Controls.Add(cooldownChange);
            grpSpellDetails.Controls.Add(spellScriptChange);
            grpSpellDetails.Controls.Add(effectsChange);
            grpSpellDetails.Controls.Add(damageClassChange);
            grpSpellDetails.Controls.Add(basePointsChange);
            grpSpellDetails.Controls.Add(positiveCheckBox);
            grpSpellDetails.Controls.Add(spellTimeCheckBox);
            grpSpellDetails.Controls.Add(speedChange);
            grpSpellDetails.Controls.Add(manaCostChange);
            grpSpellDetails.Controls.Add(typeChange);
            grpSpellDetails.Controls.Add(flagsLabel);
            grpSpellDetails.Controls.Add(attributesLabel);
            grpSpellDetails.Controls.Add(cdLabel);
            grpSpellDetails.Controls.Add(ssLabel);
            grpSpellDetails.Controls.Add(effectsLabel);
            grpSpellDetails.Controls.Add(dClassLabel);
            grpSpellDetails.Controls.Add(bpLabel);
            grpSpellDetails.Controls.Add(positiveLabel);
            grpSpellDetails.Controls.Add(speedLabel);
            grpSpellDetails.Controls.Add(spellTimeLabel);
            grpSpellDetails.Controls.Add(manaCostLabel);
            grpSpellDetails.Controls.Add(typeLabel);
            grpSpellDetails.Controls.Add(button1);
            grpSpellDetails.Controls.Add(deleteButton);
            grpSpellDetails.Controls.Add(resetButton);
            grpSpellDetails.Controls.Add(saveButton);
            grpSpellDetails.Controls.Add(castTimeChange);
            grpSpellDetails.Controls.Add(castTime);
            grpSpellDetails.Controls.Add(nameChange);
            grpSpellDetails.Controls.Add(spellName);
            grpSpellDetails.Controls.Add(idChange);
            grpSpellDetails.Controls.Add(spellId);
            grpSpellDetails.Location = new Point(12, 12);
            grpSpellDetails.Name = "grpSpellDetails";
            grpSpellDetails.Size = new Size(604, 400);
            grpSpellDetails.TabIndex = 2;
            grpSpellDetails.TabStop = false;
            grpSpellDetails.Text = "Spell Details";
            grpSpellDetails.Enter += grpSpellDetails_Enter;
            // 
            // flagsChange
            // 
            flagsChange.Location = new Point(370, 113);
            flagsChange.Name = "flagsChange";
            flagsChange.Size = new Size(228, 27);
            flagsChange.TabIndex = 34;
            // 
            // attributesChange
            // 
            attributesChange.Location = new Point(401, 80);
            attributesChange.Name = "attributesChange";
            attributesChange.Size = new Size(197, 27);
            attributesChange.TabIndex = 33;
            // 
            // cooldownChange
            // 
            cooldownChange.Location = new Point(367, 49);
            cooldownChange.Name = "cooldownChange";
            cooldownChange.Size = new Size(36, 27);
            cooldownChange.TabIndex = 32;
            cooldownChange.TextChanged += textBox8_TextChanged;
            // 
            // spellScriptChange
            // 
            spellScriptChange.Location = new Point(367, 16);
            spellScriptChange.Name = "spellScriptChange";
            spellScriptChange.Size = new Size(125, 27);
            spellScriptChange.TabIndex = 31;
            // 
            // effectsChange
            // 
            effectsChange.Location = new Point(102, 332);
            effectsChange.Name = "effectsChange";
            effectsChange.Size = new Size(210, 27);
            effectsChange.TabIndex = 30;
            // 
            // damageClassChange
            // 
            damageClassChange.Location = new Point(111, 299);
            damageClassChange.Name = "damageClassChange";
            damageClassChange.Size = new Size(125, 27);
            damageClassChange.TabIndex = 29;
            // 
            // basePointsChange
            // 
            basePointsChange.Location = new Point(87, 266);
            basePointsChange.Name = "basePointsChange";
            basePointsChange.Size = new Size(66, 27);
            basePointsChange.TabIndex = 28;
            // 
            // positiveCheckBox
            // 
            positiveCheckBox.AutoSize = true;
            positiveCheckBox.Location = new Point(87, 242);
            positiveCheckBox.Name = "positiveCheckBox";
            positiveCheckBox.Size = new Size(18, 17);
            positiveCheckBox.TabIndex = 27;
            positiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // spellTimeCheckBox
            // 
            spellTimeCheckBox.AutoSize = true;
            spellTimeCheckBox.Location = new Point(87, 180);
            spellTimeCheckBox.Name = "spellTimeCheckBox";
            spellTimeCheckBox.Size = new Size(18, 17);
            spellTimeCheckBox.TabIndex = 26;
            spellTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // speedChange
            // 
            speedChange.Location = new Point(85, 208);
            speedChange.Name = "speedChange";
            speedChange.Size = new Size(46, 27);
            speedChange.TabIndex = 25;
            // 
            // manaCostChange
            // 
            manaCostChange.Location = new Point(85, 146);
            manaCostChange.Name = "manaCostChange";
            manaCostChange.Size = new Size(68, 27);
            manaCostChange.TabIndex = 23;
            // 
            // typeChange
            // 
            typeChange.Location = new Point(85, 116);
            typeChange.Name = "typeChange";
            typeChange.Size = new Size(80, 27);
            typeChange.TabIndex = 22;
            // 
            // flagsLabel
            // 
            flagsLabel.AutoSize = true;
            flagsLabel.Location = new Point(284, 116);
            flagsLabel.Name = "flagsLabel";
            flagsLabel.Size = new Size(80, 20);
            flagsLabel.TabIndex = 21;
            flagsLabel.Text = "Spell Flags";
            // 
            // attributesLabel
            // 
            attributesLabel.AutoSize = true;
            attributesLabel.Location = new Point(284, 83);
            attributesLabel.Name = "attributesLabel";
            attributesLabel.Size = new Size(111, 20);
            attributesLabel.TabIndex = 20;
            attributesLabel.Text = "Spell Attributes";
            // 
            // cdLabel
            // 
            cdLabel.AutoSize = true;
            cdLabel.Location = new Point(284, 52);
            cdLabel.Name = "cdLabel";
            cdLabel.Size = new Size(77, 20);
            cdLabel.TabIndex = 19;
            cdLabel.Text = "Cooldown";
            // 
            // ssLabel
            // 
            ssLabel.AutoSize = true;
            ssLabel.Location = new Point(281, 19);
            ssLabel.Name = "ssLabel";
            ssLabel.Size = new Size(80, 20);
            ssLabel.TabIndex = 18;
            ssLabel.Text = "SpellScript";
            // 
            // effectsLabel
            // 
            effectsLabel.AutoSize = true;
            effectsLabel.Location = new Point(6, 332);
            effectsLabel.Name = "effectsLabel";
            effectsLabel.Size = new Size(90, 20);
            effectsLabel.TabIndex = 17;
            effectsLabel.Text = "Spell Effects";
            // 
            // dClassLabel
            // 
            dClassLabel.AutoSize = true;
            dClassLabel.Location = new Point(6, 299);
            dClassLabel.Name = "dClassLabel";
            dClassLabel.Size = new Size(99, 20);
            dClassLabel.TabIndex = 16;
            dClassLabel.Text = "DamageClass";
            // 
            // bpLabel
            // 
            bpLabel.AutoSize = true;
            bpLabel.Location = new Point(5, 269);
            bpLabel.Name = "bpLabel";
            bpLabel.Size = new Size(85, 20);
            bpLabel.TabIndex = 15;
            bpLabel.Text = "BasePoints-";
            // 
            // positiveLabel
            // 
            positiveLabel.AutoSize = true;
            positiveLabel.Location = new Point(5, 239);
            positiveLabel.Name = "positiveLabel";
            positiveLabel.Size = new Size(73, 20);
            positiveLabel.TabIndex = 14;
            positiveLabel.Text = "Positive - ";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new Point(5, 208);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(65, 20);
            speedLabel.TabIndex = 13;
            speedLabel.Text = "Speed - ";
            // 
            // spellTimeLabel
            // 
            spellTimeLabel.AutoSize = true;
            spellTimeLabel.Location = new Point(6, 177);
            spellTimeLabel.Name = "spellTimeLabel";
            spellTimeLabel.Size = new Size(85, 20);
            spellTimeLabel.TabIndex = 12;
            spellTimeLabel.Text = "SpellTime -";
            // 
            // manaCostLabel
            // 
            manaCostLabel.AutoSize = true;
            manaCostLabel.Location = new Point(5, 146);
            manaCostLabel.Name = "manaCostLabel";
            manaCostLabel.Size = new Size(85, 20);
            manaCostLabel.TabIndex = 11;
            manaCostLabel.Text = "ManaCost -";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(6, 116);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(54, 20);
            typeLabel.TabIndex = 10;
            typeLabel.Text = "Type - ";
            // 
            // button1
            // 
            button1.Location = new Point(137, 365);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 9;
            button1.Text = "Create New Spell";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 10F);
            deleteButton.Location = new Point(6, 365);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(125, 29);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete Spell";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 10F);
            resetButton.Location = new Point(404, 365);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 7;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 10F);
            saveButton.Location = new Point(504, 365);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // castTimeChange
            // 
            castTimeChange.Location = new Point(85, 83);
            castTimeChange.Name = "castTimeChange";
            castTimeChange.Size = new Size(40, 27);
            castTimeChange.TabIndex = 5;
            // 
            // castTime
            // 
            castTime.AutoSize = true;
            castTime.Location = new Point(5, 83);
            castTime.Name = "castTime";
            castTime.Size = new Size(88, 20);
            castTime.TabIndex = 4;
            castTime.Text = "Cast Time - ";
            // 
            // nameChange
            // 
            nameChange.Location = new Point(85, 54);
            nameChange.Name = "nameChange";
            nameChange.Size = new Size(156, 27);
            nameChange.TabIndex = 3;
            // 
            // spellName
            // 
            spellName.AutoSize = true;
            spellName.Location = new Point(6, 54);
            spellName.Name = "spellName";
            spellName.Size = new Size(63, 20);
            spellName.TabIndex = 2;
            spellName.Text = "Name - ";
            // 
            // idChange
            // 
            idChange.Location = new Point(85, 21);
            idChange.Name = "idChange";
            idChange.Size = new Size(100, 27);
            idChange.TabIndex = 1;
            // 
            // spellId
            // 
            spellId.AutoSize = true;
            spellId.Location = new Point(6, 23);
            spellId.Name = "spellId";
            spellId.Size = new Size(75, 20);
            spellId.TabIndex = 0;
            spellId.Text = "Spell ID - ";
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            searchButton.Location = new Point(662, 45);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // auraDataButton
            // 
            auraDataButton.Font = new Font("Segoe UI", 10F);
            auraDataButton.Location = new Point(284, 163);
            auraDataButton.Name = "auraDataButton";
            auraDataButton.Size = new Size(156, 41);
            auraDataButton.TabIndex = 35;
            auraDataButton.Text = "Aura Information";
            auraDataButton.UseVisualStyleBackColor = true;
            auraDataButton.Click += auraDataButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchButton);
            Controls.Add(grpSpellDetails);
            Controls.Add(txtSearch);
            Controls.Add(lstSpells);
            Name = "MainForm";
            Text = "MainForm";
            grpSpellDetails.ResumeLayout(false);
            grpSpellDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSpells;
        private TextBox txtSearch;
        private GroupBox grpSpellDetails;
        private TextBox idChange;
        private Label spellId;
        private TextBox castTimeChange;
        private Label castTime;
        private TextBox nameChange;
        private Label spellName;
        private Button searchButton;
        private Button resetButton;
        private Button saveButton;
        private Button deleteButton;
        private Button button1;
        private Label positiveLabel;
        private Label speedLabel;
        private Label spellTimeLabel;
        private Label manaCostLabel;
        private Label typeLabel;
        private Label effectsLabel;
        private Label dClassLabel;
        private Label bpLabel;
        private Label flagsLabel;
        private Label attributesLabel;
        private Label cdLabel;
        private Label ssLabel;
        private TextBox speedChange;
        private TextBox manaCostChange;
        private TextBox typeChange;
        private TextBox cooldownChange;
        private TextBox spellScriptChange;
        private TextBox effectsChange;
        private TextBox damageClassChange;
        private TextBox basePointsChange;
        private CheckBox positiveCheckBox;
        private CheckBox spellTimeCheckBox;
        private TextBox flagsChange;
        private TextBox attributesChange;
        private Button auraDataButton;
    }
}