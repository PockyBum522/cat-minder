using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatMinder.Core.Interfaces
{
    public interface IToastMessage
    {
        void ShortToast(string message);
        void LongToast(string message);
    }
}
