using Mandates.Screen.Contracts;
using Mandates.Screen.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandates.Screen.Services
{
    [Guid("863AEADA-EE73-4f4a-ABC0-3FB384CB41AA"),
    ClassInterface(ClassInterfaceType.None)]
    public class MandateDetailScreen : IMandateDetailScreen
    {
        public string ChangeFormCaption(string value)
        {
            //throw new NotImplementedException();
            return value;
        }

        public void ShowMandateDetailScreen(string url)
        {
            FMandatesDetails fMandatesDetails = new FMandatesDetails(url);
            try
            {
                fMandatesDetails.ShowDialog();
            }
            catch(Exception ex)
            {
                string errorMessage = string.Format("Error: {0}", ex.Message);
                MessageBox.Show(errorMessage,"Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
