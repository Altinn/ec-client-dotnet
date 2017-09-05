using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Configuration
{
    public class ApiEnvironment : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name => this["name"] as string;
        [ConfigurationProperty("address", IsRequired = false)]
        public string Environment => this["address"] as string;
    }
    public class ApiEnvironmentCollection : ConfigurationElementCollection
    {
        public ApiEnvironment this[int index]
        {
            get
            {
                return BaseGet(index) as ApiEnvironment;
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
            return new ApiEnvironment();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ApiEnvironment)element).Name + ((ApiEnvironment)element).Environment;
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

        [ConfigurationProperty("ApiEnvironmentCollection")]
        [ConfigurationCollection(typeof(ApiEnvironmentCollection), AddItemName = "ApiEnvironment")]
        public ApiEnvironmentCollection ApiEnvironmentCollection => this["ApiEnvironmentCollection"] as ApiEnvironmentCollection;
    }
}
