using System.Text.RegularExpressions;

namespace Napier__Douglas___Comp_Sci_Final
{
    public partial class MarkdownToHTMLForm : Form
    {
        private StreamWriter MarkdownFileWriter;
        private StreamReader MarkdownFileReader;
        private StreamWriter HTMLFileWriter;
        public MarkdownToHTMLForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"I am an aspiring software Developer who is most proficient at python, a programming language!");
        }

        private void MarkdownCheatSheetToolStripMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("# H1 -> <h1>H1</h1> \n# H2 -> <h2>H2</h2> \n# H3 -> <h3>H3</h3> \n**Bold Text** -> <b>Bold Text</b> \n*Italicized Text* -> <i>Italicized Text</i> \n>Block quote -> <blockquote>Block quote</blockquote> \n1. First item 2. Second item. -> <ol> <li>First item </li> <li>Second item</li> \n- First item - Second item -> <ul> <li>First item</li> <li>Second item</li> \n`Code` -> <code>Code</code> \n--- -> </hr> \n~~Strike through~~ -> <s>Strike through</s>");
        }

        private void SaveMarkdownAsToolStripMenu_Click(object sender, EventArgs e)
        {
            DialogResult result;    // Holds result of SaveFileDialog
            string fileName;        // Holds file name chosen from SaveFileDialog

            // Create and show a SaveFileDialog to enable users choose where to save file
            using (SaveFileDialog filePicker = new SaveFileDialog())
            {
                filePicker.InitialDirectory = Application.StartupPath;
                result = filePicker.ShowDialog();   // Show SaveFileDialog
                fileName = filePicker.FileName;     // File name chosen by user in SaveFileDialog
            } // end using

            // If the user clicked the "OK" button in the SaveFileDialog...
            if (result == DialogResult.OK)
            {
                try
                {
                    // Open file with write access
                    FileStream outputStream = new FileStream(fileName, FileMode.OpenOrCreate,
                                                           FileAccess.Write);

                    // Sets file to where data is written
                    MarkdownFileWriter = new StreamWriter(outputStream);
                    MarkdownFileWriter.Write(MarkdownTextBox.Text);
                    MarkdownFileWriter.Close();
                }
                catch (IOException)
                {
                    // Notify user if file does not exist
                    MessageBox.Show("Error opening file.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    // User closed the SaveFileDialog without clicking s file
                } // end try
            }
            else
            {    // Otherwise, show an error message
                // If the user did not select a file...
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid file name.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // end if
            } // end if
        }

        private void SaveHTMLAsToolStripMenu_Click(object sender, EventArgs e)
        {
            DialogResult result;    // Holds result of SaveFileDialog
            string fileName;        // Holds file name chosen from SaveFileDialog

            // Create and show a SaveFileDialog to enable users choose where to save file
            using (SaveFileDialog filePicker = new SaveFileDialog())
            {
                filePicker.InitialDirectory = Application.StartupPath;
                result = filePicker.ShowDialog();   // Show SaveFileDialog
                fileName = filePicker.FileName;     // File name chosen by user in SaveFileDialog
            } // end using

            // If the user clicked the "OK" button in the SaveFileDialog...
            if (result == DialogResult.OK)
            {
                try
                {
                    // Open file with write access
                    FileStream outputStream = new FileStream(fileName, FileMode.OpenOrCreate,
                                                           FileAccess.Write);

                    // Sets file to where data is written
                    HTMLFileWriter = new StreamWriter(outputStream);
                    HTMLFileWriter.Write(HTMLTextBox.Text);
                    HTMLFileWriter.Close();
                }
                catch (IOException)
                {
                    // Notify user if file does not exist
                    MessageBox.Show("Error opening file.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    // User closed the SaveFileDialog without clicking s file
                } // end try
            }
            else
            {    // Otherwise, show an error message
                // If the user did not select a file...
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid file name.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // end if
            } // end if
        }

        private void OpenToolStripMenu_Click(object sender, EventArgs e)
        {
            string CurrentText = null;
            DialogResult result;
            string fileName;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                result = openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;
            }

            if (result == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    try
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            CurrentText += line;
                            CurrentText += " ";
                            MarkdownTextBox.Text = CurrentText;
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("There was an issue opening the file.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void NewToolStripMenu_Click(object sender, EventArgs e)
        {
            MarkdownTextBox.Text = "Markdown Goes Here";
            HTMLTextBox.Text = "HTML will be here";
            MarkdownTextBox.Focus();
        }

        private void ConvertMarkdownToHTMLButton_Click(object sender, EventArgs e)
        {
            int numberOfLines = MarkdownTextBox.Text.Split('\n').Length;
            int numberOfWords = MarkdownTextBox.Text.Split(' ').Length;
            NumberOfWordsStatusLabel.Text = $"Number of words: {numberOfWords}";
            NumberOfLinesStatusLabel.Text = $"Number of lines: {numberOfLines}";
            int MAXLINES = 13;
            string StringToConvert = MarkdownTextBox.Text;
            string updatedStringToConvert = StringToConvert;

            try
            {
                int count = 1;
                int CSVTracker = 1;
                string ourStringToConvert = MarkdownTextBox.Text;
                IDictionary<int, string> ourDictionary = new Dictionary<int, string>();

                using (StreamReader sr = new StreamReader("PatternsAndAllReplacements.csv"))
                {
                    RegexPatternsAndReplacements ourRegexPatternsAndReplacements = new RegexPatternsAndReplacements();

                    for (int i = 0; i < MAXLINES; i++)
                    {
                        string ourLine = sr.ReadLine();
                        ourDictionary.Add(count, ourLine);
                        count++;
                    }

                    // Time to try making this for loop
                    for (int j = 1; j <= MAXLINES - 1; j++)
                    {
                        string test = ourDictionary[j];
                        var ourcsv = test.Split(',');
                        ourRegexPatternsAndReplacements.TextPattern = ourcsv[0];
                        ourRegexPatternsAndReplacements.TextPatternReplacement = ourcsv[1];
                        string TextCorrected = Regex.Replace(updatedStringToConvert,
                            ourRegexPatternsAndReplacements.TextPattern,
                            ourRegexPatternsAndReplacements.TextPatternReplacement);
                        updatedStringToConvert = TextCorrected;
                        HTMLTextBox.Text = updatedStringToConvert;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error trying to process the text.");
            }
        }
    }
}