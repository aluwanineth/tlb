using Mandates.Screen.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandates.Screen.UI
{
    public partial class FMandatesDetails : Form
    {
        private string _url;
        private string _caption;
        public FMandatesDetails(string url, string caption)
        {
            _url = url;
            _caption = caption;
            InitializeComponent();
        }

        private void FMandatesDetails_Load(object sender, EventArgs e)
        {
            wbMandateDetails.Url = new Uri(_url);
            
        }

        private void FMandatesDetails_Shown(object sender, EventArgs e)
        {
            Text = _caption;
        }
    }
}
