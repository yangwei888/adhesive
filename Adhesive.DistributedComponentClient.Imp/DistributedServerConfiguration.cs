using System.Linq;

using Adhesive.Common;
using Adhesive.Config;

namespace Adhesive.DistributedComponentClient
{
    public class DistributedServerConfiguration
    {
        internal static readonly string ModuleName = "分布式组件模块";
        private static IConfigService configService = LocalServiceLocator.GetService<IConfigService>();
        internal static ClientClusterConfiguration GetClientClusterConfiguration(string clusterName)
        {
            var clusters = GetConfig().ClientClusterConfigurations;
            return clusters.Values.ToList().FirstOrDefault(c => c.Name == clusterName);
        }

        private static DistributedServerConfigurationEntity GetConfig()
        {
            //var config = LocalConfigService.GetConfig(GetDefaultConfig());
            var defaultConfig = GetDefaultConfig();
            var config = configService.GetConfigItemValue(true, "DistributedServerComponentConfiguration", defaultConfig);
            return config;
        }

        private static DistributedServerConfigurationEntity GetDefaultConfig()
        {
            return new DistributedServerConfigurationEntity
            {
                ClientClusterConfigurations = new SerializableDictionary<string, ClientClusterConfiguration>
                {     
                    {"TestMemcachedCluster", 
                        new ClientClusterConfiguration
                        {
                            Name = "TestMemcachedCluster",
                            ClientNodeConfigurations = new SerializableDictionary<string, ClientNodeConfiguration>
                            {
                                {"MemcachedNode1", 
                                new ClientNodeConfiguration
                                {
                                    Name = "MemcachedNode1",
                                    Address = "192.168.1.204:11212",      
                                }},
                                {"MemcachedNode2",
                                new ClientNodeConfiguration
                                {
                                    Name = "MemcachedNode2",
                                    Address = "192.168.1.204:11213",
                                }},
                            },
                        }
                    },
                    {"AdhesiveMemcached", 
                        new ClientClusterConfiguration
                        {
                            Name = "AdhesiveMemcached",
                            ClientNodeConfigurations = new SerializableDictionary<string, ClientNodeConfiguration>
                            {
                                {"MemcachedNode1", 
                                new ClientNodeConfiguration
                                {
                                    Name = "MemcachedNode1",
                                    Address = "192.168.1.204:11212",      
                                }},
                                {"MemcachedNode2",
                                new ClientNodeConfiguration
                                {
                                    Name = "MemcachedNode2",
                                    Address = "192.168.1.204:11213",
                                }},
                            },
                        }
                    }
                },
            };
        }
    }
}
