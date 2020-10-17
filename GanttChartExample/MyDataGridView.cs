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
            //this.Paint += MyDataGridView_Paint;
            //this.Resize += MyDataGridView_Resize;
            //ScrollBars = ScrollBars.Horizontal;
        }

        public void SetVScrollHide()
        {
            this.VerticalScrollBar.Hide();
        }

        public void SetVScrollWidth(int i)
        {
            this.VerticalScrollBar.Width = i;
        }

        private void MyDataGridView_Resize(object sender, EventArgs e)
        {
            //this.VerticalScrollBar.Width = 1;
            //this.VerticalScrollBar.Hide();
        }

        private void MyDataGridView_Paint(object sender, PaintEventArgs e)
        {
            //this.VerticalScrollBar.Width = 1;
            //this.VerticalScrollBar.Hide();
        }

        private void VerticalScrollBar_ValueChanged(object sender, EventArgs e)
        {
            //this.VerticalScrollBar.Width = 1;
            //this.VerticalScrollBar.Hide();
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
