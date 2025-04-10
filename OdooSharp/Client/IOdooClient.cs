using OdooSharp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdooSharp.Client
{
    public interface IOdooClient
    {
        Task<List<OdooModel>> GetModelsAsync();
        Task<OdooFieldsResponse> GetModelFieldsTypedAsync(string model);

        Task<JsonRpcResponse<int>> SearchReadCountAsync<T>();
        Task<JsonRpcResponse<T>> ReadById<T>(int id);
        Task<JsonRpcResponse<List<T>>> SearchReadAsync<T>(object[] domain = null, string[] fields = null, int limit = 100, int offset = 0, string order = null);
        Task<List<T>> SearchReadAllPagedAsync<T>(object[] domain = null, string[] fields = null, int pageSize = 100);
        Task<JsonRpcResponse<bool>> DeleteAsync<T>(int id);
    }
}
