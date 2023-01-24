using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class NewWord : UserControl
    {
        public NewWord()
        {
            InitializeComponent();
            LoadWord();
        }

        Word curent_word = null;

        //Bead
        private void roundButton1_Click(object sender, EventArgs e)
        {
            SetProgres(20);
            LoadWord();
        }

        //Middle
        private void roundButton2_Click(object sender, EventArgs e)
        {
            SetProgres(60);
            LoadWord();
        }

        //Good
        private void roundButton3_Click(object sender, EventArgs e)
        {
            SetProgres(90);
            LoadWord();
        }

        private void SetProgres(int amount)
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    Wordsdictionary wordsdictionary = new Wordsdictionary()
                    {
                        DictionaryId = Configure.Dictionary_id,
                        WordId = curent_word.WordId,
                        Progres = amount
                    };

                    db.Wordsdictionaries.Add(wordsdictionary);
                    db.SaveChanges();


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadWord()
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    var words = db.Words.ToList();


                    var dictionary = from dict in db.Wordsdictionaries
                                     where dict.DictionaryId == Configure.Dictionary_id
                                     select dict.WordId;

                    foreach (var word in words)
                    {
                        bool flag = true;
                        foreach (int dict in dictionary)
                        {
                            if(word.WordId == dict)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            curent_word = word;
                            Word.Text = curent_word.Word1;
                            Translate.Text = curent_word.Translate;
                            Transcript.Text = curent_word.Transcript;
                            return;
                        }


                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
