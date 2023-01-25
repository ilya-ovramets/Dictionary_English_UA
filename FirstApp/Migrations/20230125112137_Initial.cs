using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dictionaries",
                columns: table => new
                {
                    dictionaryid = table.Column<int>(name: "dictionary_id", type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    weakwords = table.Column<int>(name: "weak_words", type: "int(11)", nullable: false),
                    middlewords = table.Column<int>(name: "middle_words", type: "int(11)", nullable: false),
                    strongwords = table.Column<int>(name: "strong_words", type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.dictionaryid);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "words",
                columns: table => new
                {
                    wordid = table.Column<int>(name: "word_id", type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    word = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    translate = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Transcript = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.wordid);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userid = table.Column<int>(name: "user_id", type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(name: "user_name", type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userpassword = table.Column<string>(name: "user_password", type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dictionaryid = table.Column<int>(name: "dictionary_id", type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.userid);
                    table.ForeignKey(
                        name: "users_ibfk_1",
                        column: x => x.dictionaryid,
                        principalTable: "dictionaries",
                        principalColumn: "dictionary_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "wordsdictionaries",
                columns: table => new
                {
                    wordDictionaryid = table.Column<int>(name: "wordDictionary_id", type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dictionaryid = table.Column<int>(name: "dictionary_id", type: "int(11)", nullable: true),
                    wordid = table.Column<int>(name: "word_id", type: "int(11)", nullable: true),
                    progres = table.Column<int>(type: "int(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.wordDictionaryid);
                    table.ForeignKey(
                        name: "wordsdictionaries_ibfk_1",
                        column: x => x.dictionaryid,
                        principalTable: "dictionaries",
                        principalColumn: "dictionary_id");
                    table.ForeignKey(
                        name: "wordsdictionaries_ibfk_2",
                        column: x => x.wordid,
                        principalTable: "words",
                        principalColumn: "word_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.InsertData(
                table: "words",
                columns: new[] { "word_id", "Transcript", "translate", "word" },
                values: new object[,]
                {
                    { 1, "[хай] ", " привіт", "hi " },
                    { 2, "[хелОу] ", " здрастуйте, привіт", "hello " },
                    { 3, "[сOрі] ", " вибач (те)", "sorry " },
                    { 4, "[пли: з] ", " будь ласка (прошу); догоджати", "please " },
                    { 5, "[Сенк ю] ", " спасибі", "thank you " },
                    { 6, "[ю: а уЕлкем] ", " будь ласка, немає за що", "you are welcome " },
                    { 7, "[Уот е пити] ", " як шкода", "what a pity " },
                    { 8, "[(гуд) Бaй] ", " до побачення", "(Good) bye " },
                    { 9, "[пі: пл] ", " люди", "people " },
                    { 10, "[мен] ", " чоловік (у множині men [мен])", "man " },
                    { 11, "[вУмен] ", " жінка (мн.ч. women [уІмін])", "woman " },
                    { 12, "[чайлд] ", " дитина (мн.ч. children [чІлдрен])", "child " },
                    { 13, "[бой] ", " хлопчик", "boy " },
                    { 14, "[ге: рл] ", " дівчинка", "girl " },
                    { 15, "[гай] ", " хлопець", "guy " },
                    { 16, "[френд] ", " друг", "friend " },
                    { 17, "[] ", " знайомий; знайомство", "acquaintance " },
                    { 18, "[нЕйбер] ", " сусід", "neighbor " },
                    { 19, "[Гест] ", " гість", "guest " },
                    { 20, "[чі: ф] ", " начальник; шеф; головний; вождь", "chief " },
                    { 21, "[бос] ", " бос", "boss " },
                    { 22, "[кемпЕтітер] ", " конкурент, суперник", "competitor " },
                    { 23, "[клАйент] ", " клієнт", "client " },
                    { 24, "[Колі: г] ", " колега", "colleague " },
                    { 25, "[Фемілі] ", " сім’я", "family " },
                    { 26, "[пЕерентс] ", " батьки", "parents " },
                    { 27, "[фа: зер] ", " батько", "father " },
                    { 28, "[Дед (і)] ", " тато", "dad (dy) " },
                    { 29, "[мАзер] ", " мати", "mother " },
                    { 30, "[мам (і)] ", " мама", "mum (my) " },
                    { 31, "[хАзбенд] ", " чоловік", "husband " },
                    { 32, "[уАйф] ", " дружина", "wife " },
                    { 33, "[сан] ", " син", "son " },
                    { 34, "[дО: тер] ", " дочка", "daughter " },
                    { 35, "[брАзер] ", " брат", "brother " },
                    { 36, "[сІстер] ", " сестра", "sister " },
                    { 37, "[грЕнфА: зер] ", " дід …", "grandfather " },
                    { 38, "[фа: зер ін Ло:] ", " тесть, свекор …", "father-in-law " },
                    { 39, "[Анкл] ", " дядько", "uncle " },
                    { 40, "[а: нт] ", " тітка", "aunt " },
                    { 41, "[скарбниць] ", " двоюрідний брат, двоюрідна сестра", "cousin " },
                    { 42, "[нЕф’ю:] ", " племінник", "nephew " },
                    { 43, "[ні: з] ", " племінниця", "niece " },
                    { 44, "[Джоб] ", " робота", "job " },
                    { 45, "[бІзнесмен] ", " бізнесмен (мн.ч. businessmen [бІзнесмен])", "businessman " },
                    { 46, "[ти: чер] ", " учитель", "teacher " },
                    { 47, "[дрАйвер] ", " водій", "driver " },
                    { 48, "[УО: ркер] ", " робочий", "worker " },
                    { 49, "[Енджиніа: ер] ", " інженер", "engineer " },
                    { 50, "[дОктер] ", " лікар", "doctor " },
                    { 51, "[ло: ер] ", " адвокат, юрист", "lawyer " },
                    { 52, "[джЁ: рнеліст] ", " журналіст", "journalist " },
                    { 53, "[нё: рс] ", " медсестра", "nurse " },
                    { 54, "[шоп есІстент] ", " продавець", "shop assistаnt " },
                    { 55, "[уЕйтер] ", " офіціант", "waiter " },
                    { 56, "[екАунтент] ", " бухгалтер", "accountant " },
                    { 57, "[А: ртіст] ", " художник", "artist " },
                    { 58, "[м’ю: зІшн] ", " музикант", "musician " },
                    { 59, "[Ектер] ", " актор", "actor " },
                    { 60, "[ст’Юдент] ", " студент", "student " },
                    { 61, "[п’юпл] ", " школяр, учень", "pupil " },
                    { 62, "[Енімел] ", " тварина", "animal " },
                    { 63, "[кет] ", " кішка", "cat " },
                    { 64, "[дог] ", " собака", "dog " },
                    { 65, "[Бе: рд] ", " птах", "bird " },
                    { 66, "[скуІрел] ", " білка", "squirrel " },
                    { 67, "[уулф] ", " вовк", "wolf " },
                    { 68, "[гу: с] ", " гусак (мн.ч. geese [ги: с])", "goose " },
                    { 69, "[Джира: ф] ", " жираф", "giraffe " },
                    { 70, "[рЕбіт] ", " кролик; заєць", "rabbit " },
                    { 71, "[КАУ] ", " корова", "cow " },
                    { 72, "[Рет] ", " щур", "rat " },
                    { 73, "[фокс] ", " лисиця", "fox " },
                    { 74, "[хо: рс] ", " кінь", "horse " },
                    { 75, "[фрог] ", " жаба", "frog " },
                    { 76, "[бЕер] ", " ведмідь", "bear " },
                    { 77, "[Маус] ", " миша (мн.ч. mice [Майс])", "mouse " },
                    { 78, "[манки] ", " мавпа", "monkey " },
                    { 79, "[піг] ", " свиня", "pig " },
                    { 80, "[Елефент] ", " слон", "elephant " },
                    { 81, "[дак] ", " качка", "duck " },
                    { 82, "[кантрі] ", " країна; сільська місцевість", "country " },
                    { 83, "[Грейт Брітен] ", " Великобританія", "Great Britain " },
                    { 84, "[Інгленд] ", " Англія", "England " },
                    { 85, "[Сіті] ", " місто", "city ​​" },
                    { 86, "[Хаус] ", " будинок (будівлю)", "house " },
                    { 87, "[Хоум] ", " будинок (місце проживання)", "home " },
                    { 88, "[Білдінг] ", " будівля; будівництво", "building " },
                    { 89, "[Плейс] ", " місце; поміщати", "place " },
                    { 90, "[Ентренс] ", " вхід", "entrance " },
                    { 91, "[Екзіт] ", " вихід", "exit " },
                    { 92, "[сЕнтер] ", " центр", "center " },
                    { 93, "[я: рд] ", " двір", "yard " },
                    { 94, "[ру: ф] ", " дах", "roof " },
                    { 95, "[Фенсі] ", " паркан", "fence " },
                    { 96, "[ленд] ", " земля, ділянка", "land " },
                    { 97, "[Вілідж] ", " село, селище", "village " },
                    { 98, "[ску: л] ", " школа", "school " },
                    { 99, "[юніве: рсіті] ", " університет", "university " },
                    { 100, "[Сі: етер] ", " театр", "theater " },
                    { 101, "[че: рч] ", " церква", "church " },
                    { 102, "[рЕстронт] ", " ресторан", "restaurant " },
                    { 103, "[кЕфей] ", " кафе", "cafe " },
                    { 104, "[хоутЕл] ", " готель", "hotel " },
                    { 105, "[бенк] ", " банк", "bank " },
                    { 106, "[сІнеме] ", " кінотеатр", "cinema " },
                    { 107, "[хОспітл] ", " лікарня", "hospital " },
                    { 108, "[поліс] ", " поліція", "police " },
                    { 109, "[Поуст Офіс] ", " пошта", "post office " },
                    { 110, "[Стейшн] ", " станція, вокзал", "station " },
                    { 111, "[Еепо: рт] ", " аеропорт", "airport " },
                    { 112, "[шоп] ", " магазин", "shop " },
                    { 113, "[фа: рмасі] ", " аптека", "pharmacy " },
                    { 114, "[мА: ркет] ", " ринок", "market " },
                    { 115, "[Офіс] ", " офіс", "office " },
                    { 116, "[кОмпені] ", " компанія, фірма", "company " },
                    { 117, "[фЕктері] ", " підприємство, завод, фабрика", "factory " },
                    { 118, "[скуЕер] ", " площа", "square " },
                    { 119, "[стрі: т] ", " вулиця", "street " },
                    { 120, "[Роуд] ", " дорога", "road " },
                    { 121, "[крОсроудз] ", " перехрестя", "crossroads " },
                    { 122, "[стоп] ", " зупинка; зупинятися", "stop " },
                    { 123, "[] ", " тротуар", "sidewalk " },
                    { 124, "[па: с] ", " стежка, стежка", "path " },
                    { 125, "[га: РДН] ", " сад", "garden " },
                    { 126, "[па: рк] ", " парк", "park " },
                    { 127, "[бридж] ", " міст", "bridge " },
                    { 128, "[рІвер] ", " річка", "river " },
                    { 129, "[Форест] ", " ліс", "forest " },
                    { 130, "[фі: лд] ", " поле", "field " },
                    { 131, "[Маунтін] ", " гора", "mountain " },
                    { 132, "[Лейк] ", " озеро", "lake " },
                    { 133, "[сі:] ", " море", "sea ​​" },
                    { 134, "[Оушн] ", " океан", "ocean " },
                    { 135, "[Коуст] ", " морський берег, узбережжя", "coast " },
                    { 136, "[бі: ч] ", " пляж", "beach " },
                    { 137, "[Сенд] ", " пісок", "sand " },
                    { 138, "[Айленд] ", " острів", "island " },
                    { 139, "[бО: рдер] ", " межа", "border " },
                    { 140, "[кАстемз] ", " митниця", "customs " },
                    { 141, "[га: рбідж] ", " сміття", "garbage " },
                    { 142, "[уейст] ", " відходи; марнувати", "waste " },
                    { 143, "[Стоун] ", " камінь", "stone " },
                    { 144, "[пла: нт] ", " рослина; завод; садити", "plant " },
                    { 145, "[трі:] ", " дерево", "tree " },
                    { 146, "[гра: з] ", " трава", "grass " },
                    { 147, "[Флауер] ", " квітка", "flower " },
                    { 148, "[лі: ф] ", " лист (дерева)", "leaf " },
                    { 149, "[флет] ", " квартира", "flat " },
                    { 150, "[рум] ", " кімната", "room " },
                    { 151, "[Лівінг рум] ", " зал", "living room " },
                    { 152, "[бЕдрум] ", " спальня", "bedroom " },
                    { 153, "[ба: срум] ", " ванна", "bathroom " },
                    { 154, "[ШАУЕР] ", " душ", "shower " },
                    { 155, "[] ", " туалет", "toilet " },
                    { 156, "[Кітчен] ", " кухня", "kitchen " },
                    { 157, "[хо: л] ", " коридор", "hall " },
                    { 158, "[бЕлконі] ", " балкон", "balcony " },
                    { 159, "[фло: р] ", " підлога; поверх", "floor " },
                    { 160, "[Сі: лінг] ", " стеля", "ceiling " },
                    { 161, "[УО: л] ", " стіна", "wall " },
                    { 162, "[стЕерз] ", " сходинки; сходи", "stairs " },
                    { 163, "[до: р] ", " двері", "door " },
                    { 164, "[Уіндоу] ", " вікно", "window " },
                    { 165, "[уІндоусіл] ", " підвіконня", "windowsill " },
                    { 166, "[кертен] ", " завіса (ка), штора", "curtain " },
                    { 167, "[cуІч] ", " вимикач; перемикати", "switch " },
                    { 168, "[сОкіт] ", " розетка", "socket " },
                    { 169, "[Фо: сит] ", " (водопровідний) кран", "faucet " },
                    { 170, "[пайп] ", " труба; трубка", "pipe " },
                    { 171, "[Чімні] ", " димова труба", "chimney " },
                    { 172, "[фе: ніче] ", " меблі", "furniture " },
                    { 173, "[тейбл] ", " стіл", "table " },
                    { 174, "[чЕер] ", " стілець", "chair " },
                    { 175, "[А: рмчеер] ", " крісло", "armchair " },
                    { 176, "[сОуфа] ", " диван", "sofa " },
                    { 177, "[бед] ", " ліжко", "bed " },
                    { 178, "[УО: дроуб] ", " (платтяна) шафа", "wardrobe " },
                    { 179, "[кЕбінет] ", " шафа (чик)", "cabinet " },
                    { 180, "[шелф] ", " полку", "shelf " },
                    { 181, "[Мірор] ", " дзеркало", "mirror " },
                    { 182, "[кА: рпіт] ", " килим", "carpet " },
                    { 183, "[ФРІДЖ] ", " холодильник", "fridge " },
                    { 184, "[мАйкроууейв] ", " мікрохвильовка", "microwave " },
                    { 185, "[Авен] ", " піч, духовка", "oven " },
                    { 186, "[Стоува] ", " кухонна плита", "stove " },
                    { 187, "[фу: д] ", " їжа", "food " },
                    { 188, "[бред] ", " хліб", "bread " },
                    { 189, "[бАтер] ", " масло", "butter " },
                    { 190, "[ойл] ", " рослинне масло; нафту", "oil " },
                    { 191, "[чи: з] ", " сир", "cheese " },
                    { 192, "[сОсідж] ", " ковбаса, сосиска", "sausage " },
                    { 193, "[Хем] ", " шинка", "ham " },
                    { 194, "[ми: т] ", " м’ясо", "meat " },
                    { 195, "[бі: ф] ", " яловичина", "beef " },
                    { 196, "[по: рк] ", " свинина", "pork " },
                    { 197, "[Лем] ", " баранина; ягня", "lamb " },
                    { 198, "[Чикин] ", " курча; курка", "chicken " },
                    { 199, "[Катла] ", " котлета", "cutlet " },
                    { 200, "[фіш] ", " риба; рибалити", "fish " },
                    { 201, "[ЕГ] ", " яйце", "egg " },
                    { 202, "[сЕлед] ", " салат", "salad " },
                    { 203, "[Машрум] ", " гриб", "mushroom " },
                    { 204, "[ко: рн] ", " кукурудза; зерно", "corn " },
                    { 205, "[порідж] ", " каша", "porridge " },
                    { 206, "[Оутмі: л] ", " вівсянка", "oatmeal " },
                    { 207, "[су: п] ", " суп", "soup " },
                    { 208, "[сЕндуіч] ", " бутерброд", "sandwich " },
                    { 209, "[Райс] ", " рис", "rice " },
                    { 210, "[ну: длз] ", " локшина", "noodles " },
                    { 211, "[Флауер] ", " мука", "flour " },
                    { 212, "[спайс] ", " спеція, прянощі", "spice " },
                    { 213, "[пЕпер] ", " перець; поперчити", "pepper " },
                    { 214, "[со: лт] ", " сіль; посолити", "salt " },
                    { 215, "[Аніен] ", " цибуля (ріпчаста)", "onion " },
                    { 216, "[га: рлік] ", " часник", "garlic " },
                    { 217, "[сі: с] ", " соус", "sauce " },
                    { 218, "[вЕджітеблз] ", " овочі", "vegetables " },
                    { 219, "[потЕйтоуз] ", " картопля", "potatoes " },
                    { 220, "[кЕрет] ", " морква", "carrot " },
                    { 221, "[бі: т] ", " буряк", "beet " },
                    { 222, "[томA: тоу] ", " помідор", "tomato " },
                    { 223, "[к’Юкамбер] ", " огірок", "cucumber " },
                    { 224, "[кЕбідж] ", " капуста", "cabbage " },
                    { 225, "[скуОш] ", " кабачок", "squash " },
                    { 226, "[Егпла: нт] ", " баклажан", "eggplant " },
                    { 227, "[бі: нз] ", " боби", "beans " },
                    { 228, "[пі:] ", " горох", "pea " },
                    { 229, "[нат] ", " горіх", "nut " },
                    { 230, "[фру: т] ", " фрукт (и); плід", "fruit " },
                    { 231, "[Епл] ", " яблуко", "apple " },
                    { 232, "[пЕер] ", " груша", "pear " },
                    { 233, "[бенЕне] ", " банан", "banana " },
                    { 234, "[Бері] ", " ягода", "berry " },
                    { 235, "[] ", " полуниця, суниця", "strawberry " },
                    { 236, "[РА: збері] ", " малина", "raspberry " },
                    { 237, "[чЕрі] ", " вишня", "cherry " },
                    { 238, "[] ", " слива", "plum " },
                    { 239, "[Грейп] ", " виноград", "grape " },
                    { 240, "[Ейпрікот] ", " абрикос", "apricot " },
                    { 241, "[пі: ч] ", " персик", "peach " },
                    { 242, "[Мелоні] ", " диня", "melon " },
                    { 243, "[уOтермелен] ", " кавун", "watermelon " },
                    { 244, "[Пампкін] ", " гарбуз", "pumpkin " },
                    { 245, "[Oріндж] ", " апельсин; помаранчевий", "orange " },
                    { 246, "[мЕндерін] ", " мандарин", "mandarin " },
                    { 247, "[Лемона] ", " лимон", "lemon " },
                    { 248, "[пАйнепл] ", " ананас", "pineapple " },
                    { 249, "[шУге] ", " цукор", "sugar " },
                    { 250, "[Хані] ", " мед", "honey " },
                    { 251, "[джем] ", " варення", "jam " },
                    { 252, "[Кейк] ", " торт", "cake " },
                    { 253, "[бан] ", " булочка", "bun " },
                    { 254, "[куки] ", " печиво", "cookie " },
                    { 255, "[пай] ", " пиріг, пиріжок", "pie " },
                    { 256, "[суі: т] ", " цукерка; солодкий", "sweet " },
                    { 257, "[Aйскрі: м] ", " морозиво", "ice-cream " },
                    { 258, "[чOкліт] ", " шоколад", "chocolate " },
                    { 259, "[уотер] ", " вода; поливати", "water " },
                    { 260, "[сOуда] ", " газована вода", "soda " },
                    { 261, "[джу: с] ", " сік", "juice " },
                    { 262, "[Уайн] ", " вино", "wine " },
                    { 263, "[ті:] ", " чай", "tea " },
                    { 264, "[кOфі] ", " кава", "coffee " },
                    { 265, "[мілк] ", " молоко", "milk " },
                    { 266, "[крі: м] ", " вершки; крем", "cream " },
                    { 267, "[йОгет] ", " йогурт", "yogurt " },
                    { 268, "[Ке: рд] ", " сир", "curd " },
                    { 269, "[Діш] ", " блюдо (dishes [дІшіз] ", "dish " },
                    { 270, "[кап] ", " чашка", "cup " },
                    { 271, "[гла: с] ", " стакан; Скло", "glass " },
                    { 272, "[маг] ", " гуртка", "mug " },
                    { 273, "[плейт] ", " тарілка", "plate " },
                    { 274, "[спу: н] ", " ложка", "spoon " },
                    { 275, "[фо: рк] ", " вилка", "fork " },
                    { 276, "[Найф] ", " ніж", "knife " },
                    { 277, "[Сo: сер] ", " блюдце", "saucer " },
                    { 278, "[Ботліх] ", " пляшка", "bottle " },
                    { 279, "[нЕпкін] ", " серветка", "napkin " },
                    { 280, "[пен] ", " каструля", "pan " },
                    { 281, "[фрАйінг пен] ", " сковорідка", "frying pan " },
                    { 282, "[Кетлі] ", " чайник; котел", "kettle " },
                    { 283, "[ми: л] ", " прийняття їжі, їжа", "meal " },
                    { 284, "[брЕкфест] ", " сніданок", "breakfast " },
                    { 285, "[ланч] ", " обід", "lunch " },
                    { 286, "[дІнер] ", " вечеря", "dinner " },
                    { 287, "[трЕнспо: рт] ", " транспорт; [ТренспО: рт] ", "transport " },
                    { 288, "[плейн] ", " літак", "plane " },
                    { 289, "[ка: р] ", " автомобіль", "car " },
                    { 290, "[трем] ", " трамвай", "tram " },
                    { 291, "[бас] ", " автобус", "bus " },
                    { 292, "[Трейн] ", " потяг", "train " },
                    { 293, "[шип] ", " корабель", "ship " },
                    { 294, "[бAйсікл] ", " велосипед", "bicycle " },
                    { 295, "[тайм] ", " час; раз", "time " },
                    { 296, "[Мініт] ", " хвилина", "minute " },
                    { 297, "[Aуер] ", " годину", "hour " },
                    { 298, "[ві: к] ", " тиждень", "week " },
                    { 299, "[йер] ", " рік", "year " },
                    { 300, "[сЕнчері] ", " вік, століття", "century " },
                    { 301, "[зе дей біфо: р йЕстедей] ", " позавчора", "the day before yesterday " },
                    { 302, "[йЕстедей] ", " вчора", "yesterday " },
                    { 303, "[] ", " сьогодні (вдень)", "today " },
                    { 304, "[тунАйт] ", " сьогодні ввечері (вночі)", "tonight " },
                    { 305, "[томОроу] ", " завтра", "tomorrow " },
                    { 306, "[зе Дей А: фтер томОроу] ", " післязавтра", "the day after tomorrow " },
                    { 307, "[Дей] ", " день", "day " },
                    { 308, "[мо: рнінг] ", " ранок", "morning " },
                    { 309, "[а: фтернУ: н] ", " день (після полудня)", "afternoon " },
                    { 310, "[І: внінг] ", " вечір", "evening " },
                    { 311, "[найт] ", " ніч", "night " },
                    { 312, "[мAндей] ", " Понеділок", "Monday " },
                    { 313, "[т’Ю: здей] ", " вівторок", "Tuesday " },
                    { 314, "[уЕнздей] ", " середовище", "Wednesday " },
                    { 315, "[се: рздей] ", " четверг", "Thursday " },
                    { 316, "[фрAйдей] ", " п’ятниця", "Friday " },
                    { 317, "[сЕтердей] ", " субота", "Saturday " },
                    { 318, "[сAндей] ", " неділя", "Sunday " },
                    { 319, "[манс] ", " місяць", "month " },
                    { 320, "[джЕн’юері] ", " січень", "January " },
                    { 321, "[фЕбруері] ", " лютий", "February " },
                    { 322, "[ма: рч] ", " березень", "March " },
                    { 323, "[Ейпріл] ", " квітень", "April " },
                    { 324, "[мей] ", " травень", "May " },
                    { 325, "[джу: н] ", " червень", "June " },
                    { 326, "[джулAй] ", " липень", "July " },
                    { 327, "[O: Гест] ", " серпень", "August " },
                    { 328, "[септЕмбер] ", " вересень", "September " },
                    { 329, "[октOубер] ", " жовтень", "October " },
                    { 330, "[ноувЕмбер] ", " листопад", "November " },
                    { 331, "[десЕмбер] ", " грудень", "December " },
                    { 332, "[Сі: Зен] ", " час року; сезон", "season " },
                    { 333, "[спринг] ", " весна", "spring " },
                    { 334, "[сAмер] ", " літо", "summer " },
                    { 335, "[O: ТЕМ] ", " осінь", "autumn " },
                    { 336, "[уІнтер] ", " зима", "winter " },
                    { 337, "[хOлідей] ", " свято; відпустку; канікули", "holiday " },
                    { 338, "[крІсмес] ", " Різдво", "Christmas " },
                    { 339, "[І: Стер] ", " Великдень", "Easter " },
                    { 340, "[Бе: рсдей] ", " день народження", "birthday " },
                    { 341, "[фо: рм] ", " анкета; форма; бланк; клас; формувати, утворювати", "form " },
                    { 342, "[нейм] ", " ім’я, прізвище; назва; називати", "name " },
                    { 343, "[фе: рст нейм] ", " ім’я", "first name " },
                    { 344, "[се: нейм] ", " прізвище", "surname " },
                    { 345, "[мЕйден нейм] ", " дівоче прізвище", "maiden name " },
                    { 346, "[Бе: рс Дейта] ", " дата народження", "birth date " },
                    { 347, "[Плейс ів Бе: рс] ", " місце народження", "place of birth " },
                    { 348, "[едрЕс] ", " адреса", "address " },
                    { 349, "[мЕрітел стЕйтес] ", " сімейний стан", "marital status " },
                    { 350, "[сінгл] ", " холостий, незаміжня; один (окій); в один кінець (про квитку)", "single " },
                    { 351, "[мЕрід] ", " одружений / заміжня", "married " },
                    { 352, "[диво: рст] ", " розведений", "divorced " },
                    { 353, "[уідоуд] ", " овдовілий", "widowed " }
                });

            migrationBuilder.CreateIndex(
                name: "dictionary_id",
                table: "users",
                column: "dictionary_id");

            migrationBuilder.CreateIndex(
                name: "user_name",
                table: "users",
                column: "user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "word",
                table: "words",
                column: "word",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "dictionary_id1",
                table: "wordsdictionaries",
                column: "dictionary_id");

            migrationBuilder.CreateIndex(
                name: "word_id",
                table: "wordsdictionaries",
                column: "word_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "wordsdictionaries");

            migrationBuilder.DropTable(
                name: "dictionaries");

            migrationBuilder.DropTable(
                name: "words");
        }
    }
}
