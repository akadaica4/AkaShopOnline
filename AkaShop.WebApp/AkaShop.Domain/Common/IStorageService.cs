using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.Domain.Common
{
    public interface IStorageService
    {
        string GetFileUrl(string fileName);
        Task SaveFileAsync(Stream MediaBinaryStream, string fileName);
        Task DeleteFileAsync(string fileName);
    }
}
