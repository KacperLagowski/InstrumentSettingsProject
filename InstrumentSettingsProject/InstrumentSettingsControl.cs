using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RefDataExample;

namespace InstrumentSettingsProject
{
    public partial class InstrumentSettingsControl : UserControl
    {
        public List<BBInstrument> ErrorList { get; set; }
        public InstrumentSettingsControl()
        {
            InitializeComponent();
        }

        public void LoadErrorList()
        {
            this.objInstrument.Objects = 
        }
    }
}
