// ReSharper disable InconsistentNaming

namespace XmlSchema.FederalLaw223
{
    public interface ICodeNameXmlElement
    {
        string code { get; }
        string name { get; }
    }

    public partial class okdpProductType : ICodeNameXmlElement
    {
    }

    public partial class okpd2ProductType : ICodeNameXmlElement
    {
    }

    public partial class okvedProductType : ICodeNameXmlElement
    {
    }

    public partial class okved2ProductType : ICodeNameXmlElement
    {
    }

    public partial class okeiProductType : ICodeNameXmlElement
    {
    }
}