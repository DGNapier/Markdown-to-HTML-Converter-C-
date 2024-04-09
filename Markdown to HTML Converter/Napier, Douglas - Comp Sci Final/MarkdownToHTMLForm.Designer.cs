namespace Napier__Douglas___Comp_Sci_Final
{
    partial class MarkdownToHTMLForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainMenuStrip = new MenuStrip();
            FileToolStripMenu = new ToolStripMenuItem();
            NewToolStripMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            OpenToolStripMenu = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            SaveHTMLAsToolStripMenu = new ToolStripMenuItem();
            SaveMarkdownAsToolStripMenu = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            ExitToolStripMenu = new ToolStripMenuItem();
            HelpToolStripMenu = new ToolStripMenuItem();
            MarkdownCheatSheetToolStripMenu = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            AboutToolStripMenu = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            NumberOfLinesStatusLabel = new ToolStripStatusLabel();
            NumberOfWordsStatusLabel = new ToolStripStatusLabel();
            MarkdownTextBox = new TextBox();
            ConvertMarkdownToHTMLButton = new Button();
            HTMLTextBox = new TextBox();
            MainMenuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenu, HelpToolStripMenu });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(939, 24);
            MainMenuStrip.TabIndex = 1;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenu
            // 
            FileToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenu, toolStripMenuItem1, OpenToolStripMenu, toolStripMenuItem2, SaveHTMLAsToolStripMenu, SaveMarkdownAsToolStripMenu, toolStripMenuItem3, ExitToolStripMenu });
            FileToolStripMenu.Name = "FileToolStripMenu";
            FileToolStripMenu.Size = new Size(37, 20);
            FileToolStripMenu.Text = "&File";
            // 
            // NewToolStripMenu
            // 
            NewToolStripMenu.Name = "NewToolStripMenu";
            NewToolStripMenu.Size = new Size(183, 22);
            NewToolStripMenu.Text = "&New";
            NewToolStripMenu.Click += NewToolStripMenu_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 6);
            // 
            // OpenToolStripMenu
            // 
            OpenToolStripMenu.Name = "OpenToolStripMenu";
            OpenToolStripMenu.Size = new Size(183, 22);
            OpenToolStripMenu.Text = "&Open...";
            OpenToolStripMenu.Click += OpenToolStripMenu_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 6);
            // 
            // SaveHTMLAsToolStripMenu
            // 
            SaveHTMLAsToolStripMenu.Name = "SaveHTMLAsToolStripMenu";
            SaveHTMLAsToolStripMenu.Size = new Size(183, 22);
            SaveHTMLAsToolStripMenu.Text = "Save H&TML As...";
            SaveHTMLAsToolStripMenu.Click += SaveHTMLAsToolStripMenu_Click;
            // 
            // SaveMarkdownAsToolStripMenu
            // 
            SaveMarkdownAsToolStripMenu.Name = "SaveMarkdownAsToolStripMenu";
            SaveMarkdownAsToolStripMenu.Size = new Size(183, 22);
            SaveMarkdownAsToolStripMenu.Text = "Save &Markdown As...";
            SaveMarkdownAsToolStripMenu.Click += SaveMarkdownAsToolStripMenu_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 6);
            // 
            // ExitToolStripMenu
            // 
            ExitToolStripMenu.Name = "ExitToolStripMenu";
            ExitToolStripMenu.Size = new Size(183, 22);
            ExitToolStripMenu.Text = "E&xit";
            ExitToolStripMenu.Click += exitToolStripMenuItem_Click;
            // 
            // HelpToolStripMenu
            // 
            HelpToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { MarkdownCheatSheetToolStripMenu, toolStripMenuItem4, AboutToolStripMenu });
            HelpToolStripMenu.Name = "HelpToolStripMenu";
            HelpToolStripMenu.Size = new Size(44, 20);
            HelpToolStripMenu.Text = "&Help";
            // 
            // MarkdownCheatSheetToolStripMenu
            // 
            MarkdownCheatSheetToolStripMenu.Name = "MarkdownCheatSheetToolStripMenu";
            MarkdownCheatSheetToolStripMenu.Size = new Size(197, 22);
            MarkdownCheatSheetToolStripMenu.Text = "&Markdown Cheat Sheet";
            MarkdownCheatSheetToolStripMenu.Click += MarkdownCheatSheetToolStripMenu_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(194, 6);
            // 
            // AboutToolStripMenu
            // 
            AboutToolStripMenu.Name = "AboutToolStripMenu";
            AboutToolStripMenu.Size = new Size(197, 22);
            AboutToolStripMenu.Text = "&About";
            AboutToolStripMenu.Click += AboutToolStripMenu_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { NumberOfLinesStatusLabel, NumberOfWordsStatusLabel });
            statusStrip1.Location = new Point(0, 544);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(939, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // NumberOfLinesStatusLabel
            // 
            NumberOfLinesStatusLabel.Name = "NumberOfLinesStatusLabel";
            NumberOfLinesStatusLabel.Size = new Size(95, 17);
            NumberOfLinesStatusLabel.Text = "Number of lines:";
            // 
            // NumberOfWordsStatusLabel
            // 
            NumberOfWordsStatusLabel.Name = "NumberOfWordsStatusLabel";
            NumberOfWordsStatusLabel.Size = new Size(103, 17);
            NumberOfWordsStatusLabel.Text = "Number of words:";
            // 
            // MarkdownTextBox
            // 
            MarkdownTextBox.Location = new Point(12, 27);
            MarkdownTextBox.Multiline = true;
            MarkdownTextBox.Name = "MarkdownTextBox";
            MarkdownTextBox.Size = new Size(408, 514);
            MarkdownTextBox.TabIndex = 3;
            MarkdownTextBox.Text = "Markdown Goes Here";
            // 
            // ConvertMarkdownToHTMLButton
            // 
            ConvertMarkdownToHTMLButton.Location = new Point(426, 247);
            ConvertMarkdownToHTMLButton.Name = "ConvertMarkdownToHTMLButton";
            ConvertMarkdownToHTMLButton.Size = new Size(87, 42);
            ConvertMarkdownToHTMLButton.TabIndex = 4;
            ConvertMarkdownToHTMLButton.Text = "&Convert";
            ConvertMarkdownToHTMLButton.UseVisualStyleBackColor = true;
            ConvertMarkdownToHTMLButton.Click += ConvertMarkdownToHTMLButton_Click;
            // 
            // HTMLTextBox
            // 
            HTMLTextBox.Location = new Point(519, 27);
            HTMLTextBox.Multiline = true;
            HTMLTextBox.Name = "HTMLTextBox";
            HTMLTextBox.ReadOnly = true;
            HTMLTextBox.Size = new Size(408, 514);
            HTMLTextBox.TabIndex = 5;
            HTMLTextBox.Text = "HTML will be here";
            // 
            // MarkdownToHTMLForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 566);
            Controls.Add(HTMLTextBox);
            Controls.Add(ConvertMarkdownToHTMLButton);
            Controls.Add(MarkdownTextBox);
            Controls.Add(statusStrip1);
            Controls.Add(MainMenuStrip);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MarkdownToHTMLForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Markdown to HTML";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem FileToolStripMenu;
        private ToolStripMenuItem NewToolStripMenu;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem OpenToolStripMenu;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem SaveHTMLAsToolStripMenu;
        private ToolStripMenuItem SaveMarkdownAsToolStripMenu;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem ExitToolStripMenu;
        private ToolStripMenuItem HelpToolStripMenu;
        private ToolStripMenuItem MarkdownCheatSheetToolStripMenu;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem AboutToolStripMenu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel NumberOfLinesStatusLabel;
        private ToolStripStatusLabel NumberOfWordsStatusLabel;
        private TextBox MarkdownTextBox;
        private Button ConvertMarkdownToHTMLButton;
        private TextBox HTMLTextBox;
    }
}