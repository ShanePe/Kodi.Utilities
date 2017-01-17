using System;
using System.Collections.Generic;
using System.Linq;

namespace Kodi.Utilities.Data
{
    /// <summary>
    /// Creates a list of the supported ISO 639-2 Languages
    /// </summary>
    public class ISO6392LanguageFactory
    {
        public delegate void LanguagesLoadedHandler(ref List<ISO6392Language> languages);
        public static event LanguagesLoadedHandler onLanguagesLoaded;

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
            l.Add(new ISO6392Language("abk", "Abkhaz"));
            l.Add(new ISO6392Language("aar", "Afar"));
            l.Add(new ISO6392Language("afr", "Afrikaans"));
            l.Add(new ISO6392Language("aka", "Akan"));
            l.Add(new ISO6392Language("alb", "Albanian"));
            l.Add(new ISO6392Language("amh", "Amharic"));
            l.Add(new ISO6392Language("ara", "Arabic"));
            l.Add(new ISO6392Language("arg", "Aragonese"));
            l.Add(new ISO6392Language("arm", "Armenian"));
            l.Add(new ISO6392Language("asm", "Assamese"));
            l.Add(new ISO6392Language("ava", "Avaric"));
            l.Add(new ISO6392Language("ave", "Avestan"));
            l.Add(new ISO6392Language("aym", "Aymara"));
            l.Add(new ISO6392Language("aze", "Azerbaijani"));
            l.Add(new ISO6392Language("bam", "Bambara"));
            l.Add(new ISO6392Language("bak", "Bashkir"));
            l.Add(new ISO6392Language("eus", "Basque"));
            l.Add(new ISO6392Language("bel", "Belarusian"));
            l.Add(new ISO6392Language("ben", "Bengali"));
            l.Add(new ISO6392Language("bih", "Bihari"));
            l.Add(new ISO6392Language("bis", "Bislama"));
            l.Add(new ISO6392Language("bos", "Bosnian"));
            l.Add(new ISO6392Language("bre", "Breton"));
            l.Add(new ISO6392Language("bul", "Bulgarian"));
            l.Add(new ISO6392Language("bur", "Burmese"));
            l.Add(new ISO6392Language("cat", "Catalan"));
            l.Add(new ISO6392Language("cha", "Chamorro"));
            l.Add(new ISO6392Language("che", "Chechen"));
            l.Add(new ISO6392Language("nya", "Chinyanja"));
            l.Add(new ISO6392Language("zho", "Chinese"));
            l.Add(new ISO6392Language("chv", "Chuvash"));
            l.Add(new ISO6392Language("cor", "Cornish"));
            l.Add(new ISO6392Language("cos", "Corsican"));
            l.Add(new ISO6392Language("cre", "Cree"));
            l.Add(new ISO6392Language("hrv", "Croatian"));
            l.Add(new ISO6392Language("ces", "Czech"));
            l.Add(new ISO6392Language("dan", "Danish"));
            l.Add(new ISO6392Language("div", "Divehi"));
            l.Add(new ISO6392Language("nld", "Dutch"));
            l.Add(new ISO6392Language("dzo", "Dzongkha"));
            l.Add(new ISO6392Language("eng", "English"));
            l.Add(new ISO6392Language("epo", "Esperanto"));
            l.Add(new ISO6392Language("est", "Estonian"));
            l.Add(new ISO6392Language("ewe", "Ewe"));
            l.Add(new ISO6392Language("fao", "Faroese"));
            l.Add(new ISO6392Language("fij", "Fijian"));
            l.Add(new ISO6392Language("fin", "Finnish"));
            l.Add(new ISO6392Language("fra", "French"));
            l.Add(new ISO6392Language("ful", "Fula"));
            l.Add(new ISO6392Language("glg", "Galician"));
            l.Add(new ISO6392Language("geo", "Georgian"));
            l.Add(new ISO6392Language("ger", "German"));
            l.Add(new ISO6392Language("gre", "Greek (modern)"));
            l.Add(new ISO6392Language("grn", "Guaraní"));
            l.Add(new ISO6392Language("guj", "Gujarati"));
            l.Add(new ISO6392Language("hat", "Haitian"));
            l.Add(new ISO6392Language("hau", "Hausa"));
            l.Add(new ISO6392Language("heb", "Hebrew (modern)"));
            l.Add(new ISO6392Language("her", "Herero"));
            l.Add(new ISO6392Language("hin", "Hindi"));
            l.Add(new ISO6392Language("hmo", "Hiri Motu"));
            l.Add(new ISO6392Language("hun", "Hungarian"));
            l.Add(new ISO6392Language("ina", "Interlingua"));
            l.Add(new ISO6392Language("ind", "Indonesian"));
            l.Add(new ISO6392Language("ile", "Interlingue"));
            l.Add(new ISO6392Language("gle", "Irish"));
            l.Add(new ISO6392Language("ibo", "Igbo"));
            l.Add(new ISO6392Language("ipk", "Inupiaq"));
            l.Add(new ISO6392Language("ido", "Ido"));
            l.Add(new ISO6392Language("ice", "Icelandic"));
            l.Add(new ISO6392Language("ita", "Italian"));
            l.Add(new ISO6392Language("iku", "Inuktitut"));
            l.Add(new ISO6392Language("jpn", "Japanese"));
            l.Add(new ISO6392Language("jav", "Javanese"));
            l.Add(new ISO6392Language("kal", "Kalaallisut"));
            l.Add(new ISO6392Language("kan", "Kannada"));
            l.Add(new ISO6392Language("kau", "Kanuri"));
            l.Add(new ISO6392Language("kas", "Kashmiri"));
            l.Add(new ISO6392Language("kaz", "Kazakh"));
            l.Add(new ISO6392Language("khm", "Khmer"));
            l.Add(new ISO6392Language("kik", "Kikuyu"));
            l.Add(new ISO6392Language("kin", "Kinyarwanda"));
            l.Add(new ISO6392Language("kir", "Kyrgyz"));
            l.Add(new ISO6392Language("kom", "Komi"));
            l.Add(new ISO6392Language("kon", "Kongo"));
            l.Add(new ISO6392Language("kor", "Korean"));
            l.Add(new ISO6392Language("kur", "Kurdish"));
            l.Add(new ISO6392Language("kua", "Kwanyama"));
            l.Add(new ISO6392Language("lat", "Latin"));
            l.Add(new ISO6392Language("ltz", "Luxembourgish"));
            l.Add(new ISO6392Language("lug", "Ganda"));
            l.Add(new ISO6392Language("lim", "Limburgish"));
            l.Add(new ISO6392Language("lin", "Lingala"));
            l.Add(new ISO6392Language("lao", "Lao"));
            l.Add(new ISO6392Language("lit", "Lithuanian"));
            l.Add(new ISO6392Language("lub", "Luba-Katanga"));
            l.Add(new ISO6392Language("lav", "Latvian"));
            l.Add(new ISO6392Language("glv", "Manx"));
            l.Add(new ISO6392Language("mac", "Macedonian"));
            l.Add(new ISO6392Language("mlg", "Malagasy"));
            l.Add(new ISO6392Language("msa", "Malay"));
            l.Add(new ISO6392Language("mal", "Malayalam"));
            l.Add(new ISO6392Language("mlt", "Maltese"));
            l.Add(new ISO6392Language("mao", "Māori"));
            l.Add(new ISO6392Language("mar", "Marathi (Marāṭhī)"));
            l.Add(new ISO6392Language("mah", "Marshallese"));
            l.Add(new ISO6392Language("mon", "Mongolian"));
            l.Add(new ISO6392Language("nau", "Nauruan"));
            l.Add(new ISO6392Language("nav", "Navajo"));
            l.Add(new ISO6392Language("nde", "Northern Ndebele"));
            l.Add(new ISO6392Language("nep", "Nepali"));
            l.Add(new ISO6392Language("ndo", "Ndonga"));
            l.Add(new ISO6392Language("nob", "Norwegian Bokmål"));
            l.Add(new ISO6392Language("nno", "Norwegian Nynorsk"));
            l.Add(new ISO6392Language("nor", "Norwegian"));
            l.Add(new ISO6392Language("iii", "Nuosu"));
            l.Add(new ISO6392Language("nbl", "Southern Ndebele"));
            l.Add(new ISO6392Language("oci", "Occitan"));
            l.Add(new ISO6392Language("oji", "Ojibwe"));
            l.Add(new ISO6392Language("chu", "Old Church Slavonic"));
            l.Add(new ISO6392Language("orm", "Oromo"));
            l.Add(new ISO6392Language("ori", "Oriya"));
            l.Add(new ISO6392Language("oss", "Ossetian"));
            l.Add(new ISO6392Language("pan", "Eastern Punjabi"));
            l.Add(new ISO6392Language("pli", "Pāli"));
            l.Add(new ISO6392Language("per", "Persian (Farsi)"));
            l.Add(new ISO6392Language("pol", "Polish"));
            l.Add(new ISO6392Language("pus", "Pashto"));
            l.Add(new ISO6392Language("por", "Portuguese"));
            l.Add(new ISO6392Language("que", "Quechua"));
            l.Add(new ISO6392Language("roh", "Romansh"));
            l.Add(new ISO6392Language("run", "Kirundi"));
            l.Add(new ISO6392Language("rum", "Romanian"));
            l.Add(new ISO6392Language("rus", "Russian"));
            l.Add(new ISO6392Language("san", "Sanskrit (Saṁskṛta)"));
            l.Add(new ISO6392Language("srd", "Sardinian"));
            l.Add(new ISO6392Language("snd", "Sindhi"));
            l.Add(new ISO6392Language("sme", "Northern Sami"));
            l.Add(new ISO6392Language("smo", "Samoan"));
            l.Add(new ISO6392Language("sag", "Sango"));
            l.Add(new ISO6392Language("srp", "Serbian"));
            l.Add(new ISO6392Language("gla", "Scottish Gaelic"));
            l.Add(new ISO6392Language("sna", "Shona"));
            l.Add(new ISO6392Language("sin", "Sinhalese"));
            l.Add(new ISO6392Language("slk", "Slovak"));
            l.Add(new ISO6392Language("slv", "Slovene"));
            l.Add(new ISO6392Language("som", "Somali"));
            l.Add(new ISO6392Language("sot", "Southern Sotho"));
            l.Add(new ISO6392Language("spa", "Spanish"));
            l.Add(new ISO6392Language("sun", "Sundanese"));
            l.Add(new ISO6392Language("swa", "Swahili"));
            l.Add(new ISO6392Language("ssw", "Swati"));
            l.Add(new ISO6392Language("swe", "Swedish"));
            l.Add(new ISO6392Language("tam", "Tamil"));
            l.Add(new ISO6392Language("tel", "Telugu"));
            l.Add(new ISO6392Language("tgk", "Tajik"));
            l.Add(new ISO6392Language("tha", "Thai"));
            l.Add(new ISO6392Language("tir", "Tigrinya"));
            l.Add(new ISO6392Language("bod", "Tibetan Standard"));
            l.Add(new ISO6392Language("tuk", "Turkmen"));
            l.Add(new ISO6392Language("tgl", "Tagalog"));
            l.Add(new ISO6392Language("tsn", "Tswana"));
            l.Add(new ISO6392Language("ton", "Tonga (Tonga Islands)"));
            l.Add(new ISO6392Language("tur", "Turkish"));
            l.Add(new ISO6392Language("tso", "Tsonga"));
            l.Add(new ISO6392Language("tat", "Tatar"));
            l.Add(new ISO6392Language("twi", "Twi"));
            l.Add(new ISO6392Language("tah", "Tahitian"));
            l.Add(new ISO6392Language("uig", "Uyghur"));
            l.Add(new ISO6392Language("ukr", "Ukrainian"));
            l.Add(new ISO6392Language("urd", "Urdu"));
            l.Add(new ISO6392Language("uzb", "Uzbek"));
            l.Add(new ISO6392Language("ven", "Venda"));
            l.Add(new ISO6392Language("vie", "Vietnamese"));
            l.Add(new ISO6392Language("vol", "Volapük"));
            l.Add(new ISO6392Language("wln", "Walloon"));
            l.Add(new ISO6392Language("wel", "Welsh"));
            l.Add(new ISO6392Language("wol", "Wolof"));
            l.Add(new ISO6392Language("fry", "Western Frisian"));
            l.Add(new ISO6392Language("xho", "Xhosa"));
            l.Add(new ISO6392Language("yid", "Yiddish"));
            l.Add(new ISO6392Language("yor", "Yoruba"));
            l.Add(new ISO6392Language("zha", "Zhuang"));
            l.Add(new ISO6392Language("zul", "Zulu"));

            onLanguagesLoaded?.Invoke(ref l);

            return l;
        }
    }
}
