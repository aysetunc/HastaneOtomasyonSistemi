using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.Entities;
using Hastane.UI.WFA.BaseForms;

namespace Hastane.UI.WFA.HemsireForms
{
    public partial class HemsireListeleFormIntermediate : ListeleBaseForm<Hemsire>
    {
        public HemsireListeleFormIntermediate()
        {
            InitializeComponent();
            this.BaseClass = new Hemsire();
        }
    }
}
