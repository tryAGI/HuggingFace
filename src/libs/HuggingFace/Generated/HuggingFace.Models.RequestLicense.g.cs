
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The license of the repository. You can select 'Other' if your license is not in the list
    /// </summary>
    public enum RequestLicense
    {
        /// <summary>
        /// 
        /// </summary>
        Apache20,
        /// <summary>
        /// 
        /// </summary>
        Mit,
        /// <summary>
        /// 
        /// </summary>
        Openrail,
        /// <summary>
        /// 
        /// </summary>
        BigscienceOpenrailM,
        /// <summary>
        /// 
        /// </summary>
        CreativemlOpenrailM,
        /// <summary>
        /// 
        /// </summary>
        BigscienceBloomRail10,
        /// <summary>
        /// 
        /// </summary>
        BigcodeOpenrailM,
        /// <summary>
        /// 
        /// </summary>
        Afl30,
        /// <summary>
        /// 
        /// </summary>
        Artistic20,
        /// <summary>
        /// 
        /// </summary>
        Bsl10,
        /// <summary>
        /// 
        /// </summary>
        Bsd,
        /// <summary>
        /// 
        /// </summary>
        Bsd2Clause,
        /// <summary>
        /// 
        /// </summary>
        Bsd3Clause,
        /// <summary>
        /// 
        /// </summary>
        Bsd3ClauseClear,
        /// <summary>
        /// 
        /// </summary>
        CUda,
        /// <summary>
        /// 
        /// </summary>
        Cc,
        /// <summary>
        /// 
        /// </summary>
        Cc010,
        /// <summary>
        /// 
        /// </summary>
        CcBy20,
        /// <summary>
        /// 
        /// </summary>
        CcBy25,
        /// <summary>
        /// 
        /// </summary>
        CcBy30,
        /// <summary>
        /// 
        /// </summary>
        CcBy40,
        /// <summary>
        /// 
        /// </summary>
        CcBySa30,
        /// <summary>
        /// 
        /// </summary>
        CcBySa40,
        /// <summary>
        /// 
        /// </summary>
        CcByNc20,
        /// <summary>
        /// 
        /// </summary>
        CcByNc30,
        /// <summary>
        /// 
        /// </summary>
        CcByNc40,
        /// <summary>
        /// 
        /// </summary>
        CcByNd40,
        /// <summary>
        /// 
        /// </summary>
        CcByNcNd30,
        /// <summary>
        /// 
        /// </summary>
        CcByNcNd40,
        /// <summary>
        /// 
        /// </summary>
        CcByNcSa20,
        /// <summary>
        /// 
        /// </summary>
        CcByNcSa30,
        /// <summary>
        /// 
        /// </summary>
        CcByNcSa40,
        /// <summary>
        /// 
        /// </summary>
        CdlaSharing10,
        /// <summary>
        /// 
        /// </summary>
        CdlaPermissive10,
        /// <summary>
        /// 
        /// </summary>
        CdlaPermissive20,
        /// <summary>
        /// 
        /// </summary>
        Wtfpl,
        /// <summary>
        /// 
        /// </summary>
        Ecl20,
        /// <summary>
        /// 
        /// </summary>
        Epl10,
        /// <summary>
        /// 
        /// </summary>
        Epl20,
        /// <summary>
        /// 
        /// </summary>
        Etalab20,
        /// <summary>
        /// 
        /// </summary>
        Eupl11,
        /// <summary>
        /// 
        /// </summary>
        Eupl12,
        /// <summary>
        /// 
        /// </summary>
        Agpl30,
        /// <summary>
        /// 
        /// </summary>
        Gfdl,
        /// <summary>
        /// 
        /// </summary>
        Gpl,
        /// <summary>
        /// 
        /// </summary>
        Gpl20,
        /// <summary>
        /// 
        /// </summary>
        Gpl30,
        /// <summary>
        /// 
        /// </summary>
        Lgpl,
        /// <summary>
        /// 
        /// </summary>
        Lgpl21,
        /// <summary>
        /// 
        /// </summary>
        Lgpl30,
        /// <summary>
        /// 
        /// </summary>
        Isc,
        /// <summary>
        /// 
        /// </summary>
        HResearch,
        /// <summary>
        /// 
        /// </summary>
        IntelResearch,
        /// <summary>
        /// 
        /// </summary>
        Lppl13c,
        /// <summary>
        /// 
        /// </summary>
        MsPl,
        /// <summary>
        /// 
        /// </summary>
        AppleAscl,
        /// <summary>
        /// 
        /// </summary>
        AppleAmlr,
        /// <summary>
        /// 
        /// </summary>
        Mpl20,
        /// <summary>
        /// 
        /// </summary>
        OdcBy,
        /// <summary>
        /// 
        /// </summary>
        Odbl,
        /// <summary>
        /// 
        /// </summary>
        Openmdw10,
        /// <summary>
        /// 
        /// </summary>
        OpenrailPlusPlus,
        /// <summary>
        /// 
        /// </summary>
        Osl30,
        /// <summary>
        /// 
        /// </summary>
        Postgresql,
        /// <summary>
        /// 
        /// </summary>
        Ofl11,
        /// <summary>
        /// 
        /// </summary>
        Ncsa,
        /// <summary>
        /// 
        /// </summary>
        Unlicense,
        /// <summary>
        /// 
        /// </summary>
        Zlib,
        /// <summary>
        /// 
        /// </summary>
        Pddl,
        /// <summary>
        /// 
        /// </summary>
        LgplLr,
        /// <summary>
        /// 
        /// </summary>
        DeepfloydIfLicense,
        /// <summary>
        /// 
        /// </summary>
        FairNoncommercialResearchLicense,
        /// <summary>
        /// 
        /// </summary>
        Llama2,
        /// <summary>
        /// 
        /// </summary>
        Llama3,
        /// <summary>
        /// 
        /// </summary>
        Llama31,
        /// <summary>
        /// 
        /// </summary>
        Llama32,
        /// <summary>
        /// 
        /// </summary>
        Llama33,
        /// <summary>
        /// 
        /// </summary>
        Llama4,
        /// <summary>
        /// 
        /// </summary>
        Grok2Community,
        /// <summary>
        /// 
        /// </summary>
        Gemma,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestLicenseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestLicense value)
        {
            return value switch
            {
                RequestLicense.Apache20 => "apache-2.0",
                RequestLicense.Mit => "mit",
                RequestLicense.Openrail => "openrail",
                RequestLicense.BigscienceOpenrailM => "bigscience-openrail-m",
                RequestLicense.CreativemlOpenrailM => "creativeml-openrail-m",
                RequestLicense.BigscienceBloomRail10 => "bigscience-bloom-rail-1.0",
                RequestLicense.BigcodeOpenrailM => "bigcode-openrail-m",
                RequestLicense.Afl30 => "afl-3.0",
                RequestLicense.Artistic20 => "artistic-2.0",
                RequestLicense.Bsl10 => "bsl-1.0",
                RequestLicense.Bsd => "bsd",
                RequestLicense.Bsd2Clause => "bsd-2-clause",
                RequestLicense.Bsd3Clause => "bsd-3-clause",
                RequestLicense.Bsd3ClauseClear => "bsd-3-clause-clear",
                RequestLicense.CUda => "c-uda",
                RequestLicense.Cc => "cc",
                RequestLicense.Cc010 => "cc0-1.0",
                RequestLicense.CcBy20 => "cc-by-2.0",
                RequestLicense.CcBy25 => "cc-by-2.5",
                RequestLicense.CcBy30 => "cc-by-3.0",
                RequestLicense.CcBy40 => "cc-by-4.0",
                RequestLicense.CcBySa30 => "cc-by-sa-3.0",
                RequestLicense.CcBySa40 => "cc-by-sa-4.0",
                RequestLicense.CcByNc20 => "cc-by-nc-2.0",
                RequestLicense.CcByNc30 => "cc-by-nc-3.0",
                RequestLicense.CcByNc40 => "cc-by-nc-4.0",
                RequestLicense.CcByNd40 => "cc-by-nd-4.0",
                RequestLicense.CcByNcNd30 => "cc-by-nc-nd-3.0",
                RequestLicense.CcByNcNd40 => "cc-by-nc-nd-4.0",
                RequestLicense.CcByNcSa20 => "cc-by-nc-sa-2.0",
                RequestLicense.CcByNcSa30 => "cc-by-nc-sa-3.0",
                RequestLicense.CcByNcSa40 => "cc-by-nc-sa-4.0",
                RequestLicense.CdlaSharing10 => "cdla-sharing-1.0",
                RequestLicense.CdlaPermissive10 => "cdla-permissive-1.0",
                RequestLicense.CdlaPermissive20 => "cdla-permissive-2.0",
                RequestLicense.Wtfpl => "wtfpl",
                RequestLicense.Ecl20 => "ecl-2.0",
                RequestLicense.Epl10 => "epl-1.0",
                RequestLicense.Epl20 => "epl-2.0",
                RequestLicense.Etalab20 => "etalab-2.0",
                RequestLicense.Eupl11 => "eupl-1.1",
                RequestLicense.Eupl12 => "eupl-1.2",
                RequestLicense.Agpl30 => "agpl-3.0",
                RequestLicense.Gfdl => "gfdl",
                RequestLicense.Gpl => "gpl",
                RequestLicense.Gpl20 => "gpl-2.0",
                RequestLicense.Gpl30 => "gpl-3.0",
                RequestLicense.Lgpl => "lgpl",
                RequestLicense.Lgpl21 => "lgpl-2.1",
                RequestLicense.Lgpl30 => "lgpl-3.0",
                RequestLicense.Isc => "isc",
                RequestLicense.HResearch => "h-research",
                RequestLicense.IntelResearch => "intel-research",
                RequestLicense.Lppl13c => "lppl-1.3c",
                RequestLicense.MsPl => "ms-pl",
                RequestLicense.AppleAscl => "apple-ascl",
                RequestLicense.AppleAmlr => "apple-amlr",
                RequestLicense.Mpl20 => "mpl-2.0",
                RequestLicense.OdcBy => "odc-by",
                RequestLicense.Odbl => "odbl",
                RequestLicense.Openmdw10 => "openmdw-1.0",
                RequestLicense.OpenrailPlusPlus => "openrail++",
                RequestLicense.Osl30 => "osl-3.0",
                RequestLicense.Postgresql => "postgresql",
                RequestLicense.Ofl11 => "ofl-1.1",
                RequestLicense.Ncsa => "ncsa",
                RequestLicense.Unlicense => "unlicense",
                RequestLicense.Zlib => "zlib",
                RequestLicense.Pddl => "pddl",
                RequestLicense.LgplLr => "lgpl-lr",
                RequestLicense.DeepfloydIfLicense => "deepfloyd-if-license",
                RequestLicense.FairNoncommercialResearchLicense => "fair-noncommercial-research-license",
                RequestLicense.Llama2 => "llama2",
                RequestLicense.Llama3 => "llama3",
                RequestLicense.Llama31 => "llama3.1",
                RequestLicense.Llama32 => "llama3.2",
                RequestLicense.Llama33 => "llama3.3",
                RequestLicense.Llama4 => "llama4",
                RequestLicense.Grok2Community => "grok2-community",
                RequestLicense.Gemma => "gemma",
                RequestLicense.Unknown => "unknown",
                RequestLicense.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestLicense? ToEnum(string value)
        {
            return value switch
            {
                "apache-2.0" => RequestLicense.Apache20,
                "mit" => RequestLicense.Mit,
                "openrail" => RequestLicense.Openrail,
                "bigscience-openrail-m" => RequestLicense.BigscienceOpenrailM,
                "creativeml-openrail-m" => RequestLicense.CreativemlOpenrailM,
                "bigscience-bloom-rail-1.0" => RequestLicense.BigscienceBloomRail10,
                "bigcode-openrail-m" => RequestLicense.BigcodeOpenrailM,
                "afl-3.0" => RequestLicense.Afl30,
                "artistic-2.0" => RequestLicense.Artistic20,
                "bsl-1.0" => RequestLicense.Bsl10,
                "bsd" => RequestLicense.Bsd,
                "bsd-2-clause" => RequestLicense.Bsd2Clause,
                "bsd-3-clause" => RequestLicense.Bsd3Clause,
                "bsd-3-clause-clear" => RequestLicense.Bsd3ClauseClear,
                "c-uda" => RequestLicense.CUda,
                "cc" => RequestLicense.Cc,
                "cc0-1.0" => RequestLicense.Cc010,
                "cc-by-2.0" => RequestLicense.CcBy20,
                "cc-by-2.5" => RequestLicense.CcBy25,
                "cc-by-3.0" => RequestLicense.CcBy30,
                "cc-by-4.0" => RequestLicense.CcBy40,
                "cc-by-sa-3.0" => RequestLicense.CcBySa30,
                "cc-by-sa-4.0" => RequestLicense.CcBySa40,
                "cc-by-nc-2.0" => RequestLicense.CcByNc20,
                "cc-by-nc-3.0" => RequestLicense.CcByNc30,
                "cc-by-nc-4.0" => RequestLicense.CcByNc40,
                "cc-by-nd-4.0" => RequestLicense.CcByNd40,
                "cc-by-nc-nd-3.0" => RequestLicense.CcByNcNd30,
                "cc-by-nc-nd-4.0" => RequestLicense.CcByNcNd40,
                "cc-by-nc-sa-2.0" => RequestLicense.CcByNcSa20,
                "cc-by-nc-sa-3.0" => RequestLicense.CcByNcSa30,
                "cc-by-nc-sa-4.0" => RequestLicense.CcByNcSa40,
                "cdla-sharing-1.0" => RequestLicense.CdlaSharing10,
                "cdla-permissive-1.0" => RequestLicense.CdlaPermissive10,
                "cdla-permissive-2.0" => RequestLicense.CdlaPermissive20,
                "wtfpl" => RequestLicense.Wtfpl,
                "ecl-2.0" => RequestLicense.Ecl20,
                "epl-1.0" => RequestLicense.Epl10,
                "epl-2.0" => RequestLicense.Epl20,
                "etalab-2.0" => RequestLicense.Etalab20,
                "eupl-1.1" => RequestLicense.Eupl11,
                "eupl-1.2" => RequestLicense.Eupl12,
                "agpl-3.0" => RequestLicense.Agpl30,
                "gfdl" => RequestLicense.Gfdl,
                "gpl" => RequestLicense.Gpl,
                "gpl-2.0" => RequestLicense.Gpl20,
                "gpl-3.0" => RequestLicense.Gpl30,
                "lgpl" => RequestLicense.Lgpl,
                "lgpl-2.1" => RequestLicense.Lgpl21,
                "lgpl-3.0" => RequestLicense.Lgpl30,
                "isc" => RequestLicense.Isc,
                "h-research" => RequestLicense.HResearch,
                "intel-research" => RequestLicense.IntelResearch,
                "lppl-1.3c" => RequestLicense.Lppl13c,
                "ms-pl" => RequestLicense.MsPl,
                "apple-ascl" => RequestLicense.AppleAscl,
                "apple-amlr" => RequestLicense.AppleAmlr,
                "mpl-2.0" => RequestLicense.Mpl20,
                "odc-by" => RequestLicense.OdcBy,
                "odbl" => RequestLicense.Odbl,
                "openmdw-1.0" => RequestLicense.Openmdw10,
                "openrail++" => RequestLicense.OpenrailPlusPlus,
                "osl-3.0" => RequestLicense.Osl30,
                "postgresql" => RequestLicense.Postgresql,
                "ofl-1.1" => RequestLicense.Ofl11,
                "ncsa" => RequestLicense.Ncsa,
                "unlicense" => RequestLicense.Unlicense,
                "zlib" => RequestLicense.Zlib,
                "pddl" => RequestLicense.Pddl,
                "lgpl-lr" => RequestLicense.LgplLr,
                "deepfloyd-if-license" => RequestLicense.DeepfloydIfLicense,
                "fair-noncommercial-research-license" => RequestLicense.FairNoncommercialResearchLicense,
                "llama2" => RequestLicense.Llama2,
                "llama3" => RequestLicense.Llama3,
                "llama3.1" => RequestLicense.Llama31,
                "llama3.2" => RequestLicense.Llama32,
                "llama3.3" => RequestLicense.Llama33,
                "llama4" => RequestLicense.Llama4,
                "grok2-community" => RequestLicense.Grok2Community,
                "gemma" => RequestLicense.Gemma,
                "unknown" => RequestLicense.Unknown,
                "other" => RequestLicense.Other,
                _ => null,
            };
        }
    }
}