using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.TL.Common;

namespace WickedWebApi.BL.PopulateManager
{
    public interface IStudentsPopManager
    {
        GroupTable ReadGroups(string path);
        void AddGroups(GroupTable groupTable);
    }
}
