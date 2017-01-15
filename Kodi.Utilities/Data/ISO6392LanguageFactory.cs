using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Data
{
    /// <summary>
    /// Creates a list of the supported ISO 639-2 Languages
    /// </summary>
    public class ISO6392LanguageFactory
    {
        private static List<ISO6392Language> _langs = null;

        /// <summary>
        /// Gets the languages.
        /// </summary>
        /// <value>
        /// The languages.
        /// </value>
        public static List<ISO6392Language> Languages
        {
            get
            {
                if (_langs == null)
                {
                    ISO6392LanguageFactory fact = new ISO6392LanguageFactory();
                    _langs = fact.Build();
                }
                return _langs;
            }
        }

        /// <summary>
        /// Gets the language by code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public static ISO6392Language GetByCode(string code)
        {
            return Languages.FirstOrDefault(l => l.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Gets the language by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static ISO6392Language GetByName(string name)
        {
            return Languages.FirstOrDefault(l => l.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="ISO6392LanguageFactory"/> class from being created.
        /// </summary>
        private ISO6392LanguageFactory() { }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        private List<ISO6392Language> Build()
        {
            List<ISO6392Language> l = new List<ISO6392Language>();
            l.Add(new ISO6392Language("dut", "Dutch; Flemish"));
            l.Add(new ISO6392Language("dyu", "Dyula"));
            l.Add(new ISO6392Language("dzo", "Dzongkha"));
            l.Add(new ISO6392Language("efi", "Efik"));
            l.Add(new ISO6392Language("egy", "Egyptian (Ancient)"));
            l.Add(new ISO6392Language("eka", "Ekajuk"));
            l.Add(new ISO6392Language("elx", "Elamite"));
            l.Add(new ISO6392Language("eng", "English"));
            l.Add(new ISO6392Language("enm", "English"));
            l.Add(new ISO6392Language("epo", "Esperanto"));
            l.Add(new ISO6392Language("est", "Estonian"));
            l.Add(new ISO6392Language("ewe", "Ewe"));
            l.Add(new ISO6392Language("ewo", "Ewondo"));
            l.Add(new ISO6392Language("fan", "Fang"));
            l.Add(new ISO6392Language("fao", "Faroese"));
            l.Add(new ISO6392Language("fat", "Fanti"));
            l.Add(new ISO6392Language("fij", "Fijian"));
            l.Add(new ISO6392Language("fil", "Filipino; Pilipino"));
            l.Add(new ISO6392Language("fin", "Finnish"));
            l.Add(new ISO6392Language("fiu", "Finno-Ugrian languages"));
            l.Add(new ISO6392Language("fon", "Fon"));
            l.Add(new ISO6392Language("fre", "French"));
            l.Add(new ISO6392Language("frm", "French"));
            l.Add(new ISO6392Language("fro", "French"));
            l.Add(new ISO6392Language("frr", "Northern Frisian"));
            l.Add(new ISO6392Language("frs", "Eastern Frisian"));
            l.Add(new ISO6392Language("fry", "Western Frisian"));
            l.Add(new ISO6392Language("ful", "Fulah"));
            l.Add(new ISO6392Language("fur", "Friulian"));
            l.Add(new ISO6392Language("gaa", "Ga"));
            l.Add(new ISO6392Language("gay", "Gayo"));
            l.Add(new ISO6392Language("gba", "Gbaya"));
            l.Add(new ISO6392Language("gem", "Germanic languages"));
            l.Add(new ISO6392Language("geo", "Georgian"));
            l.Add(new ISO6392Language("ger", "German"));
            l.Add(new ISO6392Language("gez", "Geez"));
            l.Add(new ISO6392Language("gil", "Gilbertese"));
            l.Add(new ISO6392Language("gla", "Gaelic; Scottish Gaelic"));
            l.Add(new ISO6392Language("gle", "Irish"));
            l.Add(new ISO6392Language("glg", "Galician"));
            l.Add(new ISO6392Language("glv", "Manx"));
            l.Add(new ISO6392Language("gmh", "German"));
            l.Add(new ISO6392Language("goh", "German"));
            l.Add(new ISO6392Language("gon", "Gondi"));
            l.Add(new ISO6392Language("gor", "Gorontalo"));
            l.Add(new ISO6392Language("got", "Gothic"));
            l.Add(new ISO6392Language("grb", "Grebo"));
            l.Add(new ISO6392Language("grc", "Greek"));
            l.Add(new ISO6392Language("gre", "Greek"));
            l.Add(new ISO6392Language("grn", "Guarani"));
            l.Add(new ISO6392Language("gsw", "Swiss German; Alemannic; Alsatian"));
            l.Add(new ISO6392Language("guj", "Gujarati"));
            l.Add(new ISO6392Language("gwi", "Gwich'in"));
            l.Add(new ISO6392Language("hai", "Haida"));
            l.Add(new ISO6392Language("hat", "Haitian; Haitian Creole"));
            l.Add(new ISO6392Language("hau", "Hausa"));
            l.Add(new ISO6392Language("haw", "Hawaiian"));
            l.Add(new ISO6392Language("heb", "Hebrew"));
            l.Add(new ISO6392Language("her", "Herero"));
            l.Add(new ISO6392Language("hil", "Hiligaynon"));
            l.Add(new ISO6392Language("him", "Himachali languages; Western Pahari languages"));
            l.Add(new ISO6392Language("hin", "Hindi"));
            l.Add(new ISO6392Language("hit", "Hittite"));
            l.Add(new ISO6392Language("hmn", "Hmong; Mong"));
            l.Add(new ISO6392Language("hmo", "Hiri Motu"));
            l.Add(new ISO6392Language("hrv", "Croatian"));
            l.Add(new ISO6392Language("hsb", "Upper Sorbian"));
            l.Add(new ISO6392Language("hun", "Hungarian"));
            l.Add(new ISO6392Language("hup", "Hupa"));
            l.Add(new ISO6392Language("iba", "Iban"));
            l.Add(new ISO6392Language("ibo", "Igbo"));
            l.Add(new ISO6392Language("ice", "Icelandic"));
            l.Add(new ISO6392Language("ido", "Ido"));
            l.Add(new ISO6392Language("iii", "Sichuan Yi; Nuosu"));
            l.Add(new ISO6392Language("ijo", "Ijo languages"));
            l.Add(new ISO6392Language("iku", "Inuktitut"));
            l.Add(new ISO6392Language("ile", "Interlingue; Occidental"));
            l.Add(new ISO6392Language("ilo", "Iloko"));
            l.Add(new ISO6392Language("ina", "Interlingua (International Auxiliary Language Association)"));
            l.Add(new ISO6392Language("inc", "Indic languages"));
            l.Add(new ISO6392Language("ind", "Indonesian"));
            l.Add(new ISO6392Language("ine", "Indo-European languages"));
            l.Add(new ISO6392Language("inh", "Ingush"));
            l.Add(new ISO6392Language("ipk", "Inupiaq"));
            l.Add(new ISO6392Language("ira", "Iranian languages"));
            l.Add(new ISO6392Language("iro", "Iroquoian languages"));
            l.Add(new ISO6392Language("ita", "Italian"));
            l.Add(new ISO6392Language("jav", "Javanese"));
            l.Add(new ISO6392Language("jbo", "Lojban"));
            l.Add(new ISO6392Language("jpn", "Japanese"));
            l.Add(new ISO6392Language("jpr", "Judeo-Persian"));
            l.Add(new ISO6392Language("jrb", "Judeo-Arabic"));
            l.Add(new ISO6392Language("kaa", "Kara-Kalpak"));
            l.Add(new ISO6392Language("kab", "Kabyle"));
            l.Add(new ISO6392Language("kac", "Kachin; Jingpho"));
            l.Add(new ISO6392Language("kal", "Kalaallisut; Greenlandic"));
            l.Add(new ISO6392Language("kam", "Kamba"));
            l.Add(new ISO6392Language("kan", "Kannada"));
            l.Add(new ISO6392Language("kar", "Karen languages"));
            l.Add(new ISO6392Language("kas", "Kashmiri"));
            l.Add(new ISO6392Language("kau", "Kanuri"));
            l.Add(new ISO6392Language("kaw", "Kawi"));
            l.Add(new ISO6392Language("kaz", "Kazakh"));
            l.Add(new ISO6392Language("kbd", "Kabardian"));
            l.Add(new ISO6392Language("kha", "Khasi"));
            l.Add(new ISO6392Language("khi", "Khoisan languages"));
            l.Add(new ISO6392Language("khm", "Central Khmer"));
            l.Add(new ISO6392Language("kho", "Khotanese; Sakan"));
            l.Add(new ISO6392Language("kik", "Kikuyu; Gikuyu"));
            l.Add(new ISO6392Language("kin", "Kinyarwanda"));
            l.Add(new ISO6392Language("kir", "Kirghiz; Kyrgyz"));
            l.Add(new ISO6392Language("kmb", "Kimbundu"));
            l.Add(new ISO6392Language("kok", "Konkani"));
            l.Add(new ISO6392Language("kom", "Komi"));
            l.Add(new ISO6392Language("kon", "Kongo"));
            l.Add(new ISO6392Language("kor", "Korean"));
            l.Add(new ISO6392Language("kos", "Kosraean"));
            l.Add(new ISO6392Language("kpe", "Kpelle"));
            l.Add(new ISO6392Language("krc", "Karachay-Balkar"));
            l.Add(new ISO6392Language("krl", "Karelian"));
            l.Add(new ISO6392Language("kro", "Kru languages"));
            l.Add(new ISO6392Language("kru", "Kurukh"));
            l.Add(new ISO6392Language("kua", "Kuanyama; Kwanyama"));
            l.Add(new ISO6392Language("kum", "Kumyk"));
            l.Add(new ISO6392Language("kur", "Kurdish"));
            l.Add(new ISO6392Language("kut", "Kutenai"));
            l.Add(new ISO6392Language("lad", "Ladino"));
            l.Add(new ISO6392Language("lah", "Lahnda"));
            l.Add(new ISO6392Language("lam", "Lamba"));
            l.Add(new ISO6392Language("lao", "Lao"));
            l.Add(new ISO6392Language("lat", "Latin"));
            l.Add(new ISO6392Language("lav", "Latvian"));
            l.Add(new ISO6392Language("lez", "Lezghian"));
            l.Add(new ISO6392Language("lim", "Limburgan; Limburger; Limburgish"));
            l.Add(new ISO6392Language("lin", "Lingala"));
            l.Add(new ISO6392Language("lit", "Lithuanian"));
            l.Add(new ISO6392Language("lol", "Mongo"));
            l.Add(new ISO6392Language("loz", "Lozi"));
            l.Add(new ISO6392Language("ltz", "Luxembourgish; Letzeburgesch"));
            l.Add(new ISO6392Language("lua", "Luba-Lulua"));
            l.Add(new ISO6392Language("lub", "Luba-Katanga"));
            l.Add(new ISO6392Language("lug", "Ganda"));
            l.Add(new ISO6392Language("lui", "Luiseno"));
            l.Add(new ISO6392Language("lun", "Lunda"));
            l.Add(new ISO6392Language("luo", "Luo (Kenya and Tanzania)"));
            l.Add(new ISO6392Language("lus", "Lushai"));
            l.Add(new ISO6392Language("mac", "Macedonian"));
            l.Add(new ISO6392Language("mad", "Madurese"));
            l.Add(new ISO6392Language("mag", "Magahi"));
            l.Add(new ISO6392Language("mah", "Marshallese"));
            l.Add(new ISO6392Language("mai", "Maithili"));
            l.Add(new ISO6392Language("mak", "Makasar"));
            l.Add(new ISO6392Language("mal", "Malayalam"));
            l.Add(new ISO6392Language("man", "Mandingo"));
            l.Add(new ISO6392Language("mao", "Maori"));
            l.Add(new ISO6392Language("map", "Austronesian languages"));
            l.Add(new ISO6392Language("mar", "Marathi"));
            l.Add(new ISO6392Language("mas", "Masai"));
            l.Add(new ISO6392Language("may", "Malay"));
            l.Add(new ISO6392Language("mdf", "Moksha"));
            l.Add(new ISO6392Language("mdr", "Mandar"));
            l.Add(new ISO6392Language("men", "Mende"));
            l.Add(new ISO6392Language("mga", "Irish"));
            l.Add(new ISO6392Language("mic", "Mi'kmaq; Micmac"));
            l.Add(new ISO6392Language("min", "Minangkabau"));
            l.Add(new ISO6392Language("mis", "Uncoded languages"));
            l.Add(new ISO6392Language("mkh", "Mon-Khmer languages"));
            l.Add(new ISO6392Language("mlg", "Malagasy"));
            l.Add(new ISO6392Language("mlt", "Maltese"));
            l.Add(new ISO6392Language("mnc", "Manchu"));
            l.Add(new ISO6392Language("mni", "Manipuri"));
            l.Add(new ISO6392Language("mno", "Manobo languages"));
            l.Add(new ISO6392Language("moh", "Mohawk"));
            l.Add(new ISO6392Language("mon", "Mongolian"));
            l.Add(new ISO6392Language("mos", "Mossi"));
            l.Add(new ISO6392Language("mul", "Multiple languages"));
            l.Add(new ISO6392Language("mun", "Munda languages"));
            l.Add(new ISO6392Language("mus", "Creek"));
            l.Add(new ISO6392Language("mwl", "Mirandese"));
            l.Add(new ISO6392Language("mwr", "Marwari"));
            l.Add(new ISO6392Language("myn", "Mayan languages"));
            l.Add(new ISO6392Language("myv", "Erzya"));
            l.Add(new ISO6392Language("nah", "Nahuatl languages"));
            l.Add(new ISO6392Language("nai", "North American Indian languages"));
            l.Add(new ISO6392Language("nap", "Neapolitan"));
            l.Add(new ISO6392Language("nau", "Nauru"));
            l.Add(new ISO6392Language("nav", "Navajo; Navaho"));
            l.Add(new ISO6392Language("nbl", "Ndebele"));
            l.Add(new ISO6392Language("nde", "Ndebele"));
            l.Add(new ISO6392Language("ndo", "Ndonga"));
            l.Add(new ISO6392Language("nds", "Low German; Low Saxon; German"));
            l.Add(new ISO6392Language("nep", "Nepali"));
            l.Add(new ISO6392Language("new", "Nepal Bhasa; Newari"));
            l.Add(new ISO6392Language("nia", "Nias"));
            l.Add(new ISO6392Language("nic", "Niger-Kordofanian languages"));
            l.Add(new ISO6392Language("niu", "Niuean"));
            l.Add(new ISO6392Language("nno", "Norwegian Nynorsk; Nynorsk"));
            l.Add(new ISO6392Language("nob", "Bokmål"));
            l.Add(new ISO6392Language("nog", "Nogai"));
            l.Add(new ISO6392Language("non", "Norse"));
            l.Add(new ISO6392Language("nor", "Norwegian"));
            l.Add(new ISO6392Language("nqo", "N'Ko"));
            l.Add(new ISO6392Language("nso", "Pedi; Sepedi; Northern Sotho"));
            l.Add(new ISO6392Language("nub", "Nubian languages"));
            l.Add(new ISO6392Language("nwc", "Classical Newari; Old Newari; Classical Nepal Bhasa"));
            l.Add(new ISO6392Language("nya", "Chichewa; Chewa; Nyanja"));
            l.Add(new ISO6392Language("nym", "Nyamwezi"));
            l.Add(new ISO6392Language("nyn", "Nyankole"));
            l.Add(new ISO6392Language("nyo", "Nyoro"));
            l.Add(new ISO6392Language("nzi", "Nzima"));
            l.Add(new ISO6392Language("oci", "Occitan (post 1500); Provençal"));
            l.Add(new ISO6392Language("oji", "Ojibwa"));
            l.Add(new ISO6392Language("ori", "Oriya"));
            l.Add(new ISO6392Language("orm", "Oromo"));
            l.Add(new ISO6392Language("osa", "Osage"));
            l.Add(new ISO6392Language("oss", "Ossetian; Ossetic"));
            l.Add(new ISO6392Language("ota", "Turkish"));
            l.Add(new ISO6392Language("oto", "Otomian languages"));
            l.Add(new ISO6392Language("paa", "Papuan languages"));
            l.Add(new ISO6392Language("pag", "Pangasinan"));
            l.Add(new ISO6392Language("pal", "Pahlavi"));
            l.Add(new ISO6392Language("pam", "Pampanga; Kapampangan"));
            l.Add(new ISO6392Language("pan", "Panjabi; Punjabi"));
            l.Add(new ISO6392Language("pap", "Papiamento"));
            l.Add(new ISO6392Language("pau", "Palauan"));
            l.Add(new ISO6392Language("peo", "Persian"));
            l.Add(new ISO6392Language("per", "Persian"));
            l.Add(new ISO6392Language("phi", "Philippine languages"));
            l.Add(new ISO6392Language("phn", "Phoenician"));
            l.Add(new ISO6392Language("pli", "Pali"));
            l.Add(new ISO6392Language("pol", "Polish"));
            l.Add(new ISO6392Language("pon", "Pohnpeian"));
            l.Add(new ISO6392Language("por", "Portuguese"));
            l.Add(new ISO6392Language("pra", "Prakrit languages"));
            l.Add(new ISO6392Language("pro", "Provençal"));
            l.Add(new ISO6392Language("pus", "Pushto; Pashto"));
            l.Add(new ISO6392Language("qa", "-qtz	Reserved for local use"));
            l.Add(new ISO6392Language("que", "Quechua"));
            l.Add(new ISO6392Language("raj", "Rajasthani"));
            l.Add(new ISO6392Language("rap", "Rapanui"));
            l.Add(new ISO6392Language("rar", "Rarotongan; Cook Islands Maori"));
            l.Add(new ISO6392Language("roa", "Romance languages"));
            l.Add(new ISO6392Language("roh", "Romansh"));
            l.Add(new ISO6392Language("rom", "Romany"));
            l.Add(new ISO6392Language("rum", "Romanian; Moldavian; Moldovan"));
            l.Add(new ISO6392Language("run", "Rundi"));
            l.Add(new ISO6392Language("rup", "Aromanian; Arumanian; Macedo-Romanian"));
            l.Add(new ISO6392Language("rus", "Russian"));
            l.Add(new ISO6392Language("sad", "Sandawe"));
            l.Add(new ISO6392Language("sag", "Sango"));
            l.Add(new ISO6392Language("sah", "Yakut"));
            l.Add(new ISO6392Language("sai", "South American Indian (Other)"));
            l.Add(new ISO6392Language("sal", "Salishan languages"));
            l.Add(new ISO6392Language("sam", "Samaritan Aramaic"));
            l.Add(new ISO6392Language("san", "Sanskrit"));
            l.Add(new ISO6392Language("sas", "Sasak"));
            l.Add(new ISO6392Language("sat", "Santali"));
            l.Add(new ISO6392Language("scn", "Sicilian"));
            l.Add(new ISO6392Language("sco", "Scots"));
            l.Add(new ISO6392Language("sel", "Selkup"));
            l.Add(new ISO6392Language("sem", "Semitic languages"));
            l.Add(new ISO6392Language("sga", "Irish"));
            l.Add(new ISO6392Language("sgn", "Sign Languages"));
            l.Add(new ISO6392Language("shn", "Shan"));
            l.Add(new ISO6392Language("sid", "Sidamo"));
            l.Add(new ISO6392Language("sin", "Sinhala; Sinhalese"));
            l.Add(new ISO6392Language("sio", "Siouan languages"));
            l.Add(new ISO6392Language("sit", "Sino-Tibetan languages"));
            l.Add(new ISO6392Language("sla", "Slavic languages"));
            l.Add(new ISO6392Language("slo", "Slovak"));
            l.Add(new ISO6392Language("slv", "Slovenian"));
            l.Add(new ISO6392Language("sma", "Southern Sami"));
            l.Add(new ISO6392Language("sme", "Northern Sami"));
            l.Add(new ISO6392Language("smi", "Sami languages"));
            l.Add(new ISO6392Language("smj", "Lule Sami"));
            l.Add(new ISO6392Language("smn", "Inari Sami"));
            l.Add(new ISO6392Language("smo", "Samoan"));
            l.Add(new ISO6392Language("sms", "Skolt Sami"));
            l.Add(new ISO6392Language("sna", "Shona"));
            l.Add(new ISO6392Language("snd", "Sindhi"));
            l.Add(new ISO6392Language("snk", "Soninke"));
            l.Add(new ISO6392Language("sog", "Sogdian"));
            l.Add(new ISO6392Language("som", "Somali"));
            l.Add(new ISO6392Language("son", "Songhai languages"));
            l.Add(new ISO6392Language("sot", "Sotho"));
            l.Add(new ISO6392Language("spa", "Spanish; Castilian"));
            l.Add(new ISO6392Language("srd", "Sardinian"));
            l.Add(new ISO6392Language("srn", "Sranan Tongo"));
            l.Add(new ISO6392Language("srp", "Serbian"));
            l.Add(new ISO6392Language("srr", "Serer"));
            l.Add(new ISO6392Language("ssa", "Nilo-Saharan languages"));
            l.Add(new ISO6392Language("ssw", "Swati"));
            l.Add(new ISO6392Language("suk", "Sukuma"));
            l.Add(new ISO6392Language("sun", "Sundanese"));
            l.Add(new ISO6392Language("sus", "Susu"));
            l.Add(new ISO6392Language("sux", "Sumerian"));
            l.Add(new ISO6392Language("swa", "Swahili"));
            l.Add(new ISO6392Language("swe", "Swedish"));
            l.Add(new ISO6392Language("syc", "Classical Syriac"));
            l.Add(new ISO6392Language("syr", "Syriac"));
            l.Add(new ISO6392Language("tah", "Tahitian"));
            l.Add(new ISO6392Language("tai", "Tai languages"));
            l.Add(new ISO6392Language("tam", "Tamil"));
            l.Add(new ISO6392Language("tat", "Tatar"));
            l.Add(new ISO6392Language("tel", "Telugu"));
            l.Add(new ISO6392Language("tem", "Timne"));
            l.Add(new ISO6392Language("ter", "Tereno"));
            l.Add(new ISO6392Language("tet", "Tetum"));
            l.Add(new ISO6392Language("tgk", "Tajik"));
            l.Add(new ISO6392Language("tgl", "Tagalog"));
            l.Add(new ISO6392Language("tha", "Thai"));
            l.Add(new ISO6392Language("tib", "Tibetan"));
            l.Add(new ISO6392Language("tig", "Tigre"));
            l.Add(new ISO6392Language("tir", "Tigrinya"));
            l.Add(new ISO6392Language("tiv", "Tiv"));
            l.Add(new ISO6392Language("tkl", "Tokelau"));
            l.Add(new ISO6392Language("tlh", "Klingon; tlhIngan-Hol"));
            l.Add(new ISO6392Language("tli", "Tlingit"));
            l.Add(new ISO6392Language("tmh", "Tamashek"));
            l.Add(new ISO6392Language("tog", "Tonga (Nyasa)"));
            l.Add(new ISO6392Language("ton", "Tonga (Tonga Islands)"));
            l.Add(new ISO6392Language("tpi", "Tok Pisin"));
            l.Add(new ISO6392Language("tsi", "Tsimshian"));
            l.Add(new ISO6392Language("tsn", "Tswana"));
            l.Add(new ISO6392Language("tso", "Tsonga"));
            l.Add(new ISO6392Language("tuk", "Turkmen"));
            l.Add(new ISO6392Language("tum", "Tumbuka"));
            l.Add(new ISO6392Language("tup", "Tupi languages"));
            l.Add(new ISO6392Language("tur", "Turkish"));
            l.Add(new ISO6392Language("tut", "Altaic languages"));
            l.Add(new ISO6392Language("tvl", "Tuvalu"));
            l.Add(new ISO6392Language("twi", "Twi"));
            l.Add(new ISO6392Language("tyv", "Tuvinian"));
            l.Add(new ISO6392Language("udm", "Udmurt"));
            l.Add(new ISO6392Language("uga", "Ugaritic"));
            l.Add(new ISO6392Language("uig", "Uighur; Uyghur"));
            l.Add(new ISO6392Language("ukr", "Ukrainian"));
            l.Add(new ISO6392Language("umb", "Umbundu"));
            l.Add(new ISO6392Language("und", "Undetermined"));
            l.Add(new ISO6392Language("urd", "Urdu"));
            l.Add(new ISO6392Language("uzb", "Uzbek"));
            l.Add(new ISO6392Language("vai", "Vai"));
            l.Add(new ISO6392Language("ven", "Venda"));
            l.Add(new ISO6392Language("vie", "Vietnamese"));
            l.Add(new ISO6392Language("vol", "Volapük"));
            l.Add(new ISO6392Language("vot", "Votic"));
            l.Add(new ISO6392Language("wak", "Wakashan languages"));
            l.Add(new ISO6392Language("wal", "Walamo"));
            l.Add(new ISO6392Language("war", "Waray"));
            l.Add(new ISO6392Language("was", "Washo"));
            l.Add(new ISO6392Language("wel", "Welsh"));
            l.Add(new ISO6392Language("wen", "Sorbian languages"));
            l.Add(new ISO6392Language("wln", "Walloon"));
            l.Add(new ISO6392Language("wol", "Wolof"));
            l.Add(new ISO6392Language("xal", "Kalmyk; Oirat"));
            l.Add(new ISO6392Language("xho", "Xhosa"));
            l.Add(new ISO6392Language("yao", "Yao"));
            l.Add(new ISO6392Language("yap", "Yapese"));
            l.Add(new ISO6392Language("yid", "Yiddish"));
            l.Add(new ISO6392Language("yor", "Yoruba"));
            l.Add(new ISO6392Language("ypk", "Yupik languages"));
            l.Add(new ISO6392Language("zap", "Zapotec"));
            l.Add(new ISO6392Language("zbl", "Blissymbols; Blissymbolics; Bliss"));
            l.Add(new ISO6392Language("zen", "Zenaga"));
            l.Add(new ISO6392Language("zgh", "Standard Moroccan Tamazight"));
            l.Add(new ISO6392Language("zha", "Zhuang; Chuang"));
            l.Add(new ISO6392Language("znd", "Zande languages"));
            l.Add(new ISO6392Language("zul", "Zulu"));
            l.Add(new ISO6392Language("zun", "Zuni"));
            l.Add(new ISO6392Language("zxx", "No linguistic content; Not applicable"));
            l.Add(new ISO6392Language("zza", "Zaza; Dimili; Dimli; Kirdki; Kirmanjki; Zazak"));
            return l;
        }
    }
}
