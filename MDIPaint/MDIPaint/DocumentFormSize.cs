using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class DocumentFormSize : Form
    {
        public DocumentFormSize()
        {
            InitializeComponent();
        }

        public int DocumentFormHeight
        {
            get => (int)textBoxHeight.Value;
            set => textBoxHeight.Value = value;
        }
        public int DocumentFormWidth
        {
            get => (int)textBoxWidth.Value;
            set => textBoxWidth.Value = value;
        }
    }
}
