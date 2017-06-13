using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace ReactSPACore.Data
{
    public interface IDapper
    {
        /// <summary>
        /// 增、删、改同步操作
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <param name="connection">链接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>int</returns>
        int ExcuteNonQuery(string connection, string cmd, DynamicParameters param, bool flag = false);

        /// <summary>
        /// 增、删、改异步操作
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <param name="connection">链接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>int</returns>
        Task<int> ExcuteNonQueryAsync(string connection, string cmd, DynamicParameters param, bool flag = false);

        /// <summary>
        /// 同步查询操作
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>object</returns>
        T ExecuteScalar<T>(string connection, string cmd, DynamicParameters param, bool flag = false);

        /// <summary>
        /// 同步查询一条数据
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        T GetOne<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new();

        /// <summary>
        /// 异步查询一条数据
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        Task<T> GetOneAsync<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new();

        /// <summary>
        /// 同步查询数据集合
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        IList<T> GetList<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new();

        /// <summary>
        /// 异步查询数据集合
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        Task<IList<T>> GetListAsync<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new();

        /// <summary>
        /// 同步查询数据集合
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        IList<T> GetListAsPage<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new();

        /// <summary>
        /// 同步分页查询数据集合
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        IList<T> GetListByPage<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new();

        /// <summary>
        /// 异步分页查询数据集合
        /// 作者： OR
        /// 2017-6-12
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        Task<IList<T>> GetListByPageAsync<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new();
    }
}