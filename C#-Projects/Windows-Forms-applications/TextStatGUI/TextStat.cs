using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace TextStatGUI {
    public partial class FrmTextStat : Form {

        public FrmTextStat() {
            InitializeComponent();

        }

        private void FrmTextStat_Load(object sender, EventArgs e) {
            // When the form loads we hide the list view and seach txt
            lvOutputDictonary.Visible = false;
            lblNumOfUnqWords.Visible = false;
            lblOPUniqueWordCount.Visible = false;

            // Shrink form to smaller size since we hid the list view
            Size = new Size(420, 540);
        }

        private void btnClear_Click(object sender, EventArgs e) {
            // When we clear we re hide the list view and ensure all labels are cleared
            lvOutputDictonary.Visible = false;
            lblNumOfUnqWords.Visible = false;
            lblOPUniqueWordCount.Visible = false;
            TxtboxUserInput.Clear();
            lblOPUniqueWordCount.Text = "";
            lblOpNumOfSen.Text = "";
            lblOPTotalWordCount.Text = "0";
            lvOutputDictonary.Items.Clear();
            sslOutptErrors.Text = "Please enter the text you wish to analyze.";
           
            // re shrink the form 
            Size = new Size(420, 540);
        }

        private void btnAnalyze_Click(object sender, EventArgs e) {

            // Clears label before caculating results to ensure nothing lingers...
            lblOPUniqueWordCount.Text = "";
            lblOpNumOfSen.Text = "";
            lblOPTotalWordCount.Text = "0";
            lvOutputDictonary.Items.Clear();
            // will store the list of word that will be outputted to the .exc file
            List<string> listOfWords = new List<string>();

            try {

                // Here we will add to the List the words from the WordsToIgnore.dat file(which to always
                // be accessable is always copied  to output directory of the solution)
                List<string> wordsToIgnore = FileIO.Read("WordsToIgnore.dat");

                // throw error if txt is empty
                if (string.IsNullOrWhiteSpace(TxtboxUserInput.Text)) {
                    throw new Exception("An error occured. Please enter your text");
                }

                // else pass users txt to the TextStats class
                TextStats t = new TextStats(TxtboxUserInput.Text.ToString());
                // analyzes text
                t.ProccessText();

                // Assings the values to each label
                lblOPUniqueWordCount.Text = t.NumberOfUniqueWords.ToString();
                lblOpNumOfSen.Text = t.NumberOfSentences.ToString();
                lblOPTotalWordCount.Text = t.NumberOfWords.ToString();

                // Loop adds each word and word count to each row in 2 colums in the list view

                foreach (KeyValuePair<string, int> wordStat in t.WordDictionary) {

                    // IF the LIST wordsToIgnore DOES NOT Contain the word stored in Word Dictonary it will
                    if (!wordsToIgnore.Contains(wordStat.Key.ToLower())) {

                        // Create a row in the ListView
                        ListViewItem item = new ListViewItem(wordStat.Key);

                        // add to the item a value for the second colum
                        item.SubItems.Add(wordStat.Value.ToString());

                        // THEN Add the row to the ListView
                        lvOutputDictonary.Items.Add(item);

                        // THEN TO ANOTHER LIST add the string representation that will then be outputted to a file later
                        listOfWords.Add($"{wordStat.Key}, {wordStat.Value} \n");
                    }
                }

                // Makes the form grow to allow space to make the list view visable 
                Size = new Size(600, 540);
                lvOutputDictonary.Visible = true;
                lblNumOfUnqWords.Visible = true;
                lblOPUniqueWordCount.Visible = true;
                sslOutptErrors.Text = "Done ...";


            } catch (Exception ex) {
                
                MessageBox.Show(ex.Message);
                sslOutptErrors.Text = "An error occured. Please re enter your text";
                return; // Breaks/ doesnt allow the program to continue to the create a file if it fails
            }

            //Creates/Overwrites a file
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //Ensures the file is filter to be a .cvs file or if not at lease a text file
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 1;

            try {

                // Show the dialog and check if the user clicked OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    string finalDatfile = "";

                    // This Loop is nessecary to turn the list into a string to then write to the file
                    foreach (string word in listOfWords) {
                        finalDatfile += word.ToString();
                    }

                    // find the users file path they choose
                    string filePath = saveFileDialog.FileName;
                    FileIO.write(filePath, finalDatfile); // write string to file

                }

            } catch (UnauthorizedAccessException uae) {
                MessageBox.Show(uae.Message);
                sslOutptErrors.Text = $"{uae}";

            } catch (IOException ioe) {
                MessageBox.Show(ioe.Message);
                sslOutptErrors.Text = $"{ioe}"; 
                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                sslOutptErrors.Text = "An error occured. Please re enter your text";
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            // Closes/Exits program
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            // All words in word Dictonary is lower case so this fixes that
            string search = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(search)) {
                return; // doesnt seach anything
            }


            lvOutputDictonary.BeginUpdate();

            //loops thru every iteam in List view 
            foreach (ListViewItem item in lvOutputDictonary.Items) {
                sslOutptErrors.Text = " ";
                // to try to find if it starts with users seach text entered 
                if (item.Text.ToLower().StartsWith(search)) {
                    // If is the word searched for (or close to) Selectes it and sets the focus on it
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible(); // Ensure if the List view is scrollable that the word selected is visable
                    lvOutputDictonary.EndUpdate(); // exits the method if the searched item is found
                    return;
                }
            }
            sslOutptErrors.Text = "Word not found"; // if it doesnt find the word show word not found
            lvOutputDictonary.EndUpdate(); // exits method if the searched item is not found

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            TxtboxUserInput.Paste(); // Paste whatever is on the clipboard

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            TxtboxUserInput.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            TxtboxUserInput.Cut();
        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e) {
            // Create an instance of the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // To prevent more errors THIS FILTERS the files a user can open to only text files
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Get the selected file path
                    string filePath = openFileDialog.FileName;

                    // Example: Read the content of the selected file
                    using (StreamReader sr = new StreamReader(filePath)) {

                        TxtboxUserInput.Text = sr.ReadToEnd();
                    }
                } catch (UnauthorizedAccessException uae) {
                    MessageBox.Show(uae.Message);
                    sslOutptErrors.Text = $"{uae}";
                } catch (IOException ioe) {
                    MessageBox.Show(ioe.Message);
                    sslOutptErrors.Text = $"{ioe}";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    sslOutptErrors.Text = "An error occured. Please re enter your text";
                }// end try catch (Exception ex) {


            }
        }
    }
}   



        




