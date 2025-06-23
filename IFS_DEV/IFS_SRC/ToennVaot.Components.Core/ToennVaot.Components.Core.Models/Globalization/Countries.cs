
using System.Diagnostics.CodeAnalysis;

namespace ToennVaot.Components.Core.Models.Countries
{
    ///<summary>
    /// The base class definition for country
    ///</summary>
    public abstract class Country
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
        /// ISO-3166 numeric code
        ///</summary>
        public abstract int IsoCodeId { get; }
    
        ///<summary>
        /// ISO-3166 region name
        ///</summary>
        public abstract RegionsEnum RegionName { get; }
    
        ///<summary>
        /// ISO-3166 top-level domain
        ///</summary>
        public abstract string TopLevelDomain { get; }
    
        ///<summary>
        /// The country name per language
        ///</summary>
        [SuppressMessage("ReSharper", "StringLiteralTypo")]
        public abstract Dictionary<string, string> CountryNames { get; }
    }


    ///<summary>
    /// The class definition for country of Afghanistan
    ///</summary>
    public class Afghanistan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "AFG";
    
        /// <inheritDoc />
        public override int IsoCodeId => 4;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Afghanistan" }, // Default to English as country name
            { "cn", "阿富汗" },
            { "ru", "Афганистан" },
            { "fr", "Afghanistan" },
            { "es", "Afganistán" },
            { "ar", "أفغانستان" },
        };
    }

    ///<summary>
    /// The class definition for country of Åland Islands
    ///</summary>
    public class ÅlandIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AX";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ALA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 248;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Åland Islands" }, // Default to English as country name
            { "cn", "奥兰群岛" },
            { "ru", "Аландских островов" },
            { "fr", "Îles d’Åland" },
            { "es", "Islas Åland" },
            { "ar", "جزر ألاند" },
        };
    }

    ///<summary>
    /// The class definition for country of Albania
    ///</summary>
    public class Albania : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ALB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 8;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Albania" }, // Default to English as country name
            { "cn", "阿尔巴尼亚" },
            { "ru", "Албания" },
            { "fr", "Albanie" },
            { "es", "Albania" },
            { "ar", "ألبانيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Algeria
    ///</summary>
    public class Algeria : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "DZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "DZA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 12;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Algeria" }, // Default to English as country name
            { "cn", "阿尔及利亚" },
            { "ru", "Алжир" },
            { "fr", "Algérie" },
            { "es", "Argelia" },
            { "ar", "الجزائر" },
        };
    }

    ///<summary>
    /// The class definition for country of American Samoa
    ///</summary>
    public class AmericanSamoa : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ASM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 16;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "American Samoa" }, // Default to English as country name
            { "cn", "美属萨摩亚" },
            { "ru", "Американское Самоа" },
            { "fr", "Samoa américaines" },
            { "es", "Samoa Americana" },
            { "ar", "ساموا الأمريكية" },
        };
    }

    ///<summary>
    /// The class definition for country of Andorra
    ///</summary>
    public class Andorra : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AD";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "AND";
    
        /// <inheritDoc />
        public override int IsoCodeId => 20;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Andorra" }, // Default to English as country name
            { "cn", "安道尔" },
            { "ru", "Андорра" },
            { "fr", "Andorre" },
            { "es", "Andorra" },
            { "ar", "أندورا" },
        };
    }

    ///<summary>
    /// The class definition for country of Angola
    ///</summary>
    public class Angola : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "AGO";
    
        /// <inheritDoc />
        public override int IsoCodeId => 24;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Angola" }, // Default to English as country name
            { "cn", "安哥拉" },
            { "ru", "Ангола" },
            { "fr", "Angola" },
            { "es", "Angola" },
            { "ar", "أنغولا" },
        };
    }

    ///<summary>
    /// The class definition for country of Anguilla
    ///</summary>
    public class Anguilla : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "AIA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 660;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Anguilla" }, // Default to English as country name
            { "cn", "安圭拉" },
            { "ru", "Ангилья" },
            { "fr", "Anguilla" },
            { "es", "Anguila" },
            { "ar", "أنغويلا" },
        };
    }

    ///<summary>
    /// The class definition for country of Antarctica
    ///</summary>
    public class Antarctica : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AQ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ATA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 10;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Unknown;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AN";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Antarctica" }, // Default to English as country name
            { "cn", "南极洲" },
            { "ru", "Антарктике" },
            { "fr", "Antarctique" },
            { "es", "Antártida" },
            { "ar", "أنتاركتيكا" },
        };
    }

    ///<summary>
    /// The class definition for country of Antigua and Barbuda
    ///</summary>
    public class AntiguaAndBarbuda : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ATG";
    
        /// <inheritDoc />
        public override int IsoCodeId => 28;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Antigua and Barbuda" }, // Default to English as country name
            { "cn", "安提瓜和巴布达" },
            { "ru", "Антигуа и Барбуда" },
            { "fr", "Antigua-et-Barbuda" },
            { "es", "Antigua y Barbuda" },
            { "ar", "أنتيغوا وبربودا" },
        };
    }

    ///<summary>
    /// The class definition for country of Argentina
    ///</summary>
    public class Argentina : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ARG";
    
        /// <inheritDoc />
        public override int IsoCodeId => 32;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Argentina" }, // Default to English as country name
            { "cn", "阿根廷" },
            { "ru", "Аргентина" },
            { "fr", "Argentine" },
            { "es", "Argentina" },
            { "ar", "الأرجنتين" },
        };
    }

    ///<summary>
    /// The class definition for country of Armenia
    ///</summary>
    public class Armenia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ARM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 51;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Armenia" }, // Default to English as country name
            { "cn", "亚美尼亚" },
            { "ru", "Армения" },
            { "fr", "Arménie" },
            { "es", "Armenia" },
            { "ar", "أرمينيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Aruba
    ///</summary>
    public class Aruba : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ABW";
    
        /// <inheritDoc />
        public override int IsoCodeId => 533;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Aruba" }, // Default to English as country name
            { "cn", "阿鲁巴" },
            { "ru", "Аруба" },
            { "fr", "Aruba" },
            { "es", "Aruba" },
            { "ar", "أروبا" },
        };
    }

    ///<summary>
    /// The class definition for country of Australia
    ///</summary>
    public class Australia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "AUS";
    
        /// <inheritDoc />
        public override int IsoCodeId => 36;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Australia" }, // Default to English as country name
            { "cn", "澳大利亚" },
            { "ru", "Австралия" },
            { "fr", "Australie" },
            { "es", "Australia" },
            { "ar", "أستراليا" },
        };
    }

    ///<summary>
    /// The class definition for country of Austria
    ///</summary>
    public class Austria : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "AUT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 40;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Austria" }, // Default to English as country name
            { "cn", "奥地利" },
            { "ru", "Австрия" },
            { "fr", "Autriche" },
            { "es", "Austria" },
            { "ar", "النمسا" },
        };
    }

    ///<summary>
    /// The class definition for country of Azerbaijan
    ///</summary>
    public class Azerbaijan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "AZE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 31;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Azerbaijan" }, // Default to English as country name
            { "cn", "阿塞拜疆" },
            { "ru", "Азербайджан" },
            { "fr", "Azerbaïdjan" },
            { "es", "Azerbaiyán" },
            { "ar", "أذربيجان" },
        };
    }

    ///<summary>
    /// The class definition for country of Bahamas
    ///</summary>
    public class Bahamas : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BHS";
    
        /// <inheritDoc />
        public override int IsoCodeId => 44;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bahamas" }, // Default to English as country name
            { "cn", "巴哈马" },
            { "ru", "Багамские Острова" },
            { "fr", "Bahamas" },
            { "es", "Bahamas" },
            { "ar", "جزر البهاما" },
        };
    }

    ///<summary>
    /// The class definition for country of Bahrain
    ///</summary>
    public class Bahrain : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BHR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 48;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bahrain" }, // Default to English as country name
            { "cn", "巴林" },
            { "ru", "Бахрейн" },
            { "fr", "Bahreïn" },
            { "es", "Bahrein" },
            { "ar", "البحرين" },
        };
    }

    ///<summary>
    /// The class definition for country of Bangladesh
    ///</summary>
    public class Bangladesh : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BD";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BGD";
    
        /// <inheritDoc />
        public override int IsoCodeId => 50;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bangladesh" }, // Default to English as country name
            { "cn", "孟加拉国" },
            { "ru", "Бангладеш" },
            { "fr", "Bangladesh" },
            { "es", "Bangladesh" },
            { "ar", "بنغلاديش" },
        };
    }

    ///<summary>
    /// The class definition for country of Barbados
    ///</summary>
    public class Barbados : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BB";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BRB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 52;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Barbados" }, // Default to English as country name
            { "cn", "巴巴多斯" },
            { "ru", "Барбадос" },
            { "fr", "Barbade" },
            { "es", "Barbados" },
            { "ar", "بربادوس" },
        };
    }

    ///<summary>
    /// The class definition for country of Belarus
    ///</summary>
    public class Belarus : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BLR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 112;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Belarus" }, // Default to English as country name
            { "cn", "白俄罗斯" },
            { "ru", "Беларусь" },
            { "fr", "Bélarus" },
            { "es", "Belarús" },
            { "ar", "بيلاروس" },
        };
    }

    ///<summary>
    /// The class definition for country of Belgium
    ///</summary>
    public class Belgium : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BEL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 56;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Belgium" }, // Default to English as country name
            { "cn", "比利时" },
            { "ru", "Бельгия" },
            { "fr", "Belgique" },
            { "es", "Bélgica" },
            { "ar", "بلجيكا" },
        };
    }

    ///<summary>
    /// The class definition for country of Belize
    ///</summary>
    public class Belize : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BLZ";
    
        /// <inheritDoc />
        public override int IsoCodeId => 84;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Belize" }, // Default to English as country name
            { "cn", "伯利兹" },
            { "ru", "Белиз" },
            { "fr", "Belize" },
            { "es", "Belice" },
            { "ar", "بليز" },
        };
    }

    ///<summary>
    /// The class definition for country of Benin
    ///</summary>
    public class Benin : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BJ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BEN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 204;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Benin" }, // Default to English as country name
            { "cn", "贝宁" },
            { "ru", "Бенин" },
            { "fr", "Bénin" },
            { "es", "Benin" },
            { "ar", "بنن" },
        };
    }

    ///<summary>
    /// The class definition for country of Bermuda
    ///</summary>
    public class Bermuda : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BMU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 60;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bermuda" }, // Default to English as country name
            { "cn", "百慕大" },
            { "ru", "Бермудские острова" },
            { "fr", "Bermudes" },
            { "es", "Bermuda" },
            { "ar", "برمودا" },
        };
    }

    ///<summary>
    /// The class definition for country of Bhutan
    ///</summary>
    public class Bhutan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BTN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 64;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bhutan" }, // Default to English as country name
            { "cn", "不丹" },
            { "ru", "Бутан" },
            { "fr", "Bhoutan" },
            { "es", "Bhután" },
            { "ar", "بوتان" },
        };
    }

    ///<summary>
    /// The class definition for country of Bolivia (Plurinational State of)
    ///</summary>
    public class Bolivia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BOL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 68;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bolivia (Plurinational State of)" }, // Default to English as country name
            { "cn", "多民族玻利维亚国" },
            { "ru", "Боливия (Многонациональное Государство)" },
            { "fr", "Bolivie (État plurinational de)" },
            { "es", "Bolivia (Estado Plurinacional de)" },
            { "ar", "بوليفيا (دولة - المتعددة القوميات)" },
        };
    }

    ///<summary>
    /// The class definition for country of Bonaire, Sint Eustatius and Saba
    ///</summary>
    public class Bonaire : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BQ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BES";
    
        /// <inheritDoc />
        public override int IsoCodeId => 535;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bonaire, Sint Eustatius and Saba" }, // Default to English as country name
            { "cn", "博纳尔，圣俄斯塔休斯和萨巴" },
            { "ru", "Бонайре, Синт-Эстатиус и Саба" },
            { "fr", "Bonaire, Saint-Eustache et Saba" },
            { "es", "Bonaire, San Eustaquio y Saba" },
            { "ar", "بونير وسانت يوستاشيوس وسابا" },
        };
    }

    ///<summary>
    /// The class definition for country of Bosnia and Herzegovina
    ///</summary>
    public class BosniaAndHerzegovina : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BIH";
    
        /// <inheritDoc />
        public override int IsoCodeId => 70;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bosnia and Herzegovina" }, // Default to English as country name
            { "cn", "波斯尼亚和黑塞哥维那" },
            { "ru", "Босния и Герцеговина" },
            { "fr", "Bosnie-Herzégovine" },
            { "es", "Bosnia y Herzegovina" },
            { "ar", "البوسنة والهرسك" },
        };
    }

    ///<summary>
    /// The class definition for country of Botswana
    ///</summary>
    public class Botswana : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BWA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 72;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Botswana" }, // Default to English as country name
            { "cn", "博茨瓦纳" },
            { "ru", "Ботсвана" },
            { "fr", "Botswana" },
            { "es", "Botswana" },
            { "ar", "بوتسوانا" },
        };
    }

    ///<summary>
    /// The class definition for country of Bouvet Island
    ///</summary>
    public class BouvetIsland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BV";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BVT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 74;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AN";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bouvet Island" }, // Default to English as country name
            { "cn", "布维岛" },
            { "ru", "Остров Буве" },
            { "fr", "Île Bouvet" },
            { "es", "Isla Bouvet" },
            { "ar", "جزيرة بوفيت" },
        };
    }

    ///<summary>
    /// The class definition for country of Brazil
    ///</summary>
    public class Brazil : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BRA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 76;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Brazil" }, // Default to English as country name
            { "cn", "巴西" },
            { "ru", "Бразилия" },
            { "fr", "Brésil" },
            { "es", "Brasil" },
            { "ar", "البرازيل" },
        };
    }

    ///<summary>
    /// The class definition for country of British Indian Ocean Territory
    ///</summary>
    public class BritishIndianOceanTerritory : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "IOT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 86;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "British Indian Ocean Territory" }, // Default to English as country name
            { "cn", "英属印度洋领土" },
            { "ru", "Британская территория в Индийском океане" },
            { "fr", "Territoire britannique de l'océan Indien" },
            { "es", "Territorio Británico del Océano Índico" },
            { "ar", "المحيط الهندي الإقليم البريطاني في" },
        };
    }

    ///<summary>
    /// The class definition for country of British Virgin Islands
    ///</summary>
    public class BritishVirginIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "VG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "VGB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 92;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "British Virgin Islands" }, // Default to English as country name
            { "cn", "英属维尔京群岛" },
            { "ru", "Британские Виргинские острова" },
            { "fr", "Îles Vierges britanniques" },
            { "es", "Islas Vírgenes Británicas" },
            { "ar", "جزر فرجن البريطانية" },
        };
    }

    ///<summary>
    /// The class definition for country of Brunei Darussalam
    ///</summary>
    public class BruneiDarussalam : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BRN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 96;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Brunei Darussalam" }, // Default to English as country name
            { "cn", "文莱达鲁萨兰国" },
            { "ru", "Бруней-Даруссалам" },
            { "fr", "Brunéi Darussalam" },
            { "es", "Brunei Darussalam" },
            { "ar", "بروني دار السلام" },
        };
    }

    ///<summary>
    /// The class definition for country of Bulgaria
    ///</summary>
    public class Bulgaria : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BGR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 100;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Bulgaria" }, // Default to English as country name
            { "cn", "保加利亚" },
            { "ru", "Болгария" },
            { "fr", "Bulgarie" },
            { "es", "Bulgaria" },
            { "ar", "بلغاريا" },
        };
    }

    ///<summary>
    /// The class definition for country of Burkina Faso
    ///</summary>
    public class BurkinaFaso : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BFA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 854;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Burkina Faso" }, // Default to English as country name
            { "cn", "布基纳法索" },
            { "ru", "Буркина-Фасо" },
            { "fr", "Burkina Faso" },
            { "es", "Burkina Faso" },
            { "ar", "بوركينا فاسو" },
        };
    }

    ///<summary>
    /// The class definition for country of Burundi
    ///</summary>
    public class Burundi : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BDI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 108;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Burundi" }, // Default to English as country name
            { "cn", "布隆迪" },
            { "ru", "Бурунди" },
            { "fr", "Burundi" },
            { "es", "Burundi" },
            { "ar", "بوروندي" },
        };
    }

    ///<summary>
    /// The class definition for country of Cabo Verde
    ///</summary>
    public class CaboVerde : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CV";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CPV";
    
        /// <inheritDoc />
        public override int IsoCodeId => 132;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Cabo Verde" }, // Default to English as country name
            { "cn", "佛得角" },
            { "ru", "Кабо-Верде" },
            { "fr", "Cabo Verde" },
            { "es", "Cabo Verde" },
            { "ar", "كابو فيردي" },
        };
    }

    ///<summary>
    /// The class definition for country of Cambodia
    ///</summary>
    public class Cambodia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "KHM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 116;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Cambodia" }, // Default to English as country name
            { "cn", "柬埔寨" },
            { "ru", "Камбоджа" },
            { "fr", "Cambodge" },
            { "es", "Camboya" },
            { "ar", "كمبوديا" },
        };
    }

    ///<summary>
    /// The class definition for country of Cameroon
    ///</summary>
    public class Cameroon : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CMR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 120;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Cameroon" }, // Default to English as country name
            { "cn", "喀麦隆" },
            { "ru", "Камерун" },
            { "fr", "Cameroun" },
            { "es", "Camerún" },
            { "ar", "الكاميرون" },
        };
    }

    ///<summary>
    /// The class definition for country of Canada
    ///</summary>
    public class Canada : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CAN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 124;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Canada" }, // Default to English as country name
            { "cn", "加拿大" },
            { "ru", "Канада" },
            { "fr", "Canada" },
            { "es", "Canadá" },
            { "ar", "كندا" },
        };
    }

    ///<summary>
    /// The class definition for country of Cayman Islands
    ///</summary>
    public class CaymanIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CYM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 136;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Cayman Islands" }, // Default to English as country name
            { "cn", "开曼群岛" },
            { "ru", "Кайман острова" },
            { "fr", "Îles Caïmanes" },
            { "es", "Islas Caimán" },
            { "ar", "جزر كايمان" },
        };
    }

    ///<summary>
    /// The class definition for country of Central African Republic
    ///</summary>
    public class CentralAfricanRepublic : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CAF";
    
        /// <inheritDoc />
        public override int IsoCodeId => 140;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Central African Republic" }, // Default to English as country name
            { "cn", "中非共和国" },
            { "ru", "Центральноафриканская Республика" },
            { "fr", "République centrafricaine" },
            { "es", "República Centroafricana" },
            { "ar", "جمهورية أفريقيا الوسطى" },
        };
    }

    ///<summary>
    /// The class definition for country of Chad
    ///</summary>
    public class Chad : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TD";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TCD";
    
        /// <inheritDoc />
        public override int IsoCodeId => 148;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Chad" }, // Default to English as country name
            { "cn", "乍得" },
            { "ru", "Чад" },
            { "fr", "Tchad" },
            { "es", "Chad" },
            { "ar", "تشاد" },
        };
    }

    ///<summary>
    /// The class definition for country of Chile
    ///</summary>
    public class Chile : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CHL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 152;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Chile" }, // Default to English as country name
            { "cn", "智利" },
            { "ru", "Чили" },
            { "fr", "Chili" },
            { "es", "Chile" },
            { "ar", "شيلي" },
        };
    }

    ///<summary>
    /// The class definition for country of China
    ///</summary>
    public class China : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CHN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 156;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "China" }, // Default to English as country name
            { "cn", "中国" },
            { "ru", "Китай" },
            { "fr", "Chine" },
            { "es", "China" },
            { "ar", "الصين" },
        };
    }

    ///<summary>
    /// The class definition for country of China, Hong Kong Special Administrative Region
    ///</summary>
    public class China_HKG : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "HK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "HKG";
    
        /// <inheritDoc />
        public override int IsoCodeId => 344;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "China, Hong Kong Special Administrative Region" }, // Default to English as country name
            { "cn", "中国香港特别行政区" },
            { "ru", "Китай, Специальный административный район Гонконг" },
            { "fr", "Chine, région administrative spéciale de Hong Kong" },
            { "es", "China, región administrativa especial de Hong Kong" },
            { "ar", "الصين، منطقة هونغ كونغ الإدارية الخاصة" },
        };
    }

    ///<summary>
    /// The class definition for country of China, Macao Special Administrative Region
    ///</summary>
    public class China_MAC : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MAC";
    
        /// <inheritDoc />
        public override int IsoCodeId => 446;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "China, Macao Special Administrative Region" }, // Default to English as country name
            { "cn", "中国澳门特别行政区" },
            { "ru", "Китай, Специальный административный район Макао" },
            { "fr", "Chine, région administrative spéciale de Macao" },
            { "es", "China, región administrativa especial de Macao" },
            { "ar", "الصين، منطقة ماكاو الإدارية الخاصة" },
        };
    }

    ///<summary>
    /// The class definition for country of Christmas Island
    ///</summary>
    public class ChristmasIsland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CX";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CXR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 162;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Christmas Island" }, // Default to English as country name
            { "cn", "圣诞岛" },
            { "ru", "остров Рождества" },
            { "fr", "Île Christmas" },
            { "es", "Isla Christmas" },
            { "ar", "جزيرة عيد الميلاد" },
        };
    }

    ///<summary>
    /// The class definition for country of Cocos (Keeling) Islands
    ///</summary>
    public class Cocos : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CC";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CCK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 166;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Cocos (Keeling) Islands" }, // Default to English as country name
            { "cn", "科科斯（基林）群岛" },
            { "ru", "Кокосовых (Килинг) островов" },
            { "fr", "Îles des Cocos (Keeling)" },
            { "es", "Islas Cocos (Keeling)" },
            { "ar", "جزر كوكس (كيلينغ)" },
        };
    }

    ///<summary>
    /// The class definition for country of Colombia
    ///</summary>
    public class Colombia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "COL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 170;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Colombia" }, // Default to English as country name
            { "cn", "哥伦比亚" },
            { "ru", "Колумбия" },
            { "fr", "Colombie" },
            { "es", "Colombia" },
            { "ar", "كولومبيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Comoros
    ///</summary>
    public class Comoros : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "COM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 174;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Comoros" }, // Default to English as country name
            { "cn", "科摩罗" },
            { "ru", "Коморские Острова" },
            { "fr", "Comores" },
            { "es", "Comoras" },
            { "ar", "جزر القمر" },
        };
    }

    ///<summary>
    /// The class definition for country of Congo
    ///</summary>
    public class Congo : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "COG";
    
        /// <inheritDoc />
        public override int IsoCodeId => 178;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Congo" }, // Default to English as country name
            { "cn", "刚果" },
            { "ru", "Конго" },
            { "fr", "Congo" },
            { "es", "Congo" },
            { "ar", "الكونغو" },
        };
    }

    ///<summary>
    /// The class definition for country of Cook Islands
    ///</summary>
    public class CookIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "COK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 184;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Cook Islands" }, // Default to English as country name
            { "cn", "库克群岛" },
            { "ru", "Острова Кука" },
            { "fr", "Îles Cook" },
            { "es", "Islas Cook" },
            { "ar", "جزر كوك" },
        };
    }

    ///<summary>
    /// The class definition for country of Costa Rica
    ///</summary>
    public class CostaRica : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CRI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 188;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Costa Rica" }, // Default to English as country name
            { "cn", "哥斯达黎加" },
            { "ru", "Коста-Рика" },
            { "fr", "Costa Rica" },
            { "es", "Costa Rica" },
            { "ar", "كوستاريكا" },
        };
    }

    ///<summary>
    /// The class definition for country of Croatia
    ///</summary>
    public class Croatia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "HR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "HRV";
    
        /// <inheritDoc />
        public override int IsoCodeId => 191;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Croatia" }, // Default to English as country name
            { "cn", "克罗地亚" },
            { "ru", "Хорватия" },
            { "fr", "Croatie" },
            { "es", "Croacia" },
            { "ar", "كرواتيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Cuba
    ///</summary>
    public class Cuba : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CUB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 192;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Cuba" }, // Default to English as country name
            { "cn", "古巴" },
            { "ru", "Куба" },
            { "fr", "Cuba" },
            { "es", "Cuba" },
            { "ar", "كوبا" },
        };
    }

    ///<summary>
    /// The class definition for country of Curaçao
    ///</summary>
    public class Curaçao : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CUW";
    
        /// <inheritDoc />
        public override int IsoCodeId => 531;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Curaçao" }, // Default to English as country name
            { "cn", "库拉索" },
            { "ru", "Кюрасао" },
            { "fr", "Curaçao" },
            { "es", "Curazao" },
            { "ar", "كوراساو" },
        };
    }

    ///<summary>
    /// The class definition for country of Cyprus
    ///</summary>
    public class Cyprus : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CYP";
    
        /// <inheritDoc />
        public override int IsoCodeId => 196;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Cyprus" }, // Default to English as country name
            { "cn", "塞浦路斯" },
            { "ru", "Кипр" },
            { "fr", "Chypre" },
            { "es", "Chipre" },
            { "ar", "قبرص" },
        };
    }

    ///<summary>
    /// The class definition for country of Czechia
    ///</summary>
    public class Czechia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CZE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 203;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Czechia" }, // Default to English as country name
            { "cn", "捷克" },
            { "ru", "Чехия" },
            { "fr", "Tchéquie" },
            { "es", "Chequia" },
            { "ar", "تشيكيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Democratic People's Republic of Korea
    ///</summary>
    public class DemocraticPeoplesRepublicOfKorea : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KP";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PRK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 408;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Democratic People's Republic of Korea" }, // Default to English as country name
            { "cn", "朝鲜民主主义人民共和国" },
            { "ru", "Корейская Народно-Демократическая Республика" },
            { "fr", "République populaire démocratique de Corée" },
            { "es", "República Popular Democrática de Corea" },
            { "ar", "جمهورية كوريا الشعبية الديمقراطية" },
        };
    }

    ///<summary>
    /// The class definition for country of Democratic Republic of the Congo
    ///</summary>
    public class DemocraticRepublicOfTheCongo : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CD";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "COD";
    
        /// <inheritDoc />
        public override int IsoCodeId => 180;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Democratic Republic of the Congo" }, // Default to English as country name
            { "cn", "刚果民主共和国" },
            { "ru", "Демократическая Республика Конго" },
            { "fr", "République démocratique du Congo" },
            { "es", "República Democrática del Congo" },
            { "ar", "جمهورية الكونغو الديمقراطية" },
        };
    }

    ///<summary>
    /// The class definition for country of Denmark
    ///</summary>
    public class Denmark : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "DK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "DNK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 208;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Denmark" }, // Default to English as country name
            { "cn", "丹麦" },
            { "ru", "Дания" },
            { "fr", "Danemark" },
            { "es", "Dinamarca" },
            { "ar", "الدانمرك" },
        };
    }

    ///<summary>
    /// The class definition for country of Djibouti
    ///</summary>
    public class Djibouti : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "DJ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "DJI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 262;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Djibouti" }, // Default to English as country name
            { "cn", "吉布提" },
            { "ru", "Джибути" },
            { "fr", "Djibouti" },
            { "es", "Djibouti" },
            { "ar", "جيبوتي" },
        };
    }

    ///<summary>
    /// The class definition for country of Dominica
    ///</summary>
    public class Dominica : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "DM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "DMA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 212;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Dominica" }, // Default to English as country name
            { "cn", "多米尼克" },
            { "ru", "Доминика" },
            { "fr", "Dominique" },
            { "es", "Dominica" },
            { "ar", "دومينيكا" },
        };
    }

    ///<summary>
    /// The class definition for country of Dominican Republic
    ///</summary>
    public class DominicanRepublic : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "DO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "DOM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 214;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Dominican Republic" }, // Default to English as country name
            { "cn", "多米尼加" },
            { "ru", "Доминиканская Республика" },
            { "fr", "République dominicaine" },
            { "es", "República Dominicana" },
            { "ar", "الجمهورية الدومينيكية" },
        };
    }

    ///<summary>
    /// The class definition for country of Ecuador
    ///</summary>
    public class Ecuador : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "EC";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ECU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 218;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Ecuador" }, // Default to English as country name
            { "cn", "厄瓜多尔" },
            { "ru", "Эквадор" },
            { "fr", "Équateur" },
            { "es", "Ecuador" },
            { "ar", "إكوادور" },
        };
    }

    ///<summary>
    /// The class definition for country of Egypt
    ///</summary>
    public class Egypt : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "EG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "EGY";
    
        /// <inheritDoc />
        public override int IsoCodeId => 818;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Egypt" }, // Default to English as country name
            { "cn", "埃及" },
            { "ru", "Египет" },
            { "fr", "Égypte" },
            { "es", "Egipto" },
            { "ar", "مصر" },
        };
    }

    ///<summary>
    /// The class definition for country of El Salvador
    ///</summary>
    public class ElSalvador : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SV";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SLV";
    
        /// <inheritDoc />
        public override int IsoCodeId => 222;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "El Salvador" }, // Default to English as country name
            { "cn", "萨尔瓦多" },
            { "ru", "Сальвадор" },
            { "fr", "El Salvador" },
            { "es", "El Salvador" },
            { "ar", "السلفادور" },
        };
    }

    ///<summary>
    /// The class definition for country of Equatorial Guinea
    ///</summary>
    public class EquatorialGuinea : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GQ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GNQ";
    
        /// <inheritDoc />
        public override int IsoCodeId => 226;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Equatorial Guinea" }, // Default to English as country name
            { "cn", "赤道几内亚" },
            { "ru", "Экваториальная Гвинея" },
            { "fr", "Guinée équatoriale" },
            { "es", "Guinea Ecuatorial" },
            { "ar", "غينيا الاستوائية" },
        };
    }

    ///<summary>
    /// The class definition for country of Eritrea
    ///</summary>
    public class Eritrea : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ER";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ERI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 232;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Eritrea" }, // Default to English as country name
            { "cn", "厄立特里亚" },
            { "ru", "Эритрея" },
            { "fr", "Érythrée" },
            { "es", "Eritrea" },
            { "ar", "إريتريا" },
        };
    }

    ///<summary>
    /// The class definition for country of Estonia
    ///</summary>
    public class Estonia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "EE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "EST";
    
        /// <inheritDoc />
        public override int IsoCodeId => 233;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Estonia" }, // Default to English as country name
            { "cn", "爱沙尼亚" },
            { "ru", "Эстония" },
            { "fr", "Estonie" },
            { "es", "Estonia" },
            { "ar", "إستونيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Eswatini
    ///</summary>
    public class Eswatini : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SWZ";
    
        /// <inheritDoc />
        public override int IsoCodeId => 748;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Eswatini" }, // Default to English as country name
            { "cn", "斯威士兰" },
            { "ru", "Эсватини" },
            { "fr", "Eswatini" },
            { "es", "Eswatini" },
            { "ar", "إسواتيني" },
        };
    }

    ///<summary>
    /// The class definition for country of Ethiopia
    ///</summary>
    public class Ethiopia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ET";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ETH";
    
        /// <inheritDoc />
        public override int IsoCodeId => 231;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Ethiopia" }, // Default to English as country name
            { "cn", "埃塞俄比亚" },
            { "ru", "Эфиопия" },
            { "fr", "Éthiopie" },
            { "es", "Etiopía" },
            { "ar", "إثيوبيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Falkland Islands
    ///</summary>
    public class FalklandIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "FK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "FLK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 238;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Falkland Islands" }, // Default to English as country name
            { "cn", "福克兰群岛（马尔维纳斯）" },
            { "ru", "Фолклендские (Мальвинские) острова" },
            { "fr", "Îles Falkland (Malvinas)" },
            { "es", "Islas Malvinas (Falkland)" },
            { "ar", "جزر فوكلاند (مالفيناس)" },
        };
    }

    ///<summary>
    /// The class definition for country of Faroe Islands
    ///</summary>
    public class FaroeIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "FO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "FRO";
    
        /// <inheritDoc />
        public override int IsoCodeId => 234;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Faroe Islands" }, // Default to English as country name
            { "cn", "法罗群岛" },
            { "ru", "Фарерские острова" },
            { "fr", "Îles Féroé" },
            { "es", "Islas Feroe" },
            { "ar", "جزر فايرو" },
        };
    }

    ///<summary>
    /// The class definition for country of Fiji
    ///</summary>
    public class Fiji : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "FJ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "FJI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 242;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Fiji" }, // Default to English as country name
            { "cn", "斐济" },
            { "ru", "Фиджи" },
            { "fr", "Fidji" },
            { "es", "Fiji" },
            { "ar", "فيجي" },
        };
    }

    ///<summary>
    /// The class definition for country of Finland
    ///</summary>
    public class Finland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "FI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "FIN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 246;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Finland" }, // Default to English as country name
            { "cn", "芬兰" },
            { "ru", "Финляндия" },
            { "fr", "Finlande" },
            { "es", "Finlandia" },
            { "ar", "فنلندا" },
        };
    }

    ///<summary>
    /// The class definition for country of France
    ///</summary>
    public class France : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "FR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "FRA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 250;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "France" }, // Default to English as country name
            { "cn", "法国" },
            { "ru", "Франция" },
            { "fr", "France" },
            { "es", "Francia" },
            { "ar", "فرنسا" },
        };
    }

    ///<summary>
    /// The class definition for country of French Guiana
    ///</summary>
    public class FrenchGuiana : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GUF";
    
        /// <inheritDoc />
        public override int IsoCodeId => 254;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "French Guiana" }, // Default to English as country name
            { "cn", "法属圭亚那" },
            { "ru", "Французская Гвиана" },
            { "fr", "Guyane française" },
            { "es", "Guayana Francesa" },
            { "ar", "غيانا الفرنسية" },
        };
    }

    ///<summary>
    /// The class definition for country of French Polynesia
    ///</summary>
    public class FrenchPolynesia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PYF";
    
        /// <inheritDoc />
        public override int IsoCodeId => 258;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "French Polynesia" }, // Default to English as country name
            { "cn", "法属波利尼西亚" },
            { "ru", "Французская Полинезия" },
            { "fr", "Polynésie française" },
            { "es", "Polinesia Francesa" },
            { "ar", "بولينيزيا الفرنسية" },
        };
    }

    ///<summary>
    /// The class definition for country of French Southern Territories
    ///</summary>
    public class FrenchSouthernTerritories : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ATF";
    
        /// <inheritDoc />
        public override int IsoCodeId => 260;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AN";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "French Southern Territories" }, // Default to English as country name
            { "cn", "法属南方领地" },
            { "ru", "Южные земли (французская заморская территория)" },
            { "fr", "Terres australes françaises" },
            { "es", "Territorio de las Tierras Australes Francesas" },
            { "ar", "الأراضي الفرنسية الجنوبية الجنوبية" },
        };
    }

    ///<summary>
    /// The class definition for country of Gabon
    ///</summary>
    public class Gabon : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GAB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 266;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Gabon" }, // Default to English as country name
            { "cn", "加蓬" },
            { "ru", "Габон" },
            { "fr", "Gabon" },
            { "es", "Gabón" },
            { "ar", "غابون" },
        };
    }

    ///<summary>
    /// The class definition for country of Gambia
    ///</summary>
    public class Gambia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GMB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 270;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Gambia" }, // Default to English as country name
            { "cn", "冈比亚" },
            { "ru", "Гамбия" },
            { "fr", "Gambie" },
            { "es", "Gambia" },
            { "ar", "غامبيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Georgia
    ///</summary>
    public class Georgia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GEO";
    
        /// <inheritDoc />
        public override int IsoCodeId => 268;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Georgia" }, // Default to English as country name
            { "cn", "格鲁吉亚" },
            { "ru", "Грузия" },
            { "fr", "Géorgie" },
            { "es", "Georgia" },
            { "ar", "جورجيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Germany
    ///</summary>
    public class Germany : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "DE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "DEU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 276;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Germany" }, // Default to English as country name
            { "cn", "德国" },
            { "ru", "Германия" },
            { "fr", "Allemagne" },
            { "es", "Alemania" },
            { "ar", "ألمانيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Ghana
    ///</summary>
    public class Ghana : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GHA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 288;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Ghana" }, // Default to English as country name
            { "cn", "加纳" },
            { "ru", "Гана" },
            { "fr", "Ghana" },
            { "es", "Ghana" },
            { "ar", "غانا" },
        };
    }

    ///<summary>
    /// The class definition for country of Gibraltar
    ///</summary>
    public class Gibraltar : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GIB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 292;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Gibraltar" }, // Default to English as country name
            { "cn", "直布罗陀" },
            { "ru", "Гибралтар" },
            { "fr", "Gibraltar" },
            { "es", "Gibraltar" },
            { "ar", "جبل طارق" },
        };
    }

    ///<summary>
    /// The class definition for country of Greece
    ///</summary>
    public class Greece : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GRC";
    
        /// <inheritDoc />
        public override int IsoCodeId => 300;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Greece" }, // Default to English as country name
            { "cn", "希腊" },
            { "ru", "Греция" },
            { "fr", "Grèce" },
            { "es", "Grecia" },
            { "ar", "اليونان" },
        };
    }

    ///<summary>
    /// The class definition for country of Greenland
    ///</summary>
    public class Greenland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GRL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 304;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Greenland" }, // Default to English as country name
            { "cn", "格陵兰" },
            { "ru", "Гренландия" },
            { "fr", "Groenland" },
            { "es", "Groenlandia" },
            { "ar", "غرينلند" },
        };
    }

    ///<summary>
    /// The class definition for country of Grenada
    ///</summary>
    public class Grenada : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GD";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GRD";
    
        /// <inheritDoc />
        public override int IsoCodeId => 308;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Grenada" }, // Default to English as country name
            { "cn", "格林纳达" },
            { "ru", "Гренада" },
            { "fr", "Grenade" },
            { "es", "Granada" },
            { "ar", "غرينادا" },
        };
    }

    ///<summary>
    /// The class definition for country of Guadeloupe
    ///</summary>
    public class Guadeloupe : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GP";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GLP";
    
        /// <inheritDoc />
        public override int IsoCodeId => 312;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Guadeloupe" }, // Default to English as country name
            { "cn", "瓜德罗普" },
            { "ru", "Гваделупа" },
            { "fr", "Guadeloupe" },
            { "es", "Guadalupe" },
            { "ar", "غوادلوب" },
        };
    }

    ///<summary>
    /// The class definition for country of Guam
    ///</summary>
    public class Guam : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GUM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 316;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Guam" }, // Default to English as country name
            { "cn", "关岛" },
            { "ru", "Гуам" },
            { "fr", "Guam" },
            { "es", "Guam" },
            { "ar", "غوام" },
        };
    }

    ///<summary>
    /// The class definition for country of Guatemala
    ///</summary>
    public class Guatemala : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GTM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 320;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Guatemala" }, // Default to English as country name
            { "cn", "危地马拉" },
            { "ru", "Гватемала" },
            { "fr", "Guatemala" },
            { "es", "Guatemala" },
            { "ar", "غواتيمالا" },
        };
    }

    ///<summary>
    /// The class definition for country of Guernsey
    ///</summary>
    public class Guernsey : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GGY";
    
        /// <inheritDoc />
        public override int IsoCodeId => 831;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Guernsey" }, // Default to English as country name
            { "cn", "格恩西" },
            { "ru", "Гернси" },
            { "fr", "Guernesey" },
            { "es", "Guernsey" },
            { "ar", "غيرنسي" },
        };
    }

    ///<summary>
    /// The class definition for country of Guinea
    ///</summary>
    public class Guinea : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GIN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 324;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Guinea" }, // Default to English as country name
            { "cn", "几内亚" },
            { "ru", "Гвинея" },
            { "fr", "Guinée" },
            { "es", "Guinea" },
            { "ar", "غينيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Guinea-Bissau
    ///</summary>
    public class GuineaBissau : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GNB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 624;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Guinea-Bissau" }, // Default to English as country name
            { "cn", "几内亚比绍" },
            { "ru", "Гвинея-Бисау" },
            { "fr", "Guinée-Bissau" },
            { "es", "Guinea-Bissau" },
            { "ar", "غينيا - بيساو" },
        };
    }

    ///<summary>
    /// The class definition for country of Guyana
    ///</summary>
    public class Guyana : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GUY";
    
        /// <inheritDoc />
        public override int IsoCodeId => 328;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Guyana" }, // Default to English as country name
            { "cn", "圭亚那" },
            { "ru", "Гайана" },
            { "fr", "Guyana" },
            { "es", "Guyana" },
            { "ar", "غيانا" },
        };
    }

    ///<summary>
    /// The class definition for country of Haiti
    ///</summary>
    public class Haiti : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "HT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "HTI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 332;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Haiti" }, // Default to English as country name
            { "cn", "海地" },
            { "ru", "Гаити" },
            { "fr", "Haïti" },
            { "es", "Haití" },
            { "ar", "هايتي" },
        };
    }

    ///<summary>
    /// The class definition for country of Heard Island and McDonald Islands
    ///</summary>
    public class HeardIslandAndMcdonaldIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "HM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "HMD";
    
        /// <inheritDoc />
        public override int IsoCodeId => 334;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AN";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Heard Island and McDonald Islands" }, // Default to English as country name
            { "cn", "赫德岛和麦克唐纳岛" },
            { "ru", "Остров Херд и острова Макдональд" },
            { "fr", "Île Heard-et-Îles MacDonald" },
            { "es", "Islas Heard y McDonald" },
            { "ar", "جزيرة هيرد وجزر ماكدونالد" },
        };
    }

    ///<summary>
    /// The class definition for country of Holy See
    ///</summary>
    public class HolySee : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "VA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "VAT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 336;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Holy See" }, // Default to English as country name
            { "cn", "教廷" },
            { "ru", "Святой Престол" },
            { "fr", "Saint-Siège" },
            { "es", "Santa Sede" },
            { "ar", "الكرسي الرسولي" },
        };
    }

    ///<summary>
    /// The class definition for country of Honduras
    ///</summary>
    public class Honduras : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "HN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "HND";
    
        /// <inheritDoc />
        public override int IsoCodeId => 340;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Honduras" }, // Default to English as country name
            { "cn", "洪都拉斯" },
            { "ru", "Гондурас" },
            { "fr", "Honduras" },
            { "es", "Honduras" },
            { "ar", "هندوراس" },
        };
    }

    ///<summary>
    /// The class definition for country of Hungary
    ///</summary>
    public class Hungary : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "HU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "HUN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 348;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Hungary" }, // Default to English as country name
            { "cn", "匈牙利" },
            { "ru", "Венгрия" },
            { "fr", "Hongrie" },
            { "es", "Hungría" },
            { "ar", "هنغاريا" },
        };
    }

    ///<summary>
    /// The class definition for country of Iceland
    ///</summary>
    public class Iceland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ISL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 352;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Iceland" }, // Default to English as country name
            { "cn", "冰岛" },
            { "ru", "Исландия" },
            { "fr", "Islande" },
            { "es", "Islandia" },
            { "ar", "آيسلندا" },
        };
    }

    ///<summary>
    /// The class definition for country of India
    ///</summary>
    public class India : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "IND";
    
        /// <inheritDoc />
        public override int IsoCodeId => 356;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "India" }, // Default to English as country name
            { "cn", "印度" },
            { "ru", "Индия" },
            { "fr", "Inde" },
            { "es", "India" },
            { "ar", "الهند" },
        };
    }

    ///<summary>
    /// The class definition for country of Indonesia
    ///</summary>
    public class Indonesia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ID";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "IDN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 360;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Indonesia" }, // Default to English as country name
            { "cn", "印度尼西亚" },
            { "ru", "Индонезия" },
            { "fr", "Indonésie" },
            { "es", "Indonesia" },
            { "ar", "إندونيسيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Iran (Islamic Republic of)
    ///</summary>
    public class Iran : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "IRN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 364;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Iran (Islamic Republic of)" }, // Default to English as country name
            { "cn", "伊朗伊斯兰共和国" },
            { "ru", "Иран (Исламская Республика)" },
            { "fr", "Iran (République islamique d’)" },
            { "es", "Irán (República Islámica del)" },
            { "ar", "إيران (جمهورية - الإسلامية)" },
        };
    }

    ///<summary>
    /// The class definition for country of Iraq
    ///</summary>
    public class Iraq : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IQ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "IRQ";
    
        /// <inheritDoc />
        public override int IsoCodeId => 368;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Iraq" }, // Default to English as country name
            { "cn", "伊拉克" },
            { "ru", "Ирак" },
            { "fr", "Iraq" },
            { "es", "Iraq" },
            { "ar", "العراق" },
        };
    }

    ///<summary>
    /// The class definition for country of Ireland
    ///</summary>
    public class Ireland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "IRL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 372;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Ireland" }, // Default to English as country name
            { "cn", "爱尔兰" },
            { "ru", "Ирландия" },
            { "fr", "Irlande" },
            { "es", "Irlanda" },
            { "ar", "آيرلندا" },
        };
    }

    ///<summary>
    /// The class definition for country of Isle of Man
    ///</summary>
    public class IsleOfMan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "IMN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 833;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Isle of Man" }, // Default to English as country name
            { "cn", "马恩岛" },
            { "ru", "Остров Мэн" },
            { "fr", "Île de Man" },
            { "es", "Isla de Man" },
            { "ar", "جزيرة مان" },
        };
    }

    ///<summary>
    /// The class definition for country of Israel
    ///</summary>
    public class Israel : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ISR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 376;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Israel" }, // Default to English as country name
            { "cn", "以色列" },
            { "ru", "Израиль" },
            { "fr", "Israël" },
            { "es", "Israel" },
            { "ar", "إسرائيل" },
        };
    }

    ///<summary>
    /// The class definition for country of Italy
    ///</summary>
    public class Italy : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "IT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ITA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 380;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Italy" }, // Default to English as country name
            { "cn", "意大利" },
            { "ru", "Италия" },
            { "fr", "Italie" },
            { "es", "Italia" },
            { "ar", "إيطاليا" },
        };
    }

    ///<summary>
    /// The class definition for country of Ivory Coast
    ///</summary>
    public class IvoryCoast : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CIV";
    
        /// <inheritDoc />
        public override int IsoCodeId => 384;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Ivory Coast" }, // Default to English as country name
            { "cn", "科特迪瓦" },
            { "ru", "Кот-д'Ивуар" },
            { "fr", "Côte d’Ivoire" },
            { "es", "Côte d’Ivoire" },
            { "ar", "كوت ديفوار" },
        };
    }

    ///<summary>
    /// The class definition for country of Jamaica
    ///</summary>
    public class Jamaica : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "JM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "JAM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 388;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Jamaica" }, // Default to English as country name
            { "cn", "牙买加" },
            { "ru", "Ямайка" },
            { "fr", "Jamaïque" },
            { "es", "Jamaica" },
            { "ar", "جامايكا" },
        };
    }

    ///<summary>
    /// The class definition for country of Japan
    ///</summary>
    public class Japan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "JP";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "JPN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 392;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Japan" }, // Default to English as country name
            { "cn", "日本" },
            { "ru", "Япония" },
            { "fr", "Japon" },
            { "es", "Japón" },
            { "ar", "اليابان" },
        };
    }

    ///<summary>
    /// The class definition for country of Jersey
    ///</summary>
    public class Jersey : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "JE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "JEY";
    
        /// <inheritDoc />
        public override int IsoCodeId => 832;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Jersey" }, // Default to English as country name
            { "cn", "泽西" },
            { "ru", "Джерси" },
            { "fr", "Jersey" },
            { "es", "Jersey" },
            { "ar", "جيرسي" },
        };
    }

    ///<summary>
    /// The class definition for country of Jordan
    ///</summary>
    public class Jordan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "JO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "JOR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 400;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Jordan" }, // Default to English as country name
            { "cn", "约旦" },
            { "ru", "Иордания" },
            { "fr", "Jordanie" },
            { "es", "Jordania" },
            { "ar", "الأردن" },
        };
    }

    ///<summary>
    /// The class definition for country of Kazakhstan
    ///</summary>
    public class Kazakhstan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "KAZ";
    
        /// <inheritDoc />
        public override int IsoCodeId => 398;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Kazakhstan" }, // Default to English as country name
            { "cn", "哈萨克斯坦" },
            { "ru", "Казахстан" },
            { "fr", "Kazakhstan" },
            { "es", "Kazajstán" },
            { "ar", "كازاخستان" },
        };
    }

    ///<summary>
    /// The class definition for country of Kenya
    ///</summary>
    public class Kenya : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "KEN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 404;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Kenya" }, // Default to English as country name
            { "cn", "肯尼亚" },
            { "ru", "Кения" },
            { "fr", "Kenya" },
            { "es", "Kenya" },
            { "ar", "كينيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Kiribati
    ///</summary>
    public class Kiribati : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "KIR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 296;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Kiribati" }, // Default to English as country name
            { "cn", "基里巴斯" },
            { "ru", "Кирибати" },
            { "fr", "Kiribati" },
            { "es", "Kiribati" },
            { "ar", "كيريباس" },
        };
    }

    ///<summary>
    /// The class definition for country of Kuwait
    ///</summary>
    public class Kuwait : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "KWT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 414;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Kuwait" }, // Default to English as country name
            { "cn", "科威特" },
            { "ru", "Кувейт" },
            { "fr", "Koweït" },
            { "es", "Kuwait" },
            { "ar", "الكويت" },
        };
    }

    ///<summary>
    /// The class definition for country of Kyrgyzstan
    ///</summary>
    public class Kyrgyzstan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "KGZ";
    
        /// <inheritDoc />
        public override int IsoCodeId => 417;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Kyrgyzstan" }, // Default to English as country name
            { "cn", "吉尔吉斯斯坦" },
            { "ru", "Кыргызстан" },
            { "fr", "Kirghizistan" },
            { "es", "Kirguistán" },
            { "ar", "قيرغيزستان" },
        };
    }

    ///<summary>
    /// The class definition for country of Lao People's Democratic Republic
    ///</summary>
    public class LaoPeoplesDemocraticRepublic : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LAO";
    
        /// <inheritDoc />
        public override int IsoCodeId => 418;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Lao People's Democratic Republic" }, // Default to English as country name
            { "cn", "老挝人民民主共和国" },
            { "ru", "Лаосская Народно-Демократическая Республика" },
            { "fr", "République démocratique populaire lao" },
            { "es", "República Democrática Popular Lao" },
            { "ar", "جمهورية لاو الديمقراطية الشعبية" },
        };
    }

    ///<summary>
    /// The class definition for country of Latvia
    ///</summary>
    public class Latvia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LV";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LVA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 428;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Latvia" }, // Default to English as country name
            { "cn", "拉脱维亚" },
            { "ru", "Латвия" },
            { "fr", "Lettonie" },
            { "es", "Letonia" },
            { "ar", "لاتفيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Lebanon
    ///</summary>
    public class Lebanon : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LB";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LBN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 422;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Lebanon" }, // Default to English as country name
            { "cn", "黎巴嫩" },
            { "ru", "Ливан" },
            { "fr", "Liban" },
            { "es", "Líbano" },
            { "ar", "لبنان" },
        };
    }

    ///<summary>
    /// The class definition for country of Lesotho
    ///</summary>
    public class Lesotho : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LSO";
    
        /// <inheritDoc />
        public override int IsoCodeId => 426;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Lesotho" }, // Default to English as country name
            { "cn", "莱索托" },
            { "ru", "Лесото" },
            { "fr", "Lesotho" },
            { "es", "Lesotho" },
            { "ar", "ليسوتو" },
        };
    }

    ///<summary>
    /// The class definition for country of Liberia
    ///</summary>
    public class Liberia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LBR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 430;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Liberia" }, // Default to English as country name
            { "cn", "利比里亚" },
            { "ru", "Либерия" },
            { "fr", "Libéria" },
            { "es", "Liberia" },
            { "ar", "ليبريا" },
        };
    }

    ///<summary>
    /// The class definition for country of Libya
    ///</summary>
    public class Libya : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LBY";
    
        /// <inheritDoc />
        public override int IsoCodeId => 434;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Libya" }, // Default to English as country name
            { "cn", "利比亚" },
            { "ru", "Ливия" },
            { "fr", "Libye" },
            { "es", "Libia" },
            { "ar", "ليبيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Liechtenstein
    ///</summary>
    public class Liechtenstein : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LIE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 438;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Liechtenstein" }, // Default to English as country name
            { "cn", "列支敦士登" },
            { "ru", "Лихтенштейн" },
            { "fr", "Liechtenstein" },
            { "es", "Liechtenstein" },
            { "ar", "ليختنشتاين" },
        };
    }

    ///<summary>
    /// The class definition for country of Lithuania
    ///</summary>
    public class Lithuania : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LTU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 440;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Lithuania" }, // Default to English as country name
            { "cn", "立陶宛" },
            { "ru", "Литва" },
            { "fr", "Lituanie" },
            { "es", "Lituania" },
            { "ar", "ليتوانيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Luxembourg
    ///</summary>
    public class Luxembourg : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LUX";
    
        /// <inheritDoc />
        public override int IsoCodeId => 442;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Luxembourg" }, // Default to English as country name
            { "cn", "卢森堡" },
            { "ru", "Люксембург" },
            { "fr", "Luxembourg" },
            { "es", "Luxemburgo" },
            { "ar", "لكسمبرغ" },
        };
    }

    ///<summary>
    /// The class definition for country of Madagascar
    ///</summary>
    public class Madagascar : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MDG";
    
        /// <inheritDoc />
        public override int IsoCodeId => 450;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Madagascar" }, // Default to English as country name
            { "cn", "马达加斯加" },
            { "ru", "Мадагаскар" },
            { "fr", "Madagascar" },
            { "es", "Madagascar" },
            { "ar", "مدغشقر" },
        };
    }

    ///<summary>
    /// The class definition for country of Malawi
    ///</summary>
    public class Malawi : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MWI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 454;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Malawi" }, // Default to English as country name
            { "cn", "马拉维" },
            { "ru", "Малави" },
            { "fr", "Malawi" },
            { "es", "Malawi" },
            { "ar", "ملاوي" },
        };
    }

    ///<summary>
    /// The class definition for country of Malaysia
    ///</summary>
    public class Malaysia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MYS";
    
        /// <inheritDoc />
        public override int IsoCodeId => 458;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Malaysia" }, // Default to English as country name
            { "cn", "马来西亚" },
            { "ru", "Малайзия" },
            { "fr", "Malaisie" },
            { "es", "Malasia" },
            { "ar", "ماليزيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Maldives
    ///</summary>
    public class Maldives : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MV";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MDV";
    
        /// <inheritDoc />
        public override int IsoCodeId => 462;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Maldives" }, // Default to English as country name
            { "cn", "马尔代夫" },
            { "ru", "Мальдивские Острова" },
            { "fr", "Maldives" },
            { "es", "Maldivas" },
            { "ar", "ملديف" },
        };
    }

    ///<summary>
    /// The class definition for country of Mali
    ///</summary>
    public class Mali : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ML";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MLI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 466;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Mali" }, // Default to English as country name
            { "cn", "马里" },
            { "ru", "Мали" },
            { "fr", "Mali" },
            { "es", "Malí" },
            { "ar", "مالي" },
        };
    }

    ///<summary>
    /// The class definition for country of Malta
    ///</summary>
    public class Malta : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MLT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 470;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Malta" }, // Default to English as country name
            { "cn", "马耳他" },
            { "ru", "Мальта" },
            { "fr", "Malte" },
            { "es", "Malta" },
            { "ar", "مالطة" },
        };
    }

    ///<summary>
    /// The class definition for country of Marshall Islands
    ///</summary>
    public class MarshallIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MHL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 584;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Marshall Islands" }, // Default to English as country name
            { "cn", "马绍尔群岛" },
            { "ru", "Маршалловы Острова" },
            { "fr", "Îles Marshall" },
            { "es", "Islas Marshall" },
            { "ar", "جزر مارشال" },
        };
    }

    ///<summary>
    /// The class definition for country of Martinique
    ///</summary>
    public class Martinique : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MQ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MTQ";
    
        /// <inheritDoc />
        public override int IsoCodeId => 474;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Martinique" }, // Default to English as country name
            { "cn", "马提尼克" },
            { "ru", "Мартиника" },
            { "fr", "Martinique" },
            { "es", "Martinica" },
            { "ar", "مارتينيك" },
        };
    }

    ///<summary>
    /// The class definition for country of Mauritania
    ///</summary>
    public class Mauritania : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MRT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 478;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Mauritania" }, // Default to English as country name
            { "cn", "毛里塔尼亚" },
            { "ru", "Мавритания" },
            { "fr", "Mauritanie" },
            { "es", "Mauritania" },
            { "ar", "موريتانيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Mauritius
    ///</summary>
    public class Mauritius : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MUS";
    
        /// <inheritDoc />
        public override int IsoCodeId => 480;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Mauritius" }, // Default to English as country name
            { "cn", "毛里求斯" },
            { "ru", "Маврикий" },
            { "fr", "Maurice" },
            { "es", "Mauricio" },
            { "ar", "موريشيوس" },
        };
    }

    ///<summary>
    /// The class definition for country of Mayotte
    ///</summary>
    public class Mayotte : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "YT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MYT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 175;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Mayotte" }, // Default to English as country name
            { "cn", "马约特" },
            { "ru", "Остров Майотта" },
            { "fr", "Mayotte" },
            { "es", "Mayotte" },
            { "ar", "مايوت" },
        };
    }

    ///<summary>
    /// The class definition for country of Mexico
    ///</summary>
    public class Mexico : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MX";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MEX";
    
        /// <inheritDoc />
        public override int IsoCodeId => 484;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Mexico" }, // Default to English as country name
            { "cn", "墨西哥" },
            { "ru", "Мексика" },
            { "fr", "Mexique" },
            { "es", "México" },
            { "ar", "المكسيك" },
        };
    }

    ///<summary>
    /// The class definition for country of Micronesia (Federated States of)
    ///</summary>
    public class Micronesia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "FM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "FSM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 583;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Micronesia (Federated States of)" }, // Default to English as country name
            { "cn", "密克罗尼西亚联邦" },
            { "ru", "Микронезия (Федеративные Штаты)" },
            { "fr", "Micronésie (États fédérés de)" },
            { "es", "Micronesia (Estados Federados de)" },
            { "ar", "ميكرونيزيا (ولايات - الموحدة)" },
        };
    }

    ///<summary>
    /// The class definition for country of Monaco
    ///</summary>
    public class Monaco : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MC";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MCO";
    
        /// <inheritDoc />
        public override int IsoCodeId => 492;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Monaco" }, // Default to English as country name
            { "cn", "摩纳哥" },
            { "ru", "Монако" },
            { "fr", "Monaco" },
            { "es", "Mónaco" },
            { "ar", "موناكو" },
        };
    }

    ///<summary>
    /// The class definition for country of Mongolia
    ///</summary>
    public class Mongolia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MNG";
    
        /// <inheritDoc />
        public override int IsoCodeId => 496;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Mongolia" }, // Default to English as country name
            { "cn", "蒙古" },
            { "ru", "Монголия" },
            { "fr", "Mongolie" },
            { "es", "Mongolia" },
            { "ar", "منغوليا" },
        };
    }

    ///<summary>
    /// The class definition for country of Montenegro
    ///</summary>
    public class Montenegro : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ME";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MNE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 499;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Montenegro" }, // Default to English as country name
            { "cn", "黑山" },
            { "ru", "Черногория" },
            { "fr", "Monténégro" },
            { "es", "Montenegro" },
            { "ar", "الجبل الأسود" },
        };
    }

    ///<summary>
    /// The class definition for country of Montserrat
    ///</summary>
    public class Montserrat : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MSR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 500;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Montserrat" }, // Default to English as country name
            { "cn", "蒙特塞拉特" },
            { "ru", "Монтсеррат" },
            { "fr", "Montserrat" },
            { "es", "Montserrat" },
            { "ar", "مونتسيرات" },
        };
    }

    ///<summary>
    /// The class definition for country of Morocco
    ///</summary>
    public class Morocco : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MAR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 504;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Morocco" }, // Default to English as country name
            { "cn", "摩洛哥" },
            { "ru", "Марокко" },
            { "fr", "Maroc" },
            { "es", "Marruecos" },
            { "ar", "المغرب" },
        };
    }

    ///<summary>
    /// The class definition for country of Mozambique
    ///</summary>
    public class Mozambique : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MOZ";
    
        /// <inheritDoc />
        public override int IsoCodeId => 508;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Mozambique" }, // Default to English as country name
            { "cn", "莫桑比克" },
            { "ru", "Мозамбик" },
            { "fr", "Mozambique" },
            { "es", "Mozambique" },
            { "ar", "موزامبيق" },
        };
    }

    ///<summary>
    /// The class definition for country of Myanmar
    ///</summary>
    public class Myanmar : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MMR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 104;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Myanmar" }, // Default to English as country name
            { "cn", "缅甸" },
            { "ru", "Мьянма" },
            { "fr", "Myanmar" },
            { "es", "Myanmar" },
            { "ar", "ميانمار" },
        };
    }

    ///<summary>
    /// The class definition for country of Namibia
    ///</summary>
    public class Namibia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NAM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 516;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Namibia" }, // Default to English as country name
            { "cn", "纳米比亚" },
            { "ru", "Намибия" },
            { "fr", "Namibie" },
            { "es", "Namibia" },
            { "ar", "ناميبيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Nauru
    ///</summary>
    public class Nauru : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NRU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 520;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Nauru" }, // Default to English as country name
            { "cn", "瑙鲁" },
            { "ru", "Науру" },
            { "fr", "Nauru" },
            { "es", "Nauru" },
            { "ar", "ناورو" },
        };
    }

    ///<summary>
    /// The class definition for country of Nepal
    ///</summary>
    public class Nepal : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NP";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NPL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 524;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Nepal" }, // Default to English as country name
            { "cn", "尼泊尔" },
            { "ru", "Непал" },
            { "fr", "Népal" },
            { "es", "Nepal" },
            { "ar", "نيبال" },
        };
    }

    ///<summary>
    /// The class definition for country of Netherlands
    ///</summary>
    public class Netherlands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NLD";
    
        /// <inheritDoc />
        public override int IsoCodeId => 528;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Netherlands" }, // Default to English as country name
            { "cn", "荷兰王国" },
            { "ru", "Нидерланды (Королевство)" },
            { "fr", "Pays-Bas (Royaume des)" },
            { "es", "Países Bajos (Reino de los)" },
            { "ar", "هولندا (مملكة _)" },
        };
    }

    ///<summary>
    /// The class definition for country of New Caledonia
    ///</summary>
    public class NewCaledonia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NC";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NCL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 540;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "New Caledonia" }, // Default to English as country name
            { "cn", "新喀里多尼亚" },
            { "ru", "Новая Каледония" },
            { "fr", "Nouvelle-Calédonie" },
            { "es", "Nueva Caledonia" },
            { "ar", "كاليدونيا الجديدة" },
        };
    }

    ///<summary>
    /// The class definition for country of New Zealand
    ///</summary>
    public class NewZealand : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NZL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 554;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "New Zealand" }, // Default to English as country name
            { "cn", "新西兰" },
            { "ru", "Новая Зеландия" },
            { "fr", "Nouvelle-Zélande" },
            { "es", "Nueva Zelandia" },
            { "ar", "نيوزيلندا" },
        };
    }

    ///<summary>
    /// The class definition for country of Nicaragua
    ///</summary>
    public class Nicaragua : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NIC";
    
        /// <inheritDoc />
        public override int IsoCodeId => 558;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Nicaragua" }, // Default to English as country name
            { "cn", "尼加拉瓜" },
            { "ru", "Никарагуа" },
            { "fr", "Nicaragua" },
            { "es", "Nicaragua" },
            { "ar", "نيكاراغوا" },
        };
    }

    ///<summary>
    /// The class definition for country of Niger
    ///</summary>
    public class Niger : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NER";
    
        /// <inheritDoc />
        public override int IsoCodeId => 562;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Niger" }, // Default to English as country name
            { "cn", "尼日尔" },
            { "ru", "Нигер" },
            { "fr", "Niger" },
            { "es", "Níger" },
            { "ar", "النيجر" },
        };
    }

    ///<summary>
    /// The class definition for country of Nigeria
    ///</summary>
    public class Nigeria : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NGA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 566;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Nigeria" }, // Default to English as country name
            { "cn", "尼日利亚" },
            { "ru", "Нигерия" },
            { "fr", "Nigéria" },
            { "es", "Nigeria" },
            { "ar", "نيجيريا" },
        };
    }

    ///<summary>
    /// The class definition for country of Niue
    ///</summary>
    public class Niue : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NIU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 570;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Niue" }, // Default to English as country name
            { "cn", "纽埃" },
            { "ru", "Ниуэ" },
            { "fr", "Nioué" },
            { "es", "Niue" },
            { "ar", "نيوي" },
        };
    }

    ///<summary>
    /// The class definition for country of Norfolk Island
    ///</summary>
    public class NorfolkIsland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NFK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 574;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Norfolk Island" }, // Default to English as country name
            { "cn", "诺福克岛" },
            { "ru", "Остров Норфолк" },
            { "fr", "Île Norfolk" },
            { "es", "Isla Norfolk" },
            { "ar", "جزيرة نورفولك" },
        };
    }

    ///<summary>
    /// The class definition for country of Northern Mariana Islands
    ///</summary>
    public class NorthernMarianaIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MP";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MNP";
    
        /// <inheritDoc />
        public override int IsoCodeId => 580;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Northern Mariana Islands" }, // Default to English as country name
            { "cn", "北马里亚纳群岛" },
            { "ru", "Северные Марианские острова" },
            { "fr", "Îles Mariannes du Nord" },
            { "es", "Islas Marianas Septentrionales" },
            { "ar", "جزر ماريانا الشمالية" },
        };
    }

    ///<summary>
    /// The class definition for country of North Macedonia
    ///</summary>
    public class NorthMacedonia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MKD";
    
        /// <inheritDoc />
        public override int IsoCodeId => 807;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "North Macedonia" }, // Default to English as country name
            { "cn", "北马其顿" },
            { "ru", "Северная Македония" },
            { "fr", "Macédoine du Nord" },
            { "es", "Macedonia del Norte" },
            { "ar", "مقدونيا الشمالية" },
        };
    }

    ///<summary>
    /// The class definition for country of Norway
    ///</summary>
    public class Norway : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "NO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "NOR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 578;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Norway" }, // Default to English as country name
            { "cn", "挪威" },
            { "ru", "Норвегия" },
            { "fr", "Norvège" },
            { "es", "Noruega" },
            { "ar", "النرويج" },
        };
    }

    ///<summary>
    /// The class definition for country of Oman
    ///</summary>
    public class Oman : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "OM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "OMN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 512;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Oman" }, // Default to English as country name
            { "cn", "阿曼" },
            { "ru", "Оман" },
            { "fr", "Oman" },
            { "es", "Omán" },
            { "ar", "عمان" },
        };
    }

    ///<summary>
    /// The class definition for country of Pakistan
    ///</summary>
    public class Pakistan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PAK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 586;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Pakistan" }, // Default to English as country name
            { "cn", "巴基斯坦" },
            { "ru", "Пакистан" },
            { "fr", "Pakistan" },
            { "es", "Pakistán" },
            { "ar", "باكستان" },
        };
    }

    ///<summary>
    /// The class definition for country of Palau
    ///</summary>
    public class Palau : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PLW";
    
        /// <inheritDoc />
        public override int IsoCodeId => 585;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Palau" }, // Default to English as country name
            { "cn", "帕劳" },
            { "ru", "Палау" },
            { "fr", "Palaos" },
            { "es", "Palau" },
            { "ar", "بالاو" },
        };
    }

    ///<summary>
    /// The class definition for country of Panama
    ///</summary>
    public class Panama : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PAN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 591;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Panama" }, // Default to English as country name
            { "cn", "巴拿马" },
            { "ru", "Панама" },
            { "fr", "Panama" },
            { "es", "Panamá" },
            { "ar", "بنما" },
        };
    }

    ///<summary>
    /// The class definition for country of Papua New Guinea
    ///</summary>
    public class PapuaNewGuinea : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PNG";
    
        /// <inheritDoc />
        public override int IsoCodeId => 598;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Papua New Guinea" }, // Default to English as country name
            { "cn", "巴布亚新几内亚" },
            { "ru", "Папуа-Новая Гвинея" },
            { "fr", "Papouasie-Nouvelle-Guinée" },
            { "es", "Papua Nueva Guinea" },
            { "ar", "بابوا غينيا الجديدة" },
        };
    }

    ///<summary>
    /// The class definition for country of Paraguay
    ///</summary>
    public class Paraguay : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PRY";
    
        /// <inheritDoc />
        public override int IsoCodeId => 600;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Paraguay" }, // Default to English as country name
            { "cn", "巴拉圭" },
            { "ru", "Парагвай" },
            { "fr", "Paraguay" },
            { "es", "Paraguay" },
            { "ar", "باراغواي" },
        };
    }

    ///<summary>
    /// The class definition for country of Peru
    ///</summary>
    public class Peru : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PER";
    
        /// <inheritDoc />
        public override int IsoCodeId => 604;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Peru" }, // Default to English as country name
            { "cn", "秘鲁" },
            { "ru", "Перу" },
            { "fr", "Pérou" },
            { "es", "Perú" },
            { "ar", "بيرو" },
        };
    }

    ///<summary>
    /// The class definition for country of Philippines
    ///</summary>
    public class Philippines : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PHL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 608;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Philippines" }, // Default to English as country name
            { "cn", "菲律宾" },
            { "ru", "Филиппины" },
            { "fr", "Philippines" },
            { "es", "Filipinas" },
            { "ar", "الفلبين" },
        };
    }

    ///<summary>
    /// The class definition for country of Pitcairn
    ///</summary>
    public class Pitcairn : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PCN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 612;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Pitcairn" }, // Default to English as country name
            { "cn", "皮特凯恩" },
            { "ru", "Питкэрн" },
            { "fr", "Pitcairn" },
            { "es", "Pitcairn" },
            { "ar", "بيتكرن" },
        };
    }

    ///<summary>
    /// The class definition for country of Poland
    ///</summary>
    public class Poland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "POL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 616;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Poland" }, // Default to English as country name
            { "cn", "波兰" },
            { "ru", "Польша" },
            { "fr", "Pologne" },
            { "es", "Polonia" },
            { "ar", "بولندا" },
        };
    }

    ///<summary>
    /// The class definition for country of Portugal
    ///</summary>
    public class Portugal : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PRT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 620;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Portugal" }, // Default to English as country name
            { "cn", "葡萄牙" },
            { "ru", "Португалия" },
            { "fr", "Portugal" },
            { "es", "Portugal" },
            { "ar", "البرتغال" },
        };
    }

    ///<summary>
    /// The class definition for country of Puerto Rico
    ///</summary>
    public class PuertoRico : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PRI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 630;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Puerto Rico" }, // Default to English as country name
            { "cn", "波多黎各" },
            { "ru", "Пуэрто-Рико" },
            { "fr", "Porto Rico" },
            { "es", "Puerto Rico" },
            { "ar", "بورتوريكو" },
        };
    }

    ///<summary>
    /// The class definition for country of Qatar
    ///</summary>
    public class Qatar : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "QA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "QAT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 634;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Qatar" }, // Default to English as country name
            { "cn", "卡塔尔" },
            { "ru", "Катар" },
            { "fr", "Qatar" },
            { "es", "Qatar" },
            { "ar", "قطر" },
        };
    }

    ///<summary>
    /// The class definition for country of Republic of Korea
    ///</summary>
    public class RepublicOfKorea : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "KOR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 410;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Republic of Korea" }, // Default to English as country name
            { "cn", "大韩民国" },
            { "ru", "Республика Корея" },
            { "fr", "République de Corée" },
            { "es", "República de Corea" },
            { "ar", "جمهورية كوريا" },
        };
    }

    ///<summary>
    /// The class definition for country of Republic of Moldova
    ///</summary>
    public class RepublicOfMoldova : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MD";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MDA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 498;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Republic of Moldova" }, // Default to English as country name
            { "cn", "摩尔多瓦共和国" },
            { "ru", "Республика Молдова" },
            { "fr", "République de Moldova" },
            { "es", "República de Moldova" },
            { "ar", "جمهورية مولدوفا" },
        };
    }

    ///<summary>
    /// The class definition for country of Réunion
    ///</summary>
    public class Réunion : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "RE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "REU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 638;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Réunion" }, // Default to English as country name
            { "cn", "留尼汪" },
            { "ru", "Реюньон" },
            { "fr", "Réunion" },
            { "es", "Reunión" },
            { "ar", "ريونيون" },
        };
    }

    ///<summary>
    /// The class definition for country of Romania
    ///</summary>
    public class Romania : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "RO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ROU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 642;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Romania" }, // Default to English as country name
            { "cn", "罗马尼亚" },
            { "ru", "Румыния" },
            { "fr", "Roumanie" },
            { "es", "Rumania" },
            { "ar", "رومانيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Russian Federation
    ///</summary>
    public class RussianFederation : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "RU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "RUS";
    
        /// <inheritDoc />
        public override int IsoCodeId => 643;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Russian Federation" }, // Default to English as country name
            { "cn", "俄罗斯联邦" },
            { "ru", "Российская Федерация" },
            { "fr", "Fédération de Russie" },
            { "es", "Federación de Rusia" },
            { "ar", "الاتحاد الروسي" },
        };
    }

    ///<summary>
    /// The class definition for country of Rwanda
    ///</summary>
    public class Rwanda : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "RW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "RWA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 646;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Rwanda" }, // Default to English as country name
            { "cn", "卢旺达" },
            { "ru", "Руанда" },
            { "fr", "Rwanda" },
            { "es", "Rwanda" },
            { "ar", "رواندا" },
        };
    }

    ///<summary>
    /// The class definition for country of Saint Barthélemy
    ///</summary>
    public class SaintBarthélemy : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "BL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "BLM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 652;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Saint Barthélemy" }, // Default to English as country name
            { "cn", "圣巴泰勒米" },
            { "ru", "Сен-Бартелеми" },
            { "fr", "Saint-Barthélemy" },
            { "es", "San Barthélemy" },
            { "ar", "سان بارتليمي" },
        };
    }

    ///<summary>
    /// The class definition for country of Saint Helena
    ///</summary>
    public class SaintHelena : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SHN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 654;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Saint Helena" }, // Default to English as country name
            { "cn", "圣赫勒拿" },
            { "ru", "Остров Святой Елены" },
            { "fr", "Sainte-Hélène" },
            { "es", "Santa Elena" },
            { "ar", "سانت هيلانة" },
        };
    }

    ///<summary>
    /// The class definition for country of Saint Kitts and Nevis
    ///</summary>
    public class SaintKittsAndNevis : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "KN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "KNA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 659;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Saint Kitts and Nevis" }, // Default to English as country name
            { "cn", "圣基茨和尼维斯" },
            { "ru", "Сент-Китс и Невис" },
            { "fr", "Saint-Kitts-et-Nevis" },
            { "es", "Saint Kitts y Nevis" },
            { "ar", "سانت كيتس ونيفس" },
        };
    }

    ///<summary>
    /// The class definition for country of Saint Lucia
    ///</summary>
    public class SaintLucia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LC";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LCA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 662;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Saint Lucia" }, // Default to English as country name
            { "cn", "圣卢西亚" },
            { "ru", "Сент-Люсия" },
            { "fr", "Sainte-Lucie" },
            { "es", "Santa Lucía" },
            { "ar", "سانت لوسيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Saint Martin (French Part)
    ///</summary>
    public class SaintMartin : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "MF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "MAF";
    
        /// <inheritDoc />
        public override int IsoCodeId => 663;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Saint Martin (French Part)" }, // Default to English as country name
            { "cn", "圣马丁（法属）" },
            { "ru", "Сен-Мартен (французская часть)" },
            { "fr", "Saint-Martin (partie française)" },
            { "es", "San Martín (parte francesa)" },
            { "ar", "سانت مارتن (الجزء الفرنسي)" },
        };
    }

    ///<summary>
    /// The class definition for country of Saint Pierre and Miquelon
    ///</summary>
    public class SaintPierreAndMiquelon : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SPM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 666;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Saint Pierre and Miquelon" }, // Default to English as country name
            { "cn", "圣皮埃尔和密克隆" },
            { "ru", "Сен-Пьер и Микелон" },
            { "fr", "Saint-Pierre-et-Miquelon" },
            { "es", "San Pedro y Miquelón" },
            { "ar", "سان بيير وميكلون" },
        };
    }

    ///<summary>
    /// The class definition for country of Saint Vincent and the Grenadines
    ///</summary>
    public class SaintVincentAndTheGrenadines : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "VC";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "VCT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 670;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Saint Vincent and the Grenadines" }, // Default to English as country name
            { "cn", "圣文森特和格林纳丁斯" },
            { "ru", "Сент-Винсент и Гренадины" },
            { "fr", "Saint-Vincent-et-les Grenadines" },
            { "es", "San Vicente y las Granadinas" },
            { "ar", "سانت فنسنت وجزر غرينادين" },
        };
    }

    ///<summary>
    /// The class definition for country of Samoa
    ///</summary>
    public class Samoa : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "WS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "WSM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 882;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Samoa" }, // Default to English as country name
            { "cn", "萨摩亚" },
            { "ru", "Самоа" },
            { "fr", "Samoa" },
            { "es", "Samoa" },
            { "ar", "ساموا" },
        };
    }

    ///<summary>
    /// The class definition for country of San Marino
    ///</summary>
    public class SanMarino : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SMR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 674;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "San Marino" }, // Default to English as country name
            { "cn", "圣马力诺" },
            { "ru", "Сан-Марино" },
            { "fr", "Saint-Marin" },
            { "es", "San Marino" },
            { "ar", "سان مارينو" },
        };
    }

    ///<summary>
    /// The class definition for country of Sao Tome and Principe
    ///</summary>
    public class SaoTomeAndPrincipe : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ST";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "STP";
    
        /// <inheritDoc />
        public override int IsoCodeId => 678;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Sao Tome and Principe" }, // Default to English as country name
            { "cn", "圣多美和普林西比" },
            { "ru", "Сан-Томе и Принсипи" },
            { "fr", "Sao Tomé-et-Principe" },
            { "es", "Santo Tomé y Príncipe" },
            { "ar", "سان تومي وبرينسيبي" },
        };
    }

    ///<summary>
    /// The class definition for country of Saudi Arabia
    ///</summary>
    public class SaudiArabia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SAU";
    
        /// <inheritDoc />
        public override int IsoCodeId => 682;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Saudi Arabia" }, // Default to English as country name
            { "cn", "沙特阿拉伯" },
            { "ru", "Саудовская Аравия" },
            { "fr", "Arabie saoudite" },
            { "es", "Arabia Saudita" },
            { "ar", "المملكة العربية السعودية" },
        };
    }

    ///<summary>
    /// The class definition for country of Senegal
    ///</summary>
    public class Senegal : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SEN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 686;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Senegal" }, // Default to English as country name
            { "cn", "塞内加尔" },
            { "ru", "Сенегал" },
            { "fr", "Sénégal" },
            { "es", "Senegal" },
            { "ar", "السنغال" },
        };
    }

    ///<summary>
    /// The class definition for country of Serbia
    ///</summary>
    public class Serbia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "RS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SRB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 688;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Serbia" }, // Default to English as country name
            { "cn", "塞尔维亚" },
            { "ru", "Сербия" },
            { "fr", "Serbie" },
            { "es", "Serbia" },
            { "ar", "صربيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Seychelles
    ///</summary>
    public class Seychelles : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SC";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SYC";
    
        /// <inheritDoc />
        public override int IsoCodeId => 690;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Seychelles" }, // Default to English as country name
            { "cn", "塞舌尔" },
            { "ru", "Сейшельские Острова" },
            { "fr", "Seychelles" },
            { "es", "Seychelles" },
            { "ar", "سيشيل" },
        };
    }

    ///<summary>
    /// The class definition for country of Sierra Leone
    ///</summary>
    public class SierraLeone : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SLE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 694;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Sierra Leone" }, // Default to English as country name
            { "cn", "塞拉利昂" },
            { "ru", "Сьерра-Леоне" },
            { "fr", "Sierra Leone" },
            { "es", "Sierra Leona" },
            { "ar", "سيراليون" },
        };
    }

    ///<summary>
    /// The class definition for country of Singapore
    ///</summary>
    public class Singapore : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SGP";
    
        /// <inheritDoc />
        public override int IsoCodeId => 702;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Singapore" }, // Default to English as country name
            { "cn", "新加坡" },
            { "ru", "Сингапур" },
            { "fr", "Singapour" },
            { "es", "Singapur" },
            { "ar", "سنغافورة" },
        };
    }

    ///<summary>
    /// The class definition for country of Sint Maarten (Dutch part)
    ///</summary>
    public class SintMaarten : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SX";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SXM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 534;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Sint Maarten (Dutch part)" }, // Default to English as country name
            { "cn", "圣马丁（荷属）" },
            { "ru", "Синт-Мартен (нидерландская часть)" },
            { "fr", "Saint-Martin (partie néerlandaise)" },
            { "es", "San Martín (parte Holandesa)" },
            { "ar", "سانت مارتن (الجزء الهولندي)" },
        };
    }

    ///<summary>
    /// The class definition for country of Slovakia
    ///</summary>
    public class Slovakia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SVK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 703;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Slovakia" }, // Default to English as country name
            { "cn", "斯洛伐克" },
            { "ru", "Словакия" },
            { "fr", "Slovaquie" },
            { "es", "Eslovaquia" },
            { "ar", "سلوفاكيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Slovenia
    ///</summary>
    public class Slovenia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SVN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 705;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Slovenia" }, // Default to English as country name
            { "cn", "斯洛文尼亚" },
            { "ru", "Словения" },
            { "fr", "Slovénie" },
            { "es", "Eslovenia" },
            { "ar", "سلوفينيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Solomon Islands
    ///</summary>
    public class SolomonIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SB";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SLB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 90;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Solomon Islands" }, // Default to English as country name
            { "cn", "所罗门群岛" },
            { "ru", "Соломоновы Острова" },
            { "fr", "Îles Salomon" },
            { "es", "Islas Salomón" },
            { "ar", "جزر سليمان" },
        };
    }

    ///<summary>
    /// The class definition for country of Somalia
    ///</summary>
    public class Somalia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SOM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 706;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Somalia" }, // Default to English as country name
            { "cn", "索马里" },
            { "ru", "Сомали" },
            { "fr", "Somalie" },
            { "es", "Somalia" },
            { "ar", "الصومال" },
        };
    }

    ///<summary>
    /// The class definition for country of South Africa
    ///</summary>
    public class SouthAfrica : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ZA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ZAF";
    
        /// <inheritDoc />
        public override int IsoCodeId => 710;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "South Africa" }, // Default to English as country name
            { "cn", "南非" },
            { "ru", "Южная Африка" },
            { "fr", "Afrique du Sud" },
            { "es", "Sudáfrica" },
            { "ar", "جنوب أفريقيا" },
        };
    }

    ///<summary>
    /// The class definition for country of South Georgia and the South Sandwich Islands
    ///</summary>
    public class SouthGeorgiaAndTheSouthSandwichIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SGS";
    
        /// <inheritDoc />
        public override int IsoCodeId => 239;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AN";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "South Georgia and the South Sandwich Islands" }, // Default to English as country name
            { "cn", "南乔治亚岛和南桑德韦奇岛" },
            { "ru", "Южная Джорджия и Южные Сандвичевы острова" },
            { "fr", "Géorgie du Sud-et-les Îles Sandwich du Sud" },
            { "es", "Georgia del Sur y las Islas Sandwich del Sur" },
            { "ar", "جورجيا الجنوبية وجزر ساندويتش الجنوبية" },
        };
    }

    ///<summary>
    /// The class definition for country of South Sudan
    ///</summary>
    public class SouthSudan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SSD";
    
        /// <inheritDoc />
        public override int IsoCodeId => 728;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "South Sudan" }, // Default to English as country name
            { "cn", "南苏丹" },
            { "ru", "Южный Судан" },
            { "fr", "Soudan du Sud" },
            { "es", "Sudán del Sur" },
            { "ar", "جنوب السودان" },
        };
    }

    ///<summary>
    /// The class definition for country of Spain
    ///</summary>
    public class Spain : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ES";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ESP";
    
        /// <inheritDoc />
        public override int IsoCodeId => 724;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Spain" }, // Default to English as country name
            { "cn", "西班牙" },
            { "ru", "Испания" },
            { "fr", "Espagne" },
            { "es", "España" },
            { "ar", "إسبانيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Sri Lanka
    ///</summary>
    public class SriLanka : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "LK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "LKA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 144;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Sri Lanka" }, // Default to English as country name
            { "cn", "斯里兰卡" },
            { "ru", "Шри-Ланка" },
            { "fr", "Sri Lanka" },
            { "es", "Sri Lanka" },
            { "ar", "سري لانكا" },
        };
    }

    ///<summary>
    /// The class definition for country of State of Palestine
    ///</summary>
    public class StateOfPalestine : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "PS";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "PSE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 275;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "State of Palestine" }, // Default to English as country name
            { "cn", "巴勒斯坦国" },
            { "ru", "Государство Палестина" },
            { "fr", "État de Palestine" },
            { "es", "Estado de Palestina" },
            { "ar", "دولة فلسطين" },
        };
    }

    ///<summary>
    /// The class definition for country of Sudan
    ///</summary>
    public class Sudan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SD";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SDN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 729;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Sudan" }, // Default to English as country name
            { "cn", "苏丹" },
            { "ru", "Судан" },
            { "fr", "Soudan" },
            { "es", "Sudán" },
            { "ar", "السودان" },
        };
    }

    ///<summary>
    /// The class definition for country of Suriname
    ///</summary>
    public class Suriname : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SUR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 740;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Suriname" }, // Default to English as country name
            { "cn", "苏里南" },
            { "ru", "Суринам" },
            { "fr", "Suriname" },
            { "es", "Suriname" },
            { "ar", "سورينام" },
        };
    }

    ///<summary>
    /// The class definition for country of Svalbard and Jan Mayen Islands
    ///</summary>
    public class SvalbardAndJanMayenIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SJ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SJM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 744;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Svalbard and Jan Mayen Islands" }, // Default to English as country name
            { "cn", "斯瓦尔巴群岛和扬马延岛" },
            { "ru", "Острова Свальбард и Ян-Майен" },
            { "fr", "Îles Svalbard-et-Jan Mayen" },
            { "es", "Islas Svalbard y Jan Mayen" },
            { "ar", "جزيرتي سفالبارد وجان مايِن" },
        };
    }

    ///<summary>
    /// The class definition for country of Sweden
    ///</summary>
    public class Sweden : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SWE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 752;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Sweden" }, // Default to English as country name
            { "cn", "瑞典" },
            { "ru", "Швеция" },
            { "fr", "Suède" },
            { "es", "Suecia" },
            { "ar", "السويد" },
        };
    }

    ///<summary>
    /// The class definition for country of Switzerland
    ///</summary>
    public class Switzerland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "CH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "CHE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 756;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Switzerland" }, // Default to English as country name
            { "cn", "瑞士" },
            { "ru", "Швейцария" },
            { "fr", "Suisse" },
            { "es", "Suiza" },
            { "ar", "سويسرا" },
        };
    }

    ///<summary>
    /// The class definition for country of Syrian Arab Republic
    ///</summary>
    public class SyrianArabRepublic : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "SY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "SYR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 760;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Syrian Arab Republic" }, // Default to English as country name
            { "cn", "阿拉伯叙利亚共和国" },
            { "ru", "Сирийская Арабская Республика" },
            { "fr", "République arabe syrienne" },
            { "es", "República Árabe Siria" },
            { "ar", "الجمهورية العربية السورية" },
        };
    }

    ///<summary>
    /// The class definition for country of Taiwan
    ///</summary>
    public class Taiwan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TWN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 158;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Taiwan" }, // Default to English as country name
            { "cn", "台湾" },
            { "ru", "Тайвань" },
            { "fr", "Taïwan" },
            { "es", "Taiwán" },
            { "ar", "تايوان" },
        };
    }

    ///<summary>
    /// The class definition for country of Tajikistan
    ///</summary>
    public class Tajikistan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TJ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TJK";
    
        /// <inheritDoc />
        public override int IsoCodeId => 762;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Tajikistan" }, // Default to English as country name
            { "cn", "塔吉克斯坦" },
            { "ru", "Таджикистан" },
            { "fr", "Tadjikistan" },
            { "es", "Tayikistán" },
            { "ar", "طاجيكستان" },
        };
    }

    ///<summary>
    /// The class definition for country of Thailand
    ///</summary>
    public class Thailand : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "THA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 764;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Thailand" }, // Default to English as country name
            { "cn", "泰国" },
            { "ru", "Таиланд" },
            { "fr", "Thaïlande" },
            { "es", "Tailandia" },
            { "ar", "تايلند" },
        };
    }

    ///<summary>
    /// The class definition for country of Timor-Leste
    ///</summary>
    public class TimorLeste : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TL";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TLS";
    
        /// <inheritDoc />
        public override int IsoCodeId => 626;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Timor-Leste" }, // Default to English as country name
            { "cn", "东帝汶" },
            { "ru", "Тимор-Лешти" },
            { "fr", "Timor-Leste" },
            { "es", "Timor-Leste" },
            { "ar", "تيمور - ليشتي" },
        };
    }

    ///<summary>
    /// The class definition for country of Togo
    ///</summary>
    public class Togo : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TGO";
    
        /// <inheritDoc />
        public override int IsoCodeId => 768;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Togo" }, // Default to English as country name
            { "cn", "多哥" },
            { "ru", "Того" },
            { "fr", "Togo" },
            { "es", "Togo" },
            { "ar", "توغو" },
        };
    }

    ///<summary>
    /// The class definition for country of Tokelau
    ///</summary>
    public class Tokelau : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TK";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TKL";
    
        /// <inheritDoc />
        public override int IsoCodeId => 772;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Tokelau" }, // Default to English as country name
            { "cn", "托克劳" },
            { "ru", "Токелау" },
            { "fr", "Tokélaou" },
            { "es", "Tokelau" },
            { "ar", "توكيلاو" },
        };
    }

    ///<summary>
    /// The class definition for country of Tonga
    ///</summary>
    public class Tonga : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TO";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TON";
    
        /// <inheritDoc />
        public override int IsoCodeId => 776;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Tonga" }, // Default to English as country name
            { "cn", "汤加" },
            { "ru", "Тонга" },
            { "fr", "Tonga" },
            { "es", "Tonga" },
            { "ar", "تونغا" },
        };
    }

    ///<summary>
    /// The class definition for country of Trinidad and Tobago
    ///</summary>
    public class TrinidadAndTobago : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TT";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TTO";
    
        /// <inheritDoc />
        public override int IsoCodeId => 780;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Trinidad and Tobago" }, // Default to English as country name
            { "cn", "特立尼达和多巴哥" },
            { "ru", "Тринидад и Тобаго" },
            { "fr", "Trinité-et-Tobago" },
            { "es", "Trinidad y Tabago" },
            { "ar", "ترينيداد وتوباغو" },
        };
    }

    ///<summary>
    /// The class definition for country of Tunisia
    ///</summary>
    public class Tunisia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TUN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 788;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Tunisia" }, // Default to English as country name
            { "cn", "突尼斯" },
            { "ru", "Тунис" },
            { "fr", "Tunisie" },
            { "es", "Túnez" },
            { "ar", "تونس" },
        };
    }

    ///<summary>
    /// The class definition for country of Turkey
    ///</summary>
    public class Turkey : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TR";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TUR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 792;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Turkey" }, // Default to English as country name
            { "cn", "土耳其" },
            { "ru", "Турция" },
            { "fr", "Türkiye" },
            { "es", "Türkiye" },
            { "ar", "تركيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Turkmenistan
    ///</summary>
    public class Turkmenistan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TKM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 795;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Turkmenistan" }, // Default to English as country name
            { "cn", "土库曼斯坦" },
            { "ru", "Туркменистан" },
            { "fr", "Turkménistan" },
            { "es", "Turkmenistán" },
            { "ar", "تركمانستان" },
        };
    }

    ///<summary>
    /// The class definition for country of Turks and Caicos Islands
    ///</summary>
    public class TurksAndCaicosIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TC";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TCA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 796;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Turks and Caicos Islands" }, // Default to English as country name
            { "cn", "特克斯和凯科斯群岛" },
            { "ru", "Острова Теркс и Кайкос" },
            { "fr", "Îles Turques-et-Caïques" },
            { "es", "Islas Turcas y Caicos" },
            { "ar", "جزر تركس وكايكوس" },
        };
    }

    ///<summary>
    /// The class definition for country of Tuvalu
    ///</summary>
    public class Tuvalu : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TV";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TUV";
    
        /// <inheritDoc />
        public override int IsoCodeId => 798;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Tuvalu" }, // Default to English as country name
            { "cn", "图瓦卢" },
            { "ru", "Тувалу" },
            { "fr", "Tuvalu" },
            { "es", "Tuvalu" },
            { "ar", "توفالو" },
        };
    }

    ///<summary>
    /// The class definition for country of Uganda
    ///</summary>
    public class Uganda : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "UG";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "UGA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 800;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Uganda" }, // Default to English as country name
            { "cn", "乌干达" },
            { "ru", "Уганда" },
            { "fr", "Ouganda" },
            { "es", "Uganda" },
            { "ar", "أوغندا" },
        };
    }

    ///<summary>
    /// The class definition for country of Ukraine
    ///</summary>
    public class Ukraine : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "UA";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "UKR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 804;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Ukraine" }, // Default to English as country name
            { "cn", "乌克兰" },
            { "ru", "Украина" },
            { "fr", "Ukraine" },
            { "es", "Ucrania" },
            { "ar", "أوكرانيا" },
        };
    }

    ///<summary>
    /// The class definition for country of United Arab Emirates
    ///</summary>
    public class UnitedArabEmirates : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "AE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ARE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 784;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "United Arab Emirates" }, // Default to English as country name
            { "cn", "阿拉伯联合酋长国" },
            { "ru", "Объединенные Арабские Эмираты" },
            { "fr", "Émirats arabes unis" },
            { "es", "Emiratos Árabes Unidos" },
            { "ar", "الإمارات العربية المتحدة" },
        };
    }

    ///<summary>
    /// The class definition for country of United Kingdom of Great Britain and Northern Ireland
    ///</summary>
    public class UnitedKingdomOfGreatBritainAndNorthernIreland : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "GB";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "GBR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 826;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Europe;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "EU";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "United Kingdom of Great Britain and Northern Ireland" }, // Default to English as country name
            { "cn", "大不列颠及北爱尔兰联合王国" },
            { "ru", "Соединенное Королевство Великобритании и Северной Ирландии" },
            { "fr", "Royaume-Uni de Grande-Bretagne et d’Irlande du Nord" },
            { "es", "Reino Unido de Gran Bretaña e Irlanda del Norte" },
            { "ar", "المملكة المتحدة لبريطانيا العظمى وآيرلندا الشمالية" },
        };
    }

    ///<summary>
    /// The class definition for country of United Republic of Tanzania
    ///</summary>
    public class UnitedRepublicOfTanzania : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "TZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "TZA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 834;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "United Republic of Tanzania" }, // Default to English as country name
            { "cn", "坦桑尼亚联合共和国" },
            { "ru", "Объединенная Республика Танзания" },
            { "fr", "République-Unie de Tanzanie" },
            { "es", "República Unida de Tanzanía" },
            { "ar", "جمهورية تنزانيا المتحدة" },
        };
    }

    ///<summary>
    /// The class definition for country of United States Minor Outlying Islands
    ///</summary>
    public class UnitedStatesMinorOutlyingIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "UM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "UMI";
    
        /// <inheritDoc />
        public override int IsoCodeId => 581;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "United States Minor Outlying Islands" }, // Default to English as country name
            { "cn", "美国本土外小岛屿" },
            { "ru", "Внешние малые острова Соединенных Штатов" },
            { "fr", "Îles mineures éloignées des États-Unis" },
            { "es", "Islas menores alejadas de Estados Unidos" },
            { "ar", "نائية التابعة للولايات المتحدة" },
        };
    }

    ///<summary>
    /// The class definition for country of United States of America
    ///</summary>
    public class UnitedStatesOfAmerica : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "US";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "USA";
    
        /// <inheritDoc />
        public override int IsoCodeId => 840;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "United States of America" }, // Default to English as country name
            { "cn", "美利坚合众国" },
            { "ru", "Соединенные Штаты Америки" },
            { "fr", "États-Unis d’Amérique" },
            { "es", "Estados Unidos de América" },
            { "ar", "الولايات المتحدة الأمريكية" },
        };
    }

    ///<summary>
    /// The class definition for country of United States Virgin Islands
    ///</summary>
    public class UnitedStatesVirginIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "VI";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "VIR";
    
        /// <inheritDoc />
        public override int IsoCodeId => 850;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "NA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "United States Virgin Islands" }, // Default to English as country name
            { "cn", "美属维尔京群岛" },
            { "ru", "Виргинские острова Соединенных Штатов" },
            { "fr", "Îles Vierges américaines" },
            { "es", "Islas Vírgenes de los Estados Unidos" },
            { "ar", "جزر فرجن التابعة للولايات المتحدة" },
        };
    }

    ///<summary>
    /// The class definition for country of Uruguay
    ///</summary>
    public class Uruguay : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "UY";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "URY";
    
        /// <inheritDoc />
        public override int IsoCodeId => 858;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Uruguay" }, // Default to English as country name
            { "cn", "乌拉圭" },
            { "ru", "Уругвай" },
            { "fr", "Uruguay" },
            { "es", "Uruguay" },
            { "ar", "أوروغواي" },
        };
    }

    ///<summary>
    /// The class definition for country of Uzbekistan
    ///</summary>
    public class Uzbekistan : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "UZ";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "UZB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 860;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Uzbekistan" }, // Default to English as country name
            { "cn", "乌兹别克斯坦" },
            { "ru", "Узбекистан" },
            { "fr", "Ouzbékistan" },
            { "es", "Uzbekistán" },
            { "ar", "أوزبكستان" },
        };
    }

    ///<summary>
    /// The class definition for country of Vanuatu
    ///</summary>
    public class Vanuatu : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "VU";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "VUT";
    
        /// <inheritDoc />
        public override int IsoCodeId => 548;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Vanuatu" }, // Default to English as country name
            { "cn", "瓦努阿图" },
            { "ru", "Вануату" },
            { "fr", "Vanuatu" },
            { "es", "Vanuatu" },
            { "ar", "فانواتو" },
        };
    }

    ///<summary>
    /// The class definition for country of Venezuela (Bolivarian Republic of)
    ///</summary>
    public class Venezuela : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "VE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "VEN";
    
        /// <inheritDoc />
        public override int IsoCodeId => 862;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Americas;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "SA";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Venezuela (Bolivarian Republic of)" }, // Default to English as country name
            { "cn", "委内瑞拉玻利瓦尔共和国" },
            { "ru", "Венесуэла (Боливарианская Республика)" },
            { "fr", "Venezuela (République bolivarienne du)" },
            { "es", "Venezuela (República Bolivariana de)" },
            { "ar", "فنزويلا (جمهورية - البوليفارية)" },
        };
    }

    ///<summary>
    /// The class definition for country of Viet Nam
    ///</summary>
    public class VietNam : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "VN";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "VNM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 704;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Viet Nam" }, // Default to English as country name
            { "cn", "越南" },
            { "ru", "Вьетнам" },
            { "fr", "Viet Nam" },
            { "es", "Viet Nam" },
            { "ar", "فييت نام" },
        };
    }

    ///<summary>
    /// The class definition for country of Wallis and Futuna Islands
    ///</summary>
    public class WallisAndFutunaIslands : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "WF";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "WLF";
    
        /// <inheritDoc />
        public override int IsoCodeId => 876;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Oceania;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "OC";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Wallis and Futuna Islands" }, // Default to English as country name
            { "cn", "瓦利斯群岛和富图纳群岛" },
            { "ru", "Острова Уоллис и Футуна" },
            { "fr", "Îles Wallis-et-Futuna" },
            { "es", "Islas Wallis y Futuna" },
            { "ar", "جزر واليس وفوتونا" },
        };
    }

    ///<summary>
    /// The class definition for country of Western Sahara
    ///</summary>
    public class WesternSahara : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "EH";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ESH";
    
        /// <inheritDoc />
        public override int IsoCodeId => 732;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Western Sahara" }, // Default to English as country name
            { "cn", "西撒哈拉" },
            { "ru", "Западная Сахара" },
            { "fr", "Sahara occidental" },
            { "es", "Sáhara Occidental" },
            { "ar", "الصحراء الغربية" },
        };
    }

    ///<summary>
    /// The class definition for country of Yemen
    ///</summary>
    public class Yemen : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "YE";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "YEM";
    
        /// <inheritDoc />
        public override int IsoCodeId => 887;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Asia;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AS";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Yemen" }, // Default to English as country name
            { "cn", "也门" },
            { "ru", "Йемен" },
            { "fr", "Yémen" },
            { "es", "Yemen" },
            { "ar", "اليمن" },
        };
    }

    ///<summary>
    /// The class definition for country of Zambia
    ///</summary>
    public class Zambia : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ZM";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ZMB";
    
        /// <inheritDoc />
        public override int IsoCodeId => 894;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Zambia" }, // Default to English as country name
            { "cn", "赞比亚" },
            { "ru", "Замбия" },
            { "fr", "Zambie" },
            { "es", "Zambia" },
            { "ar", "زامبيا" },
        };
    }

    ///<summary>
    /// The class definition for country of Zimbabwe
    ///</summary>
    public class Zimbabwe : Country
    {
        /// <inheritDoc />
        public override string IsoCodeAlpha2 => "ZW";
        
        /// <inheritDoc />
        public override string IsoCodeAlpha3 => "ZWE";
    
        /// <inheritDoc />
        public override int IsoCodeId => 716;
    
        /// <inheritDoc />
        public override RegionsEnum RegionName => RegionsEnum.Africa;
    
        /// <inheritDoc />
        public override string TopLevelDomain => "AF";
    
        /// <inheritDoc />
        public override Dictionary<string, string> CountryNames => new()
        {
            { "en", "Zimbabwe" }, // Default to English as country name
            { "cn", "津巴布韦" },
            { "ru", "Зимбабве" },
            { "fr", "Zimbabwe" },
            { "es", "Zimbabwe" },
            { "ar", "زمبابوي" },
        };
    }
    
    ///<summary>
    /// The list of all available Earth regions
    ///</summary>
    public enum RegionsEnum {        
        ///<summary>
        /// Unknown region
        ///</summary>
        Unknown = 0,        
        ///<summary>
        /// The americas
        ///</summary>
        Americas = 1,      
        ///<summary>
        /// Africa
        ///</summary>
        Africa = 2,        
        ///<summary>
        /// Asia
        ///</summary>
        Asia = 3,        
        ///<summary>
        /// Europe
        ///</summary>
        Europe = 4,        
        ///<summary>
        /// Middle-East
        ///</summary>
        MiddleEast = 5,        
        ///<summary>
        /// Oceania
        ///</summary>
        Oceania = 6
    }
}