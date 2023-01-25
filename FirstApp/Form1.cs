namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            DictionaryControll userControl = new DictionaryControll();
            addUserControl(userControl);
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Size = new Size(panel1.Width,panel1.Height);
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void employe_btn_Click(object sender, EventArgs e)
        {
            DictionaryControll userControl = new DictionaryControll();
            addUserControl(userControl);

        }

        private void btn_RegularCustomer_Click(object sender, EventArgs e)
        {
            if (!CheckLogin())
            {
                return;
            }
            NewWord userControl = new NewWord();
            addUserControl(userControl);
        }

        private void ExeptionButton_Click(object sender, EventArgs e)
        {
            if (!CheckLogin())
            {
                return;
            }
            if (!CheckWordAwailable())
            {
                MessageBox.Show("Pleace add new words");
                return;
            }

            Repeat furnitureControll = new Repeat();
            addUserControl(furnitureControll);
        }

        



        private bool CheckWordAwailable()
        {
            try
            {
                using (DictionaryContext db = new DictionaryContext())
                {
                    var WordsDict = from word in db.Wordsdictionaries
                                    where word.DictionaryId == Configure.Dictionary_id
                                    select word;

                    if(WordsDict.Count() == 0)
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        private bool CheckLogin()
        {
            if (Configure.UserName == null && Configure.Password == null && Configure.Dictionary_id == null)
            {
                MessageBox.Show("Pleace login");
                return false;
            }
            return true;
        }
    }
}