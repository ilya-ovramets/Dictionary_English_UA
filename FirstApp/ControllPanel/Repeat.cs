﻿using System.Data;

namespace FirstApp.ControllPanel
{
    public partial class Repeat : UserControl
    {
        public Repeat()
        {

            InitializeComponent();

            roundButton1.Enabled = false;
            LoadNewWord();

        }

        Wordsdictionary wordsdictionary;
        Word curent_word;


        private void ExeptionControll_Load(object sender, EventArgs e)
        {

        }

        private void I_Forget_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {

                    var curent = db.Wordsdictionaries.Find(wordsdictionary.WordDictionaryId);
                    if (curent.Progres - 3 <= 0)
                    {
                        curent.Progres = 0;
                    }
                    else
                    {
                        curent.Progres -= 3;
                    }
                    db.SaveChanges();
                    MessageBox.Show($"{curent_word.Word1} \r\n {curent_word.Translate} \r\n {curent_word.Transcript}");

                }
            }
            catch (Exception)
            {

                throw;
            }
            I_Forget_btn.Enabled = false;
            Submit_BTN.Enabled = false;
            roundButton1.Enabled = true;
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {

            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    if (AnswerBox.Text.Trim().ToLower() == curent_word.Word1.Trim().ToLower())
                    {
                        var curent = db.Wordsdictionaries.Find(wordsdictionary.WordDictionaryId);
                        if (curent.Progres + 10 >= 100)
                        {
                            curent.Progres = 100;
                        }
                        else
                        {
                            curent.Progres += 10;
                        }
                        MessageBox.Show("Good job");
                        db.SaveChanges();
                    }
                    else
                    {
                        var curent = db.Wordsdictionaries.Find(wordsdictionary.WordDictionaryId);
                        if (curent.Progres - 5 <= 0)
                        {
                            curent.Progres = 0;
                        }
                        else
                        {
                            curent.Progres -= 5;
                        }
                        db.SaveChanges();
                        MessageBox.Show($"Wrong answer {curent_word.Word1} \r\n {curent_word.Translate} \r\n {curent_word.Transcript}");
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            I_Forget_btn.Enabled = false;
            Submit_BTN.Enabled = false;
            roundButton1.Enabled = true;
        }

        private void SearchWord()
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    var WordsDict = from word in db.Wordsdictionaries
                                    where word.DictionaryId == Configure.Dictionary_id && word.Progres != 100
                                    select word.WordDictionaryId;

                    Random random = new Random();

                    int rand = random.Next(WordsDict.Count());

                    wordsdictionary = db.Wordsdictionaries.Find(WordsDict.ToList()[rand]);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void LoadNewWord()
        {
            SearchWord();
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    curent_word = db.Words.Find(wordsdictionary.WordId);

                    Word_Repeat.Text = $"{curent_word.Translate}";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error LoadNewWord");
            }
        }



        

        private void roundButton1_Click(object sender, EventArgs e)
        {
            LoadNewWord();

            I_Forget_btn.Enabled = true;
            Submit_BTN.Enabled = true;
            roundButton1.Enabled = false;
        }
    }
}
