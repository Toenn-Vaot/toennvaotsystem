
using System.Diagnostics.CodeAnalysis;

namespace ToennVaot.Components.Core.Models.Languages
{
    ///<summary>
    /// The base class definition for language
    ///</summary>
    public abstract class Language
    {
        ///<summary>
        /// ISO-3166 alpha 2 code
        ///</summary>
        public abstract string IsoCodeAlpha2 { get; }

        ///<summary>
        /// ISO-3166 alpha 3 code
        ///</summary>
        public abstract string IsoCodeAlpha3 { get; }
    
        ///<summary>
        /// The language name per language
        ///</summary>
        [SuppressMessage("ReSharper", "StringLiteralTypo")]
        public abstract Dictionary<string, string> LanguageNames { get; }
    }


    ///<summary>
    /// The class definition for language of Afar
    ///</summary>
    public class Afar : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "aa";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "aar";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Afar" }, // Default to English as language name
            { "fr", "afar" },
        };
    }

    ///<summary>
    /// The class definition for language of Abkhazian
    ///</summary>
    public class Abkhazian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ab";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "abk";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Abkhazian" }, // Default to English as language name
            { "fr", "abkhaze" },
        };
    }

    ///<summary>
    /// The class definition for language of Afrikaans
    ///</summary>
    public class Afrikaans : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "af";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "afr";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Afrikaans" }, // Default to English as language name
            { "fr", "afrikaans" },
        };
    }

    ///<summary>
    /// The class definition for language of Akan
    ///</summary>
    public class Akan : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ak";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "aka";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Akan" }, // Default to English as language name
            { "fr", "akan" },
        };
    }

    ///<summary>
    /// The class definition for language of Albanian
    ///</summary>
    public class Albanian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sq";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "alb";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Albanian" }, // Default to English as language name
            { "fr", "albanais" },
        };
    }

    ///<summary>
    /// The class definition for language of Amharic
    ///</summary>
    public class Amharic : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "am";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "amh";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Amharic" }, // Default to English as language name
            { "fr", "amharique" },
        };
    }

    ///<summary>
    /// The class definition for language of Arabic
    ///</summary>
    public class Arabic : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ar";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ara";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Arabic" }, // Default to English as language name
            { "fr", "arabe" },
        };
    }

    ///<summary>
    /// The class definition for language of Aragonese
    ///</summary>
    public class Aragonese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "an";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "arg";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Aragonese" }, // Default to English as language name
            { "fr", "aragonais" },
        };
    }

    ///<summary>
    /// The class definition for language of Armenian
    ///</summary>
    public class Armenian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "hy";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "arm";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Armenian" }, // Default to English as language name
            { "fr", "arménien" },
        };
    }

    ///<summary>
    /// The class definition for language of Assamese
    ///</summary>
    public class Assamese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "as";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "asm";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Assamese" }, // Default to English as language name
            { "fr", "assamais" },
        };
    }

    ///<summary>
    /// The class definition for language of Avaric
    ///</summary>
    public class Avaric : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "av";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ava";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Avaric" }, // Default to English as language name
            { "fr", "avar" },
        };
    }

    ///<summary>
    /// The class definition for language of Avestan
    ///</summary>
    public class Avestan : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ae";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ave";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Avestan" }, // Default to English as language name
            { "fr", "avestique" },
        };
    }

    ///<summary>
    /// The class definition for language of Aymara
    ///</summary>
    public class Aymara : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ay";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "aym";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Aymara" }, // Default to English as language name
            { "fr", "aymara" },
        };
    }

    ///<summary>
    /// The class definition for language of Azerbaijani
    ///</summary>
    public class Azerbaijani : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "az";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "aze";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Azerbaijani" }, // Default to English as language name
            { "fr", "azéri" },
        };
    }

    ///<summary>
    /// The class definition for language of Bashkir
    ///</summary>
    public class Bashkir : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ba";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "bak";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Bashkir" }, // Default to English as language name
            { "fr", "bachkir" },
        };
    }

    ///<summary>
    /// The class definition for language of Bambara
    ///</summary>
    public class Bambara : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "bm";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "bam";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Bambara" }, // Default to English as language name
            { "fr", "bambara" },
        };
    }

    ///<summary>
    /// The class definition for language of Basque
    ///</summary>
    public class Basque : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "eu";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "baq";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Basque" }, // Default to English as language name
            { "fr", "basque" },
        };
    }

    ///<summary>
    /// The class definition for language of Belarusian
    ///</summary>
    public class Belarusian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "be";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "bel";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Belarusian" }, // Default to English as language name
            { "fr", "biélorusse" },
        };
    }

    ///<summary>
    /// The class definition for language of Bengali
    ///</summary>
    public class Bengali : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "bn";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ben";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Bengali" }, // Default to English as language name
            { "fr", "bengali" },
        };
    }

    ///<summary>
    /// The class definition for language of Bislama
    ///</summary>
    public class Bislama : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "bi";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "bis";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Bislama" }, // Default to English as language name
            { "fr", "bichlamar" },
        };
    }

    ///<summary>
    /// The class definition for language of Bosnian
    ///</summary>
    public class Bosnian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "bs";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "bos";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Bosnian" }, // Default to English as language name
            { "fr", "bosniaque" },
        };
    }

    ///<summary>
    /// The class definition for language of Breton
    ///</summary>
    public class Breton : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "br";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "bre";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Breton" }, // Default to English as language name
            { "fr", "breton" },
        };
    }

    ///<summary>
    /// The class definition for language of Bulgarian
    ///</summary>
    public class Bulgarian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "bg";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "bul";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Bulgarian" }, // Default to English as language name
            { "fr", "bulgare" },
        };
    }

    ///<summary>
    /// The class definition for language of Burmese
    ///</summary>
    public class Burmese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "my";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "bur";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Burmese" }, // Default to English as language name
            { "fr", "birman" },
        };
    }

    ///<summary>
    /// The class definition for language of Catalan
    ///</summary>
    public class Catalan : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ca";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "cat";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Catalan" }, // Default to English as language name
            { "fr", "Valencian" },
        };
    }

    ///<summary>
    /// The class definition for language of Chamorro
    ///</summary>
    public class Chamorro : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ch";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "cha";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Chamorro" }, // Default to English as language name
            { "fr", "chamorro" },
        };
    }

    ///<summary>
    /// The class definition for language of Chechen
    ///</summary>
    public class Chechen : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ce";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "che";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Chechen" }, // Default to English as language name
            { "fr", "tchétchène" },
        };
    }

    ///<summary>
    /// The class definition for language of Chinese
    ///</summary>
    public class Chinese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "zh";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "chi";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Chinese" }, // Default to English as language name
            { "fr", "chinois" },
        };
    }

    ///<summary>
    /// The class definition for language of Church Slavic
    ///</summary>
    public class ChurchSlavic : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "cu";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "chu";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Church Slavic" }, // Default to English as language name
            { "fr", "Old Slavonic" },
        };
    }

    ///<summary>
    /// The class definition for language of Chuvash
    ///</summary>
    public class Chuvash : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "cv";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "chv";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Chuvash" }, // Default to English as language name
            { "fr", "tchouvache" },
        };
    }

    ///<summary>
    /// The class definition for language of Cornish
    ///</summary>
    public class Cornish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "kw";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "cor";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Cornish" }, // Default to English as language name
            { "fr", "cornique" },
        };
    }

    ///<summary>
    /// The class definition for language of Corsican
    ///</summary>
    public class Corsican : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "co";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "cos";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Corsican" }, // Default to English as language name
            { "fr", "corse" },
        };
    }

    ///<summary>
    /// The class definition for language of Cree
    ///</summary>
    public class Cree : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "cr";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "cre";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Cree" }, // Default to English as language name
            { "fr", "cree" },
        };
    }

    ///<summary>
    /// The class definition for language of Czech
    ///</summary>
    public class Czech : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "cs";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "cze";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Czech" }, // Default to English as language name
            { "fr", "tchèque" },
        };
    }

    ///<summary>
    /// The class definition for language of Danish
    ///</summary>
    public class Danish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "da";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "dan";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Danish" }, // Default to English as language name
            { "fr", "danois" },
        };
    }

    ///<summary>
    /// The class definition for language of Divehi
    ///</summary>
    public class Divehi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "dv";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "div";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Divehi" }, // Default to English as language name
            { "fr", "Dhivehi" },
        };
    }

    ///<summary>
    /// The class definition for language of Dutch
    ///</summary>
    public class Dutch : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "nl";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "dut";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Dutch" }, // Default to English as language name
            { "fr", "Flemish" },
        };
    }

    ///<summary>
    /// The class definition for language of Dzongkha
    ///</summary>
    public class Dzongkha : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "dz";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "dzo";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Dzongkha" }, // Default to English as language name
            { "fr", "dzongkha" },
        };
    }

    ///<summary>
    /// The class definition for language of English
    ///</summary>
    public class English : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "en";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "eng";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "English" }, // Default to English as language name
            { "fr", "anglais" },
        };
    }

    ///<summary>
    /// The class definition for language of Esperanto
    ///</summary>
    public class Esperanto : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "eo";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "epo";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Esperanto" }, // Default to English as language name
            { "fr", "espéranto" },
        };
    }

    ///<summary>
    /// The class definition for language of Estonian
    ///</summary>
    public class Estonian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "et";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "est";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Estonian" }, // Default to English as language name
            { "fr", "estonien" },
        };
    }

    ///<summary>
    /// The class definition for language of Ewe
    ///</summary>
    public class Ewe : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ee";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ewe";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ewe" }, // Default to English as language name
            { "fr", "éwé" },
        };
    }

    ///<summary>
    /// The class definition for language of Faroese
    ///</summary>
    public class Faroese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "fo";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "fao";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Faroese" }, // Default to English as language name
            { "fr", "féroïen" },
        };
    }

    ///<summary>
    /// The class definition for language of Fijian
    ///</summary>
    public class Fijian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "fj";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "fij";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Fijian" }, // Default to English as language name
            { "fr", "fidjien" },
        };
    }

    ///<summary>
    /// The class definition for language of Finnish
    ///</summary>
    public class Finnish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "fi";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "fin";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Finnish" }, // Default to English as language name
            { "fr", "finnois" },
        };
    }

    ///<summary>
    /// The class definition for language of French
    ///</summary>
    public class French : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "fr";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "fre";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "French" }, // Default to English as language name
            { "fr", "français" },
        };
    }

    ///<summary>
    /// The class definition for language of Western Frisian
    ///</summary>
    public class WesternFrisian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "fy";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "fry";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Western Frisian" }, // Default to English as language name
            { "fr", "frison occidental" },
        };
    }

    ///<summary>
    /// The class definition for language of Fulah
    ///</summary>
    public class Fulah : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ff";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ful";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Fulah" }, // Default to English as language name
            { "fr", "peul" },
        };
    }

    ///<summary>
    /// The class definition for language of Georgian
    ///</summary>
    public class Georgian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ka";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "geo";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Georgian" }, // Default to English as language name
            { "fr", "géorgien" },
        };
    }

    ///<summary>
    /// The class definition for language of German
    ///</summary>
    public class German : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "de";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ger";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "German" }, // Default to English as language name
            { "fr", "allemand" },
        };
    }

    ///<summary>
    /// The class definition for language of Gaelic
    ///</summary>
    public class Gaelic : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "gd";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "gla";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Gaelic" }, // Default to English as language name
            { "fr", "Scottish Gaelic" },
        };
    }

    ///<summary>
    /// The class definition for language of Irish
    ///</summary>
    public class Irish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ga";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "gle";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Irish" }, // Default to English as language name
            { "fr", "irlandais" },
        };
    }

    ///<summary>
    /// The class definition for language of Galician
    ///</summary>
    public class Galician : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "gl";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "glg";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Galician" }, // Default to English as language name
            { "fr", "galicien" },
        };
    }

    ///<summary>
    /// The class definition for language of Manx
    ///</summary>
    public class Manx : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "gv";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "glv";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Manx" }, // Default to English as language name
            { "fr", "manx" },
        };
    }

    ///<summary>
    /// The class definition for language of Greek, Modern (1453-)
    ///</summary>
    public class Greek : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "el";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "gre";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Greek, Modern (1453-)" }, // Default to English as language name
            { "fr", "grec moderne (après 1453)" },
        };
    }

    ///<summary>
    /// The class definition for language of Guarani
    ///</summary>
    public class Guarani : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "gn";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "grn";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Guarani" }, // Default to English as language name
            { "fr", "guarani" },
        };
    }

    ///<summary>
    /// The class definition for language of Gujarati
    ///</summary>
    public class Gujarati : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "gu";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "guj";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Gujarati" }, // Default to English as language name
            { "fr", "goudjrati" },
        };
    }

    ///<summary>
    /// The class definition for language of Haitian
    ///</summary>
    public class Haitian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ht";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "hat";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Haitian" }, // Default to English as language name
            { "fr", "Haitian Creole" },
        };
    }

    ///<summary>
    /// The class definition for language of Hausa
    ///</summary>
    public class Hausa : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ha";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "hau";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Hausa" }, // Default to English as language name
            { "fr", "haoussa" },
        };
    }

    ///<summary>
    /// The class definition for language of Hebrew
    ///</summary>
    public class Hebrew : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "he";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "heb";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Hebrew" }, // Default to English as language name
            { "fr", "hébreu" },
        };
    }

    ///<summary>
    /// The class definition for language of Herero
    ///</summary>
    public class Herero : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "hz";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "her";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Herero" }, // Default to English as language name
            { "fr", "herero" },
        };
    }

    ///<summary>
    /// The class definition for language of Hindi
    ///</summary>
    public class Hindi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "hi";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "hin";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Hindi" }, // Default to English as language name
            { "fr", "hindi" },
        };
    }

    ///<summary>
    /// The class definition for language of Hiri Motu
    ///</summary>
    public class HiriMotu : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ho";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "hmo";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Hiri Motu" }, // Default to English as language name
            { "fr", "hiri motu" },
        };
    }

    ///<summary>
    /// The class definition for language of Croatian
    ///</summary>
    public class Croatian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "hr";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "hrv";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Croatian" }, // Default to English as language name
            { "fr", "croate" },
        };
    }

    ///<summary>
    /// The class definition for language of Hungarian
    ///</summary>
    public class Hungarian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "hu";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "hun";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Hungarian" }, // Default to English as language name
            { "fr", "hongrois" },
        };
    }

    ///<summary>
    /// The class definition for language of Igbo
    ///</summary>
    public class Igbo : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ig";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ibo";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Igbo" }, // Default to English as language name
            { "fr", "igbo" },
        };
    }

    ///<summary>
    /// The class definition for language of Icelandic
    ///</summary>
    public class Icelandic : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "is";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ice";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Icelandic" }, // Default to English as language name
            { "fr", "islandais" },
        };
    }

    ///<summary>
    /// The class definition for language of Ido
    ///</summary>
    public class Ido : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "io";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ido";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ido" }, // Default to English as language name
            { "fr", "ido" },
        };
    }

    ///<summary>
    /// The class definition for language of Sichuan Yi
    ///</summary>
    public class SichuanYi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ii";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "iii";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Sichuan Yi" }, // Default to English as language name
            { "fr", "Nuosu" },
        };
    }

    ///<summary>
    /// The class definition for language of Inuktitut
    ///</summary>
    public class Inuktitut : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "iu";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "iku";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Inuktitut" }, // Default to English as language name
            { "fr", "inuktitut" },
        };
    }

    ///<summary>
    /// The class definition for language of Interlingue
    ///</summary>
    public class Interlingue : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ie";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ile";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Interlingue" }, // Default to English as language name
            { "fr", "Occidental" },
        };
    }

    ///<summary>
    /// The class definition for language of Interlingua (International Auxiliary Language Association)
    ///</summary>
    public class Interlingua : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ia";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ina";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Interlingua (International Auxiliary Language Association)" }, // Default to English as language name
            { "fr", "interlingua (langue auxiliaire internationale)" },
        };
    }

    ///<summary>
    /// The class definition for language of Indonesian
    ///</summary>
    public class Indonesian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "id";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ind";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Indonesian" }, // Default to English as language name
            { "fr", "indonésien" },
        };
    }

    ///<summary>
    /// The class definition for language of Inupiaq
    ///</summary>
    public class Inupiaq : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ik";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ipk";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Inupiaq" }, // Default to English as language name
            { "fr", "inupiaq" },
        };
    }

    ///<summary>
    /// The class definition for language of Italian
    ///</summary>
    public class Italian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "it";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ita";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Italian" }, // Default to English as language name
            { "fr", "italien" },
        };
    }

    ///<summary>
    /// The class definition for language of Javanese
    ///</summary>
    public class Javanese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "jv";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "jav";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Javanese" }, // Default to English as language name
            { "fr", "javanais" },
        };
    }

    ///<summary>
    /// The class definition for language of Japanese
    ///</summary>
    public class Japanese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ja";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "jpn";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Japanese" }, // Default to English as language name
            { "fr", "japonais" },
        };
    }

    ///<summary>
    /// The class definition for language of Kalaallisut
    ///</summary>
    public class Kalaallisut : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "kl";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kal";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kalaallisut" }, // Default to English as language name
            { "fr", "Greenlandic" },
        };
    }

    ///<summary>
    /// The class definition for language of Kannada
    ///</summary>
    public class Kannada : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "kn";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kan";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kannada" }, // Default to English as language name
            { "fr", "kannada" },
        };
    }

    ///<summary>
    /// The class definition for language of Kashmiri
    ///</summary>
    public class Kashmiri : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ks";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kas";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kashmiri" }, // Default to English as language name
            { "fr", "kashmiri" },
        };
    }

    ///<summary>
    /// The class definition for language of Kanuri
    ///</summary>
    public class Kanuri : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "kr";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kau";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kanuri" }, // Default to English as language name
            { "fr", "kanouri" },
        };
    }

    ///<summary>
    /// The class definition for language of Kazakh
    ///</summary>
    public class Kazakh : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "kk";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kaz";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kazakh" }, // Default to English as language name
            { "fr", "kazakh" },
        };
    }

    ///<summary>
    /// The class definition for language of Central Khmer
    ///</summary>
    public class CentralKhmer : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "km";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "khm";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Central Khmer" }, // Default to English as language name
            { "fr", "khmer central" },
        };
    }

    ///<summary>
    /// The class definition for language of Kikuyu
    ///</summary>
    public class Kikuyu : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ki";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kik";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kikuyu" }, // Default to English as language name
            { "fr", "Gikuyu" },
        };
    }

    ///<summary>
    /// The class definition for language of Kinyarwanda
    ///</summary>
    public class Kinyarwanda : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "rw";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kin";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kinyarwanda" }, // Default to English as language name
            { "fr", "rwanda" },
        };
    }

    ///<summary>
    /// The class definition for language of Kirghiz
    ///</summary>
    public class Kirghiz : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ky";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kir";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kirghiz" }, // Default to English as language name
            { "fr", "Kyrgyz" },
        };
    }

    ///<summary>
    /// The class definition for language of Komi
    ///</summary>
    public class Komi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "kv";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kom";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Komi" }, // Default to English as language name
            { "fr", "kom" },
        };
    }

    ///<summary>
    /// The class definition for language of Kongo
    ///</summary>
    public class Kongo : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "kg";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kon";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kongo" }, // Default to English as language name
            { "fr", "kongo" },
        };
    }

    ///<summary>
    /// The class definition for language of Korean
    ///</summary>
    public class Korean : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ko";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kor";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Korean" }, // Default to English as language name
            { "fr", "coréen" },
        };
    }

    ///<summary>
    /// The class definition for language of Kuanyama
    ///</summary>
    public class Kuanyama : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "kj";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kua";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kuanyama" }, // Default to English as language name
            { "fr", "Kwanyama" },
        };
    }

    ///<summary>
    /// The class definition for language of Kurdish
    ///</summary>
    public class Kurdish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ku";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "kur";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Kurdish" }, // Default to English as language name
            { "fr", "kurde" },
        };
    }

    ///<summary>
    /// The class definition for language of Lao
    ///</summary>
    public class Lao : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "lo";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "lao";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Lao" }, // Default to English as language name
            { "fr", "lao" },
        };
    }

    ///<summary>
    /// The class definition for language of Latin
    ///</summary>
    public class Latin : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "la";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "lat";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Latin" }, // Default to English as language name
            { "fr", "latin" },
        };
    }

    ///<summary>
    /// The class definition for language of Latvian
    ///</summary>
    public class Latvian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "lv";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "lav";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Latvian" }, // Default to English as language name
            { "fr", "letton" },
        };
    }

    ///<summary>
    /// The class definition for language of Limburgan
    ///</summary>
    public class Limburgan : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "li";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "lim";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Limburgan" }, // Default to English as language name
            { "fr", "Limburger" },
        };
    }

    ///<summary>
    /// The class definition for language of Lingala
    ///</summary>
    public class Lingala : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ln";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "lin";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Lingala" }, // Default to English as language name
            { "fr", "lingala" },
        };
    }

    ///<summary>
    /// The class definition for language of Lithuanian
    ///</summary>
    public class Lithuanian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "lt";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "lit";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Lithuanian" }, // Default to English as language name
            { "fr", "lituanien" },
        };
    }

    ///<summary>
    /// The class definition for language of Luxembourgish
    ///</summary>
    public class Luxembourgish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "lb";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ltz";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Luxembourgish" }, // Default to English as language name
            { "fr", "Letzeburgesch" },
        };
    }

    ///<summary>
    /// The class definition for language of Luba-Katanga
    ///</summary>
    public class LubaKatanga : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "lu";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "lub";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Luba-Katanga" }, // Default to English as language name
            { "fr", "luba-katanga" },
        };
    }

    ///<summary>
    /// The class definition for language of Ganda
    ///</summary>
    public class Ganda : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "lg";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "lug";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ganda" }, // Default to English as language name
            { "fr", "ganda" },
        };
    }

    ///<summary>
    /// The class definition for language of Macedonian
    ///</summary>
    public class Macedonian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "mk";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "mac";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Macedonian" }, // Default to English as language name
            { "fr", "macédonien" },
        };
    }

    ///<summary>
    /// The class definition for language of Marshallese
    ///</summary>
    public class Marshallese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "mh";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "mah";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Marshallese" }, // Default to English as language name
            { "fr", "marshall" },
        };
    }

    ///<summary>
    /// The class definition for language of Malayalam
    ///</summary>
    public class Malayalam : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ml";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "mal";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Malayalam" }, // Default to English as language name
            { "fr", "malayalam" },
        };
    }

    ///<summary>
    /// The class definition for language of Maori
    ///</summary>
    public class Maori : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "mi";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "mao";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Maori" }, // Default to English as language name
            { "fr", "maori" },
        };
    }

    ///<summary>
    /// The class definition for language of Marathi
    ///</summary>
    public class Marathi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "mr";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "mar";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Marathi" }, // Default to English as language name
            { "fr", "marathe" },
        };
    }

    ///<summary>
    /// The class definition for language of Malay
    ///</summary>
    public class Malay : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ms";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "may";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Malay" }, // Default to English as language name
            { "fr", "malais" },
        };
    }

    ///<summary>
    /// The class definition for language of Malagasy
    ///</summary>
    public class Malagasy : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "mg";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "mlg";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Malagasy" }, // Default to English as language name
            { "fr", "malgache" },
        };
    }

    ///<summary>
    /// The class definition for language of Maltese
    ///</summary>
    public class Maltese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "mt";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "mlt";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Maltese" }, // Default to English as language name
            { "fr", "maltais" },
        };
    }

    ///<summary>
    /// The class definition for language of Mongolian
    ///</summary>
    public class Mongolian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "mn";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "mon";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Mongolian" }, // Default to English as language name
            { "fr", "mongol" },
        };
    }

    ///<summary>
    /// The class definition for language of Nauru
    ///</summary>
    public class Nauru : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "na";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nau";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Nauru" }, // Default to English as language name
            { "fr", "nauruan" },
        };
    }

    ///<summary>
    /// The class definition for language of Navajo
    ///</summary>
    public class Navajo : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "nv";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nav";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Navajo" }, // Default to English as language name
            { "fr", "Navaho" },
        };
    }

    ///<summary>
    /// The class definition for language of Ndebele, South
    ///</summary>
    public class Ndebele_nbl : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "nr";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nbl";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ndebele, South" }, // Default to English as language name
            { "fr", "South Ndebele" },
        };
    }

    ///<summary>
    /// The class definition for language of Ndebele, North
    ///</summary>
    public class Ndebele_nde : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "nd";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nde";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ndebele, North" }, // Default to English as language name
            { "fr", "North Ndebele" },
        };
    }

    ///<summary>
    /// The class definition for language of Ndonga
    ///</summary>
    public class Ndonga : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ng";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ndo";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ndonga" }, // Default to English as language name
            { "fr", "ndonga" },
        };
    }

    ///<summary>
    /// The class definition for language of Nepali
    ///</summary>
    public class Nepali : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ne";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nep";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Nepali" }, // Default to English as language name
            { "fr", "népalais" },
        };
    }

    ///<summary>
    /// The class definition for language of Norwegian Nynorsk
    ///</summary>
    public class NorwegianNynorsk : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "nn";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nno";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Norwegian Nynorsk" }, // Default to English as language name
            { "fr", "Nynorsk, Norwegian" },
        };
    }

    ///<summary>
    /// The class definition for language of Bokmål, Norwegian
    ///</summary>
    public class Bokmål : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "nb";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nob";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Bokmål, Norwegian" }, // Default to English as language name
            { "fr", "Norwegian Bokmål" },
        };
    }

    ///<summary>
    /// The class definition for language of Norwegian
    ///</summary>
    public class Norwegian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "no";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nor";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Norwegian" }, // Default to English as language name
            { "fr", "norvégien" },
        };
    }

    ///<summary>
    /// The class definition for language of Chichewa
    ///</summary>
    public class Chichewa : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ny";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "nya";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Chichewa" }, // Default to English as language name
            { "fr", "Chewa" },
        };
    }

    ///<summary>
    /// The class definition for language of Occitan (post 1500)
    ///</summary>
    public class Occitan : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "oc";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "oci";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Occitan (post 1500)" }, // Default to English as language name
            { "fr", "occitan (après 1500)" },
        };
    }

    ///<summary>
    /// The class definition for language of Ojibwa
    ///</summary>
    public class Ojibwa : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "oj";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "oji";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ojibwa" }, // Default to English as language name
            { "fr", "ojibwa" },
        };
    }

    ///<summary>
    /// The class definition for language of Oriya
    ///</summary>
    public class Oriya : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "or";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ori";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Oriya" }, // Default to English as language name
            { "fr", "oriya" },
        };
    }

    ///<summary>
    /// The class definition for language of Oromo
    ///</summary>
    public class Oromo : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "om";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "orm";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Oromo" }, // Default to English as language name
            { "fr", "galla" },
        };
    }

    ///<summary>
    /// The class definition for language of Ossetian
    ///</summary>
    public class Ossetian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "os";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "oss";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ossetian" }, // Default to English as language name
            { "fr", "Ossetic" },
        };
    }

    ///<summary>
    /// The class definition for language of Panjabi
    ///</summary>
    public class Panjabi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "pa";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "pan";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Panjabi" }, // Default to English as language name
            { "fr", "Punjabi" },
        };
    }

    ///<summary>
    /// The class definition for language of Persian
    ///</summary>
    public class Persian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "fa";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "per";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Persian" }, // Default to English as language name
            { "fr", "persan" },
        };
    }

    ///<summary>
    /// The class definition for language of Pali
    ///</summary>
    public class Pali : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "pi";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "pli";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Pali" }, // Default to English as language name
            { "fr", "pali" },
        };
    }

    ///<summary>
    /// The class definition for language of Polish
    ///</summary>
    public class Polish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "pl";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "pol";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Polish" }, // Default to English as language name
            { "fr", "polonais" },
        };
    }

    ///<summary>
    /// The class definition for language of Portuguese
    ///</summary>
    public class Portuguese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "pt";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "por";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Portuguese" }, // Default to English as language name
            { "fr", "portugais" },
        };
    }

    ///<summary>
    /// The class definition for language of Pushto
    ///</summary>
    public class Pushto : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ps";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "pus";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Pushto" }, // Default to English as language name
            { "fr", "Pashto" },
        };
    }

    ///<summary>
    /// The class definition for language of Quechua
    ///</summary>
    public class Quechua : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "qu";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "que";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Quechua" }, // Default to English as language name
            { "fr", "quechua" },
        };
    }

    ///<summary>
    /// The class definition for language of Romansh
    ///</summary>
    public class Romansh : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "rm";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "roh";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Romansh" }, // Default to English as language name
            { "fr", "romanche" },
        };
    }

    ///<summary>
    /// The class definition for language of Romanian
    ///</summary>
    public class Romanian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ro";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "rum";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Romanian" }, // Default to English as language name
            { "fr", "Moldavian" },
        };
    }

    ///<summary>
    /// The class definition for language of Rundi
    ///</summary>
    public class Rundi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "rn";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "run";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Rundi" }, // Default to English as language name
            { "fr", "rundi" },
        };
    }

    ///<summary>
    /// The class definition for language of Russian
    ///</summary>
    public class Russian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ru";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "rus";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Russian" }, // Default to English as language name
            { "fr", "russe" },
        };
    }

    ///<summary>
    /// The class definition for language of Sango
    ///</summary>
    public class Sango : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sg";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "sag";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Sango" }, // Default to English as language name
            { "fr", "sango" },
        };
    }

    ///<summary>
    /// The class definition for language of Sanskrit
    ///</summary>
    public class Sanskrit : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sa";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "san";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Sanskrit" }, // Default to English as language name
            { "fr", "sanskrit" },
        };
    }

    ///<summary>
    /// The class definition for language of Sinhala
    ///</summary>
    public class Sinhala : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "si";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "sin";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Sinhala" }, // Default to English as language name
            { "fr", "Sinhalese" },
        };
    }

    ///<summary>
    /// The class definition for language of Slovak
    ///</summary>
    public class Slovak : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sk";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "slo";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Slovak" }, // Default to English as language name
            { "fr", "slovaque" },
        };
    }

    ///<summary>
    /// The class definition for language of Slovenian
    ///</summary>
    public class Slovenian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sl";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "slv";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Slovenian" }, // Default to English as language name
            { "fr", "slovène" },
        };
    }

    ///<summary>
    /// The class definition for language of Northern Sami
    ///</summary>
    public class NorthernSami : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "se";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "sme";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Northern Sami" }, // Default to English as language name
            { "fr", "sami du Nord" },
        };
    }

    ///<summary>
    /// The class definition for language of Samoan
    ///</summary>
    public class Samoan : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sm";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "smo";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Samoan" }, // Default to English as language name
            { "fr", "samoan" },
        };
    }

    ///<summary>
    /// The class definition for language of Shona
    ///</summary>
    public class Shona : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sn";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "sna";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Shona" }, // Default to English as language name
            { "fr", "shona" },
        };
    }

    ///<summary>
    /// The class definition for language of Sindhi
    ///</summary>
    public class Sindhi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sd";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "snd";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Sindhi" }, // Default to English as language name
            { "fr", "sindhi" },
        };
    }

    ///<summary>
    /// The class definition for language of Somali
    ///</summary>
    public class Somali : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "so";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "som";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Somali" }, // Default to English as language name
            { "fr", "somali" },
        };
    }

    ///<summary>
    /// The class definition for language of Sotho, Southern
    ///</summary>
    public class Sotho : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "st";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "sot";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Sotho, Southern" }, // Default to English as language name
            { "fr", "sotho du Sud" },
        };
    }

    ///<summary>
    /// The class definition for language of Spanish
    ///</summary>
    public class Spanish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "es";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "spa";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Spanish" }, // Default to English as language name
            { "fr", "Castilian" },
        };
    }

    ///<summary>
    /// The class definition for language of Sardinian
    ///</summary>
    public class Sardinian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sc";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "srd";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Sardinian" }, // Default to English as language name
            { "fr", "sarde" },
        };
    }

    ///<summary>
    /// The class definition for language of Serbian
    ///</summary>
    public class Serbian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sr";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "srp";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Serbian" }, // Default to English as language name
            { "fr", "serbe" },
        };
    }

    ///<summary>
    /// The class definition for language of Swati
    ///</summary>
    public class Swati : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ss";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ssw";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Swati" }, // Default to English as language name
            { "fr", "swati" },
        };
    }

    ///<summary>
    /// The class definition for language of Sundanese
    ///</summary>
    public class Sundanese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "su";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "sun";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Sundanese" }, // Default to English as language name
            { "fr", "soundanais" },
        };
    }

    ///<summary>
    /// The class definition for language of Swahili
    ///</summary>
    public class Swahili : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sw";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "swa";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Swahili" }, // Default to English as language name
            { "fr", "swahili" },
        };
    }

    ///<summary>
    /// The class definition for language of Swedish
    ///</summary>
    public class Swedish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "sv";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "swe";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Swedish" }, // Default to English as language name
            { "fr", "suédois" },
        };
    }

    ///<summary>
    /// The class definition for language of Tahitian
    ///</summary>
    public class Tahitian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ty";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tah";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tahitian" }, // Default to English as language name
            { "fr", "tahitien" },
        };
    }

    ///<summary>
    /// The class definition for language of Tamil
    ///</summary>
    public class Tamil : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ta";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tam";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tamil" }, // Default to English as language name
            { "fr", "tamoul" },
        };
    }

    ///<summary>
    /// The class definition for language of Tatar
    ///</summary>
    public class Tatar : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "tt";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tat";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tatar" }, // Default to English as language name
            { "fr", "tatar" },
        };
    }

    ///<summary>
    /// The class definition for language of Telugu
    ///</summary>
    public class Telugu : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "te";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tel";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Telugu" }, // Default to English as language name
            { "fr", "télougou" },
        };
    }

    ///<summary>
    /// The class definition for language of Tajik
    ///</summary>
    public class Tajik : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "tg";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tgk";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tajik" }, // Default to English as language name
            { "fr", "tadjik" },
        };
    }

    ///<summary>
    /// The class definition for language of Tagalog
    ///</summary>
    public class Tagalog : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "tl";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tgl";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tagalog" }, // Default to English as language name
            { "fr", "tagalog" },
        };
    }

    ///<summary>
    /// The class definition for language of Thai
    ///</summary>
    public class Thai : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "th";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tha";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Thai" }, // Default to English as language name
            { "fr", "thaï" },
        };
    }

    ///<summary>
    /// The class definition for language of Tibetan
    ///</summary>
    public class Tibetan : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "bo";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tib";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tibetan" }, // Default to English as language name
            { "fr", "tibétain" },
        };
    }

    ///<summary>
    /// The class definition for language of Tigrinya
    ///</summary>
    public class Tigrinya : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ti";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tir";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tigrinya" }, // Default to English as language name
            { "fr", "tigrigna" },
        };
    }

    ///<summary>
    /// The class definition for language of Tonga (Tonga Islands)
    ///</summary>
    public class Tonga : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "to";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ton";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tonga (Tonga Islands)" }, // Default to English as language name
            { "fr", "tongan (Îles Tonga)" },
        };
    }

    ///<summary>
    /// The class definition for language of Tswana
    ///</summary>
    public class Tswana : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "tn";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tsn";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tswana" }, // Default to English as language name
            { "fr", "tswana" },
        };
    }

    ///<summary>
    /// The class definition for language of Tsonga
    ///</summary>
    public class Tsonga : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ts";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tso";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Tsonga" }, // Default to English as language name
            { "fr", "tsonga" },
        };
    }

    ///<summary>
    /// The class definition for language of Turkmen
    ///</summary>
    public class Turkmen : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "tk";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tuk";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Turkmen" }, // Default to English as language name
            { "fr", "turkmène" },
        };
    }

    ///<summary>
    /// The class definition for language of Turkish
    ///</summary>
    public class Turkish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "tr";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "tur";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Turkish" }, // Default to English as language name
            { "fr", "turc" },
        };
    }

    ///<summary>
    /// The class definition for language of Twi
    ///</summary>
    public class Twi : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "tw";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "twi";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Twi" }, // Default to English as language name
            { "fr", "twi" },
        };
    }

    ///<summary>
    /// The class definition for language of Uighur
    ///</summary>
    public class Uighur : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ug";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "uig";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Uighur" }, // Default to English as language name
            { "fr", "Uyghur" },
        };
    }

    ///<summary>
    /// The class definition for language of Ukrainian
    ///</summary>
    public class Ukrainian : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "uk";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ukr";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Ukrainian" }, // Default to English as language name
            { "fr", "ukrainien" },
        };
    }

    ///<summary>
    /// The class definition for language of Urdu
    ///</summary>
    public class Urdu : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ur";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "urd";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Urdu" }, // Default to English as language name
            { "fr", "ourdou" },
        };
    }

    ///<summary>
    /// The class definition for language of Uzbek
    ///</summary>
    public class Uzbek : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "uz";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "uzb";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Uzbek" }, // Default to English as language name
            { "fr", "ouszbek" },
        };
    }

    ///<summary>
    /// The class definition for language of Venda
    ///</summary>
    public class Venda : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ve";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ven";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Venda" }, // Default to English as language name
            { "fr", "venda" },
        };
    }

    ///<summary>
    /// The class definition for language of Vietnamese
    ///</summary>
    public class Vietnamese : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "vi";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "vie";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Vietnamese" }, // Default to English as language name
            { "fr", "vietnamien" },
        };
    }

    ///<summary>
    /// The class definition for language of Volapük
    ///</summary>
    public class Volapük : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "vo";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "vol";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Volapük" }, // Default to English as language name
            { "fr", "volapük" },
        };
    }

    ///<summary>
    /// The class definition for language of Welsh
    ///</summary>
    public class Welsh : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "cy";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "wel";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Welsh" }, // Default to English as language name
            { "fr", "gallois" },
        };
    }

    ///<summary>
    /// The class definition for language of Walloon
    ///</summary>
    public class Walloon : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "wa";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "wln";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Walloon" }, // Default to English as language name
            { "fr", "wallon" },
        };
    }

    ///<summary>
    /// The class definition for language of Wolof
    ///</summary>
    public class Wolof : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "wo";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "wol";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Wolof" }, // Default to English as language name
            { "fr", "wolof" },
        };
    }

    ///<summary>
    /// The class definition for language of Xhosa
    ///</summary>
    public class Xhosa : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "xh";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "xho";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Xhosa" }, // Default to English as language name
            { "fr", "xhosa" },
        };
    }

    ///<summary>
    /// The class definition for language of Yiddish
    ///</summary>
    public class Yiddish : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "yi";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "yid";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Yiddish" }, // Default to English as language name
            { "fr", "yiddish" },
        };
    }

    ///<summary>
    /// The class definition for language of Yoruba
    ///</summary>
    public class Yoruba : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "yo";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "yor";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Yoruba" }, // Default to English as language name
            { "fr", "yoruba" },
        };
    }

    ///<summary>
    /// The class definition for language of Zhuang
    ///</summary>
    public class Zhuang : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "za";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "zha";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Zhuang" }, // Default to English as language name
            { "fr", "Chuang" },
        };
    }

    ///<summary>
    /// The class definition for language of Zulu
    ///</summary>
    public class Zulu : Language
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "zu";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "zul";
    
        /// <inheritDoc />
        public override Dictionary<string, string> LanguageNames => new()
        {
            { "en", "Zulu" }, // Default to English as language name
            { "fr", "zoulou" },
        };
    }
}