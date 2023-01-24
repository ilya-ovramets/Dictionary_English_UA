using FirstApp.DataBase;
using System.ComponentModel;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FirstApp.ControllPanel
{
    public partial class DictionaryControll : UserControl
    {

        public DictionaryControll()
        {
            InitializeComponent();
            if(Configure.UserName != null && Configure.Password != null && Configure.Dictionary_id != null)
            {
                UserNameTB.Text = Configure.UserName;
                PasswordTB.Text = Configure.Password;
                CalculateWordsLevel();
                LoadWordsLevelKnow();
                FillDGV();
            }
        }

        // Fill Data Grid View
        private void FillDGV()
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    var WordsDict = from word in db.Wordsdictionaries
                                    where word.DictionaryId == Configure.Dictionary_id 
                                    select word;

                    var Words = from k_word in WordsDict
                                join word in db.Words on k_word.WordId equals word.WordId
                                select new ModelData { Word = word.Word1, translate = word.Translate, transcript = word.Transcript, Progres = k_word.Progres };

                    DictionDGV.AutoSize = true;

                    var bindingList = new BindingList<ModelData>(Words.ToList());
                    DictionDGV.DataSource = bindingList;
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Create new person
        private void roundButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    var selected = db.Users.Select(us => us.UserName == UserNameTB.Text) as User;
                    if (selected == null)
                    {
                        User user = new User() { UserName = UserNameTB.Text, UserPassword = PasswordTB.Text };
                        Dictionary dictionary = new Dictionary() { MiddleWords = 0, WeakWords = 0, StrongWords = 0 };
                        db.Dictionaries.Add(dictionary);
                        user.Dictionary = dictionary;
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("This user name busy");
                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Виникла помилка  {ex.Message}");
            }
        }


        //Load Peason
        private void roundButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    foreach (var item in db.Users)
                    {
                        if (item.UserName == UserNameTB.Text && item.UserPassword == PasswordTB.Text)
                        {
                            Configure.UserName = item.UserName;
                            Configure.Password = item.UserPassword;
                            Configure.Dictionary_id = item.DictionaryId;
                            MessageBox.Show($"{Configure.UserName}  {Configure.Password}  {Configure.Dictionary_id}");
                            break;
                        }

                        MessageBox.Show("Wrong user name or password!");
                        return;
                    }
                }
                CalculateWordsLevel();
                LoadWordsLevelKnow();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Виникла помилка {ex.Message}");
            }
        }


        private void LoadWordsLevelKnow()
        {
            try
            {
                using(DictionaryContext db = new DictionaryContext())
                {
                    Dictionary dictionary = db.Dictionaries.Find(Configure.Dictionary_id);
                    int amount = dictionary.MiddleWords + dictionary.StrongWords + dictionary.WeakWords;

                    StrongWords.Maximum = amount;
                    MiddleWords.Maximum = amount;
                    WeakWords.Maximum = amount;


                    StrongWords.Value = dictionary.StrongWords;
                    WeakWords.Value = dictionary.WeakWords;
                    MiddleWords.Value = dictionary.MiddleWords;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CalculateWordsLevel()
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    var WordsDict = from word in db.Wordsdictionaries
                                    where word.DictionaryId == Configure.Dictionary_id
                                    select word;

                    Dictionary dictionary = db.Dictionaries.Find(Configure.Dictionary_id);

                    foreach (var item in WordsDict)
                    {
                        if(item.Progres <= 30)
                        {
                            dictionary.WeakWords += 1;
                        }else if (item.Progres <= 80)
                        {
                            dictionary.MiddleWords += 1;
                        }
                        else
                        {
                            dictionary.StrongWords += 1;
                        }
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    public class ModelData
    {
        public string Word { get; set; }
        public string translate { get; set; }
        public string transcript { get; set; }
        public int? Progres { get; set; }
    }
}
