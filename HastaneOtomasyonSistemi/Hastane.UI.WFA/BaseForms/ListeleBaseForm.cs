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

namespace Hastane.UI.WFA.BaseForms
{
    public partial class ListeleBaseForm<T> : EkleBaseForm
       where T : HastaneBC
    {
        protected T BaseClass;
        public ListeleBaseForm()
        {
            InitializeComponent();
        }
    }
}
