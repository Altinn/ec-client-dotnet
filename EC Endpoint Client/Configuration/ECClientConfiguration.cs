using System.Configuration;

namespace EC_Endpoint_Client.Configuration
{
    public class EnvironmentUrl : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name => this["name"] as string;
        [ConfigurationProperty("address", IsRequired = true)]
        public string Environment => this["address"] as string;
        [ConfigurationProperty("ignoreinwcf", IsRequired = false)]
        public bool? IgnoreInWcf => this["ignoreinwcf"] as bool?;
    }
    public class EnvironmentUrlCollection : ConfigurationElementCollection
    {
        public EnvironmentUrl this[int index]
        {
            get
            {
                return BaseGet(index) as EnvironmentUrl;
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }
        protected override ConfigurationElement CreateNewElement()
        {
            return new EnvironmentUrl();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((EnvironmentUrl)element).Name + ((EnvironmentUrl)element).Environment;
        }
    }

    public class EcClientConfiguration : ConfigurationSection
    {
        public static EcClientConfiguration GetConfig()
        {
            return
                (EcClientConfiguration)
                ConfigurationManager.GetSection("EcClientConfiguration") ??
                new EcClientConfiguration();
        }

        [ConfigurationProperty("EnvironmentUrlCollection")]
        [ConfigurationCollection(typeof(EnvironmentUrlCollection), AddItemName = "EnvironmentUrl")]
        public EnvironmentUrlCollection EnvironmentUrlCollection => this["EnvironmentUrlCollection"] as EnvironmentUrlCollection;
    }
}
