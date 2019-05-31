using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mandates.Screen.Contracts
{
    [Guid("7068AC34-DBB0-4e40-84A7-C2243355E2D7"),
    InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IMandateDetailScreen
    {
      //  [DispId(1)]
        void ShowMandateDetailScreen(string url);
        string ChangeFormCaption(string value);
    }
}
