using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace FirstApp.DataBase;

public partial class DictionaryContext : DbContext
{
    public DictionaryContext()
    {
    }

    public DictionaryContext(DbContextOptions<DictionaryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dictionary> Dictionaries { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    public virtual DbSet<Wordsdictionary> Wordsdictionaries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=Dictionary", ServerVersion.Parse("10.3.22-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Dictionary>(entity =>
        {
            entity.HasKey(e => e.DictionaryId).HasName("PRIMARY");

            entity.ToTable("dictionaries");

            entity.Property(e => e.DictionaryId)
                .HasColumnType("int(11)")
                .HasColumnName("dictionary_id");
            entity.Property(e => e.MiddleWords)
                .HasColumnType("int(11)")
                .HasColumnName("middle_words");
            entity.Property(e => e.StrongWords)
                .HasColumnType("int(11)")
                .HasColumnName("strong_words");
            entity.Property(e => e.WeakWords)
                .HasColumnType("int(11)")
                .HasColumnName("weak_words");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.DictionaryId, "dictionary_id");

            entity.HasIndex(e => e.UserName, "user_name").IsUnique();

            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.DictionaryId)
                .HasColumnType("int(11)")
                .HasColumnName("dictionary_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(30)
                .HasColumnName("user_password");

            entity.HasOne(d => d.Dictionary).WithMany(p => p.Users)
                .HasForeignKey(d => d.DictionaryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("users_ibfk_1");
        });

        modelBuilder.Entity<Word>(entity =>
        {
            entity.HasKey(e => e.WordId).HasName("PRIMARY");

            entity.ToTable("words");

            entity.HasIndex(e => e.Word1, "word").IsUnique();

            entity.Property(e => e.WordId)
                .HasColumnType("int(11)")
                .HasColumnName("word_id");
            entity.Property(e => e.Translate)
                .HasMaxLength(100)
                .HasColumnName("translate");
            entity.Property(e => e.Word1)
                .HasMaxLength(50)
                .HasColumnName("word");
        });

        modelBuilder.Entity<Wordsdictionary>(entity =>
        {
            entity.HasKey(e => e.WordDictionaryId).HasName("PRIMARY");

            entity.ToTable("wordsdictionaries");

            entity.HasIndex(e => e.DictionaryId, "dictionary_id");

            entity.HasIndex(e => e.WordId, "word_id");

            entity.Property(e => e.WordDictionaryId)
                .HasColumnType("int(11)")
                .HasColumnName("wordDictionary_id");
            entity.Property(e => e.DictionaryId)
                .HasColumnType("int(11)")
                .HasColumnName("dictionary_id");
            entity.Property(e => e.Progres)
                .HasColumnType("int(100)")
                .HasColumnName("progres");
            entity.Property(e => e.WordId)
                .HasColumnType("int(11)")
                .HasColumnName("word_id");

            entity.HasOne(d => d.Dictionary).WithMany(p => p.Wordsdictionaries)
                .HasForeignKey(d => d.DictionaryId)
                .HasConstraintName("wordsdictionaries_ibfk_1");

            entity.HasOne(d => d.Word).WithMany(p => p.Wordsdictionaries)
                .HasForeignKey(d => d.WordId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("wordsdictionaries_ibfk_2");
        });
        OnModelCreatingPartial(modelBuilder);
        AddData(modelBuilder);
    }

    // For Add New Word to dictionary


    private List<Word> ReadNewWord(string words_list)
    {
        var list_word = words_list.Split("\r\n");
        List<List<string>> words = new List<List<string>>();
        foreach (string item in list_word)
        {
            if (item == "")
            {
                continue;
            }
            var items = item.Split("–");
            List<string> strings = new List<string>();
            strings.Add(items[1]);
            var items_2 = items[0].Split("[");
            strings.Add(items_2[0]);
            strings.Add("[" + items_2[1]);
            words.Add(strings);
        }
        return SaveWord(words);
    }


    private List<Word> SaveWord(List<List<string>> words)
    {
        try
        {
            List<Word> Words_list = new List<Word>();
            int index = 1;
            foreach (var item in words)
            {
                Word word = new Word();
                word.WordId = index;
                word.Word1 = item[1];
                word.Translate = item[0];
                word.Transcript = item[2];
                Words_list.Add(word);
                index++;
            }
            return Words_list;
        }
        catch (Exception ex)
        {
            throw;
        }
    }


    private void AddData(ModelBuilder modelBuilder)
    {
        string words_list = "hi [хай] – привіт\r\nhello [хелОу] – здрастуйте, привіт\r\nsorry [сOрі] – вибач (те)\r\nplease [пли: з] – будь ласка (прошу); догоджати\r\nthank you [Сенк ю] – спасибі\r\nyou are welcome [ю: а уЕлкем] – будь ласка, немає за що\r\nwhat a pity [Уот е пити] – як шкода\r\n(Good) bye [(гуд) Бaй] – до побачення\r\n\r\npeople [пі: пл] – люди\r\n\r\nman [мен] – чоловік (у множині men [мен])\r\nwoman [вУмен] – жінка (мн.ч. women [уІмін])\r\nchild [чайлд] – дитина (мн.ч. children [чІлдрен])\r\nboy [бой] – хлопчик\r\ngirl [ге: рл] – дівчинка\r\nguy [гай] – хлопець\r\nfriend [френд] – друг\r\nacquaintance [] – знайомий; знайомство\r\nneighbor [нЕйбер] – сусід\r\nguest [Гест] – гість\r\nchief [чі: ф] – начальник; шеф; головний; вождь\r\nboss [бос] – бос\r\ncompetitor [кемпЕтітер] – конкурент, суперник\r\nclient [клАйент] – клієнт\r\ncolleague [Колі: г] – колега\r\n\r\nfamily [Фемілі] – сім’я\r\n\r\nparents [пЕерентс] – батьки\r\nfather [фа: зер] – батько\r\ndad (dy) [Дед (і)] – тато\r\nmother [мАзер] – мати\r\nmum (my) [мам (і)] – мама\r\nhusband [хАзбенд] – чоловік\r\nwife [уАйф] – дружина\r\nson [сан] – син\r\ndaughter [дО: тер] – дочка\r\nbrother [брАзер] – брат\r\nsister [сІстер] – сестра\r\ngrandfather [грЕнфА: зер] – дід …\r\nfather-in-law [фа: зер ін Ло:] – тесть, свекор …\r\nuncle [Анкл] – дядько\r\naunt [а: нт] – тітка\r\ncousin [скарбниць] – двоюрідний брат, двоюрідна сестра\r\nnephew [нЕф’ю:] – племінник\r\nniece [ні: з] – племінниця\r\n\r\njob [Джоб] – робота\r\n\r\nbusinessman [бІзнесмен] – бізнесмен (мн.ч. businessmen [бІзнесмен])\r\nteacher [ти: чер] – учитель\r\ndriver [дрАйвер] – водій\r\nworker [УО: ркер] – робочий\r\nengineer [Енджиніа: ер] – інженер\r\ndoctor [дОктер] – лікар\r\nlawyer [ло: ер] – адвокат, юрист\r\njournalist [джЁ: рнеліст] – журналіст\r\nnurse [нё: рс] – медсестра\r\nshop assistаnt [шоп есІстент] – продавець\r\nwaiter [уЕйтер] – офіціант\r\naccountant [екАунтент] – бухгалтер\r\nartist [А: ртіст] – художник\r\nmusician [м’ю: зІшн] – музикант\r\nactor [Ектер] – актор\r\nstudent [ст’Юдент] – студент\r\npupil [п’юпл] – школяр, учень\r\n\r\nanimal [Енімел] – тварина\r\n\r\ncat [кет] – кішка\r\ndog [дог] – собака\r\nbird [Бе: рд] – птах\r\nsquirrel [скуІрел] – білка\r\nwolf [уулф] – вовк\r\ngoose [гу: с] – гусак (мн.ч. geese [ги: с])\r\ngiraffe [Джира: ф] – жираф\r\nrabbit [рЕбіт] – кролик; заєць\r\ncow [КАУ] – корова\r\nrat [Рет] – щур\r\nfox [фокс] – лисиця\r\nhorse [хо: рс] – кінь\r\nfrog [фрог] – жаба\r\nbear [бЕер] – ведмідь\r\nmouse [Маус] – миша (мн.ч. mice [Майс])\r\nmonkey [манки] – мавпа\r\npig [піг] – свиня\r\nelephant [Елефент] – слон\r\nduck [дак] – качка\r\n\r\ncountry [кантрі] – країна; сільська місцевість\r\n\r\nGreat Britain [Грейт Брітен] – Великобританія\r\nEngland [Інгленд] – Англія\r\n\r\ncity ​​[Сіті] – місто\r\n\r\nhouse [Хаус] – будинок (будівлю)\r\nhome [Хоум] – будинок (місце проживання)\r\nbuilding [Білдінг] – будівля; будівництво\r\nplace [Плейс] – місце; поміщати\r\nentrance [Ентренс] – вхід\r\nexit [Екзіт] – вихід\r\ncenter [сЕнтер] – центр\r\nyard [я: рд] – двір\r\nroof [ру: ф] – дах\r\nfence [Фенсі] – паркан\r\nland [ленд] – земля, ділянка\r\nvillage [Вілідж] – село, селище\r\nschool [ску: л] – школа\r\nuniversity [юніве: рсіті] – університет\r\ntheater [Сі: етер] – театр\r\nchurch [че: рч] – церква\r\nrestaurant [рЕстронт] – ресторан\r\ncafe [кЕфей] – кафе\r\nhotel [хоутЕл] – готель\r\nbank [бенк] – банк\r\ncinema [сІнеме] – кінотеатр\r\nhospital [хОспітл] – лікарня\r\npolice [поліс] – поліція\r\npost office [Поуст Офіс] – пошта\r\nstation [Стейшн] – станція, вокзал\r\nairport [Еепо: рт] – аеропорт\r\nshop [шоп] – магазин\r\npharmacy [фа: рмасі] – аптека\r\nmarket [мА: ркет] – ринок\r\noffice [Офіс] – офіс\r\ncompany [кОмпені] – компанія, фірма\r\nfactory [фЕктері] – підприємство, завод, фабрика\r\nsquare [скуЕер] – площа\r\nstreet [стрі: т] – вулиця\r\nroad [Роуд] – дорога\r\ncrossroads [крОсроудз] – перехрестя\r\nstop [стоп] – зупинка; зупинятися\r\nsidewalk [] – тротуар\r\npath [па: с] – стежка, стежка\r\ngarden [га: РДН] – сад\r\npark [па: рк] – парк\r\nbridge [бридж] – міст\r\nriver [рІвер] – річка\r\nforest [Форест] – ліс\r\nfield [фі: лд] – поле\r\nmountain [Маунтін] – гора\r\nlake [Лейк] – озеро\r\nsea ​​[сі:] – море\r\nocean [Оушн] – океан\r\ncoast [Коуст] – морський берег, узбережжя\r\nbeach [бі: ч] – пляж\r\nsand [Сенд] – пісок\r\nisland [Айленд] – острів\r\nborder [бО: рдер] – межа\r\ncustoms [кАстемз] – митниця\r\ngarbage [га: рбідж] – сміття\r\nwaste [уейст] – відходи; марнувати\r\nstone [Стоун] – камінь\r\n\r\nplant [пла: нт] – рослина; завод; садити\r\n\r\ntree [трі:] – дерево\r\ngrass [гра: з] – трава\r\nflower [Флауер] – квітка\r\nleaf [лі: ф] – лист (дерева)\r\n\r\nflat [флет] – квартира\r\n\r\nroom [рум] – кімната\r\nliving room [Лівінг рум] – зал\r\nbedroom [бЕдрум] – спальня\r\nbathroom [ба: срум] – ванна\r\nshower [ШАУЕР] – душ\r\ntoilet [] – туалет\r\nkitchen [Кітчен] – кухня\r\nhall [хо: л] – коридор\r\nbalcony [бЕлконі] – балкон\r\nfloor [фло: р] – підлога; поверх\r\nceiling [Сі: лінг] – стеля\r\nwall [УО: л] – стіна\r\nstairs [стЕерз] – сходинки; сходи\r\ndoor [до: р] – двері\r\nwindow [Уіндоу] – вікно\r\nwindowsill [уІндоусіл] – підвіконня\r\ncurtain [кертен] – завіса (ка), штора\r\nswitch [cуІч] – вимикач; перемикати\r\nsocket [сОкіт] – розетка\r\nfaucet [Фо: сит] – (водопровідний) кран\r\npipe [пайп] – труба; трубка\r\nchimney [Чімні] – димова труба\r\n\r\nfurniture [фе: ніче] – меблі\r\n\r\ntable [тейбл] – стіл\r\nchair [чЕер] – стілець\r\narmchair [А: рмчеер] – крісло\r\nsofa [сОуфа] – диван\r\nbed [бед] – ліжко\r\nwardrobe [УО: дроуб] – (платтяна) шафа\r\ncabinet [кЕбінет] – шафа (чик)\r\nshelf [шелф] – полку\r\nmirror [Мірор] – дзеркало\r\ncarpet [кА: рпіт] – килим\r\nfridge [ФРІДЖ] – холодильник\r\nmicrowave [мАйкроууейв] – мікрохвильовка\r\noven [Авен] – піч, духовка\r\nstove [Стоува] – кухонна плита\r\n\r\nfood [фу: д] – їжа\r\n\r\nbread [бред] – хліб\r\nbutter [бАтер] – масло\r\noil [ойл] – рослинне масло; нафту\r\ncheese [чи: з] – сир\r\nsausage [сОсідж] – ковбаса, сосиска\r\nham [Хем] – шинка\r\nmeat [ми: т] – м’ясо\r\nbeef [бі: ф] – яловичина\r\npork [по: рк] – свинина\r\nlamb [Лем] – баранина; ягня\r\nchicken [Чикин] – курча; курка\r\ncutlet [Катла] – котлета\r\nfish [фіш] – риба; рибалити\r\negg [ЕГ] – яйце\r\nsalad [сЕлед] – салат\r\nmushroom [Машрум] – гриб\r\ncorn [ко: рн] – кукурудза; зерно\r\nporridge [порідж] – каша\r\noatmeal [Оутмі: л] – вівсянка\r\nsoup [су: п] – суп\r\nsandwich [сЕндуіч] – бутерброд\r\nrice [Райс] – рис\r\nnoodles [ну: длз] – локшина\r\nflour [Флауер] – мука\r\nspice [спайс] – спеція, прянощі\r\npepper [пЕпер] – перець; поперчити\r\nsalt [со: лт] – сіль; посолити\r\nonion [Аніен] – цибуля (ріпчаста)\r\ngarlic [га: рлік] – часник\r\nsauce [сі: с] – соус\r\nvegetables [вЕджітеблз] – овочі\r\npotatoes [потЕйтоуз] – картопля\r\ncarrot [кЕрет] – морква\r\nbeet [бі: т] – буряк\r\ntomato [томA: тоу] – помідор\r\ncucumber [к’Юкамбер] – огірок\r\ncabbage [кЕбідж] – капуста\r\nsquash [скуОш] – кабачок\r\neggplant [Егпла: нт] – баклажан\r\nbeans [бі: нз] – боби\r\npea [пі:] – горох\r\nnut [нат] – горіх\r\nfruit [фру: т] – фрукт (и); плід\r\napple [Епл] – яблуко\r\npear [пЕер] – груша\r\nbanana [бенЕне] – банан\r\nberry [Бері] – ягода\r\nstrawberry [] – полуниця, суниця\r\nraspberry [РА: збері] – малина\r\ncherry [чЕрі] – вишня\r\nplum [] – слива\r\ngrape [Грейп] – виноград\r\napricot [Ейпрікот] – абрикос\r\npeach [пі: ч] – персик\r\nmelon [Мелоні] – диня\r\nwatermelon [уOтермелен] – кавун\r\npumpkin [Пампкін] – гарбуз\r\norange [Oріндж] – апельсин; помаранчевий\r\nmandarin [мЕндерін] – мандарин\r\nlemon [Лемона] – лимон\r\npineapple [пАйнепл] – ананас\r\nsugar [шУге] – цукор\r\nhoney [Хані] – мед\r\njam [джем] – варення\r\ncake [Кейк] – торт\r\nbun [бан] – булочка\r\ncookie [куки] – печиво\r\npie [пай] – пиріг, пиріжок\r\nsweet [суі: т] – цукерка; солодкий\r\nice-cream [Aйскрі: м] – морозиво\r\nchocolate [чOкліт] – шоколад\r\nwater [уотер] – вода; поливати\r\nsoda [сOуда] – газована вода\r\njuice [джу: с] – сік\r\nwine [Уайн] – вино\r\ntea [ті:] – чай\r\ncoffee [кOфі] – кава\r\nmilk [мілк] – молоко\r\ncream [крі: м] – вершки; крем\r\nyogurt [йОгет] – йогурт\r\ncurd [Ке: рд] – сир\r\n\r\ndish [Діш] – блюдо (dishes [дІшіз] – посуд)\r\n\r\ncup [кап] – чашка\r\nglass [гла: с] – стакан; Скло\r\nmug [маг] – гуртка\r\nplate [плейт] – тарілка\r\nspoon [спу: н] – ложка\r\nfork [фо: рк] – вилка\r\nknife [Найф] – ніж\r\nsaucer [Сo: сер] – блюдце\r\nbottle [Ботліх] – пляшка\r\nnapkin [нЕпкін] – серветка\r\npan [пен] – каструля\r\nfrying pan [фрАйінг пен] – сковорідка\r\nkettle [Кетлі] – чайник; котел\r\n\r\nmeal [ми: л] – прийняття їжі, їжа\r\n\r\nbreakfast [брЕкфест] – сніданок\r\nlunch [ланч] – обід\r\ndinner [дІнер] – вечеря\r\n\r\ntransport [трЕнспо: рт] – транспорт; [ТренспО: рт] – перевозити, транспортувати\r\n\r\nplane [плейн] – літак\r\ncar [ка: р] – автомобіль\r\ntram [трем] – трамвай\r\nbus [бас] – автобус\r\ntrain [Трейн] – потяг\r\nship [шип] – корабель\r\nbicycle [бAйсікл] – велосипед\r\n\r\ntime [тайм] – час; раз\r\n\r\nminute [Мініт] – хвилина\r\nhour [Aуер] – годину\r\nweek [ві: к] – тиждень\r\nyear [йер] – рік\r\ncentury [сЕнчері] – вік, століття\r\n\r\nthe day before yesterday [зе дей біфо: р йЕстедей] – позавчора\r\nyesterday [йЕстедей] – вчора\r\ntoday [] – сьогодні (вдень)\r\ntonight [тунАйт] – сьогодні ввечері (вночі)\r\ntomorrow [томОроу] – завтра\r\nthe day after tomorrow [зе Дей А: фтер томОроу] – післязавтра\r\n\r\nday [Дей] – день\r\n\r\nmorning [мо: рнінг] – ранок\r\nafternoon [а: фтернУ: н] – день (після полудня)\r\nevening [І: внінг] – вечір\r\nnight [найт] – ніч\r\n\r\nMonday [мAндей] – Понеділок\r\nTuesday [т’Ю: здей] – вівторок\r\nWednesday [уЕнздей] – середовище\r\nThursday [се: рздей] – четверг\r\nFriday [фрAйдей] – п’ятниця\r\nSaturday [сЕтердей] – субота\r\nSunday [сAндей] – неділя\r\n\r\nmonth [манс] – місяць\r\n\r\nJanuary [джЕн’юері] – січень\r\nFebruary [фЕбруері] – лютий\r\nMarch [ма: рч] – березень\r\nApril [Ейпріл] – квітень\r\nMay [мей] – травень\r\nJune [джу: н] – червень\r\nJuly [джулAй] – липень\r\nAugust [O: Гест] – серпень\r\nSeptember [септЕмбер] – вересень\r\nOctober [октOубер] – жовтень\r\nNovember [ноувЕмбер] – листопад\r\nDecember [десЕмбер] – грудень\r\n\r\nseason [Сі: Зен] – час року; сезон\r\n\r\nspring [спринг] – весна\r\nsummer [сAмер] – літо\r\nautumn [O: ТЕМ] – осінь\r\nwinter [уІнтер] – зима\r\n\r\nholiday [хOлідей] – свято; відпустку; канікули\r\n\r\nChristmas [крІсмес] – Різдво\r\nEaster [І: Стер] – Великдень\r\nbirthday [Бе: рсдей] – день народження\r\n\r\nform [фо: рм] – анкета; форма; бланк; клас; формувати, утворювати\r\n\r\nname [нейм] – ім’я, прізвище; назва; називати\r\nfirst name [фе: рст нейм] – ім’я\r\nsurname [се: нейм] – прізвище\r\nmaiden name [мЕйден нейм] – дівоче прізвище\r\nbirth date [Бе: рс Дейта] – дата народження\r\nplace of birth [Плейс ів Бе: рс] – місце народження\r\naddress [едрЕс] – адреса\r\nmarital status [мЕрітел стЕйтес] – сімейний стан\r\nsingle [сінгл] – холостий, незаміжня; один (окій); в один кінець (про квитку)\r\nmarried [мЕрід] – одружений / заміжня\r\ndivorced [диво: рст] – розведений\r\nwidowed [уідоуд] – овдовілий";

        var value = ReadNewWord(words_list);
        modelBuilder.Entity<Word>().HasData(value.AsEnumerable());

    }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
