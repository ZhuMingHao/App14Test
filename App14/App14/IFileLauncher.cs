using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public interface IFileLauncher
    {
        Task<bool> LaunchFileAsync(string uri);
    }
}
