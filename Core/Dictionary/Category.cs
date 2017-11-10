using Xtrf.Common.Attribute;

namespace Xtrf.Core.Dictionary
{
    public class Category
    {
        public const string BILINGUAL_DOC = "BILINGUAL_DOC";
        public const string CAT_ANALYSIS = "CAT_ANALYSIS";
        public const string CAT_PACKAGE = "CAT_PACKAGE";
        public const string CAT_PACKAGE_RETURN = "CAT_PACKAGE_RETURN";
        public const string FILTERING_RULES = "FILTERING_RULES";
        public const string FORMATTED_DOCUMENT = "FORMATTED_DOCUMENT";
        public const string MEMOQ_LIGHT_RESOURCES = "MEMOQ_LIGHT_RESOURCES";
        public const string OTHER = "OTHER";
        public const string QA_REPORT = "QA_REPORT";
        public const string REFERENCE = "REFERENCE";
        public const string SEGMENTATION_RULES = "SEGMENTATION_RULES";
        public const string SOURCE_DOCUMENT = "SOURCE_DOCUMENT";
        public const string SOURCE_TO_BE_PREPARED = "SOURCE_TO_BE_PREPARED";
        public const string TERMINOLOGY = "TERMINOLOGY";
        public const string TM = "TM";
        public const string TRANSLATED_DOCUMENT = "TRANSLATED_DOCUMENT";
    }
    public enum FileCategory
    {
        [EnumName("BILINGUAL_DOC")]
        BILINGUAL_DOC,
        [EnumName("CAT_ANALYSIS")]
        CAT_ANALYSIS,
        [EnumName("CAT_PACKAGE")]
        CAT_PACKAGE,
        [EnumName("CAT_PACKAGE_RETURN")]
        CAT_PACKAGE_RETURN,
        [EnumName("FILTERING_RULES")]
        FILTERING_RULES,
        [EnumName("FORMATTED_DOCUMENT")]
        FORMATTED_DOCUMENT,
        [EnumName("MEMOQ_LIGHT_RESOURCES")]
        MEMOQ_LIGHT_RESOURCES,
        [EnumName("OTHER")]
        OTHER,
        [EnumName("QA_REPORT")]
        QA_REPORT,
        [EnumName("REFERENCE")]
        REFERENCE,
        [EnumName("SEGMENTATION_RULES")]
        SEGMENTATION_RULES,
        [EnumName("SOURCE_DOCUMENT")]
        SOURCE_DOCUMENT,
        [EnumName("SOURCE_TO_BE_PREPARED")]
        SOURCE_TO_BE_PREPARED,
        [EnumName("TERMINOLOGY")]
        TERMINOLOGY,
        [EnumName("TM")]
        TM,
        [EnumName("TRANSLATED_DOCUMENT")]
        TRANSLATED_DOCUMENT
    }
}
