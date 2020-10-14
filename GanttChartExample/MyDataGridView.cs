using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braincase.GanttChart
{
    public delegate void ScrollValueChangedEventHandler(object sender, EventArgs e);

    class MyDataGridView: DataGridView
    {
        public event ScrollValueChangedEventHandler ScrollValueChanged;

        public MyDataGridView()
        {
            this.VerticalScrollBar.ValueChanged += VerticalScrollBar_ValueChanged;
        }

        private void VerticalScrollBar_ValueChanged(object sender, EventArgs e)
        {
            ScrollValueChanged?.Invoke(sender, e);     
        }

        public int VScrollMaxValue
        {
            get => this.VerticalScrollBar.Maximum;
        }

        public int VScrollValue
        {
            get => this.VerticalScrollBar.Value;
        }

        public int VScrollMin => this.VerticalScrollBar.Minimum;
    }
}
