using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserOneLibrary.Adapter
{
    public interface IAdapter 
    {
        public void Connect();
        public void IsConnected();
        public void Disconnect();
    }
}
