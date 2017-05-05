using System.Collections.Generic;
using System.Configuration;
using ServiceStack.Redis;

namespace WidgetDemo.Context
{
    /// <summary>redis -Context  </summary>
    public class RedisContext
    {
        /// <summary> 单例 </summary>
        private static readonly RedisContext redisContext = new RedisContext();

        /// <summary>redis连接池</summary>
        private PooledRedisClientManager pooledClientManager;

        /// <summary>服务器可用地址集合 </summary>
        private List<string> serviceAvailableIpPool;

        /// <summary> 单例模式</summary>
        public static RedisContext Instance
        {
            get
            {
                return redisContext;
            }
        }

        /// <summary>
        /// 构造函数初始化redis日志
        /// </summary>
        private RedisContext()
        {
            string redisServiceIp = ConfigurationManager.AppSettings["RedisServiceIp"] ?? "10.1.56.177:6379";
            serviceAvailableIpPool = new List<string>(redisServiceIp.Split(','));
            pooledClientManager = new PooledRedisClientManager(serviceAvailableIpPool.ToArray());
        }

        /// <summary>向redis里添加数据</summary>
        /// <param name="key">键</param>
        /// <param name="value">数据</param>
        /// <returns>结果</returns>
        public bool AddRedis<T>(string key ,T value)
        {
            bool result = false;
            
            using (var client = pooledClientManager.GetClient())
            {
                result = client.Add(key, value);
            }
            return result;
        }

        /// <summary>获取redis值 </summary>
        /// <param name="key">键</param>
        /// <returns>结果</returns>
        public string GetRedis(string key)
        {
            string result = string.Empty;
            using (var client = pooledClientManager.GetClient())
            {
                result = client.Get<string>(key);
            }
            return result;
        }

        /// <summary>更新redis</summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns>结果</returns>
        public bool UpdateRedis<T>(string key, T value)
        {
            bool result = false;

            using (var client = pooledClientManager.GetClient())
            {
                result = client.Replace(key, value);
            }
            return result;
        }

        /// <summary>获取所有键</summary>
        /// <returns>结果</returns>
        public List<string> GetAllKey()
        {
            List<string> results = new List<string>();
            using (var client = pooledClientManager.GetClient())
            {
                results = client.GetAllKeys();
            }
            return results;
        }
    }
}
