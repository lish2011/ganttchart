using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewComboboxColumnTest
{
    public partial class MainForm : Form
    {
        private ComboBox cmb_Temp;
        public MainForm()
        {
            InitializeComponent();
        }

        //为窗体加载事件添加如下方法，其具体功能有详细说明：
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 绑定性别下拉列表框
            BindSex();
            //绑定数据表
            BindData();
            // 设置下拉列表框不可见
            cmb_Temp.Visible = false;
            cmb_Temp.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Temp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_Temp.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cmb_Temp.Margin = new Padding(0);
            // 添加下拉列表框事件
            cmb_Temp.SelectedIndexChanged += new EventHandler(cmb_Temp_SelectedIndexChanged);
            // 将下拉列表框加入到DataGridView控件中
            this.dgv_User.Controls.Add(cmb_Temp);
        }

        private void BindSex_()
        {
            DataTable dtSex = new DataTable();
            dtSex.Columns.Add("Value");
            dtSex.Columns.Add("Name");
            DataRow drSex;
            drSex = dtSex.NewRow();
            drSex[0] = "0";
            drSex[1] = "湖北";
            dtSex.Rows.Add(drSex);
            drSex = dtSex.NewRow();
            drSex[0] = "1";
            drSex[1] = "湖南";
            dtSex.Rows.Add(drSex);

            drSex = dtSex.NewRow();
            drSex[0] = "2";
            drSex[1] = "广东";
            dtSex.Rows.Add(drSex);

            drSex = dtSex.NewRow();
            drSex[0] = "3";
            drSex[1] = "福建";
            dtSex.Rows.Add(drSex);

            cmb_Temp.ValueMember = "Value";
            cmb_Temp.DisplayMember = "Name";
            cmb_Temp.DataSource = dtSex;
            cmb_Temp.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public DataTable dtSex;
        public DataTable dtData;

        private void BindSex()
        {
            dtSex = new DataTable();
            dtSex.Columns.Add("Value");
            dtSex.Columns.Add("Name");
            DataRow drSex;
            drSex = dtSex.NewRow();
            drSex[0] = "1";
            drSex[1] = "男";
            dtSex.Rows.Add(drSex);
            drSex = dtSex.NewRow();
            drSex[0] = "0";
            drSex[1] = "女";
            dtSex.Rows.Add(drSex);

            drSex = dtSex.NewRow();
            drSex[0] = "2";
            drSex[1] = "ss1";
            dtSex.Rows.Add(drSex);

            drSex = dtSex.NewRow();
            drSex[0] = "3";
            drSex[1] = "ss2";
            dtSex.Rows.Add(drSex);

            drSex = dtSex.NewRow();
            drSex[0] = "4";
            drSex[1] = "ss3";
            dtSex.Rows.Add(drSex);

            cmb_Temp = new ComboBox();
            cmb_Temp.SelectionChangeCommitted += Cmb_Temp_SelectionChangeCommitted;
            cmb_Temp.Validated += Cmb_Temp_Validated;
            cmb_Temp.ValueMember = "Value";
            cmb_Temp.DisplayMember = "Name";
            var bs = new BindingSource();
            bs.DataSource = dtSex;
            cmb_Temp.DataSource = dtSex; //bs;
            cmb_Temp.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmb_Temp.Items;
        }

        private void Cmb_Temp_Validated(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Cmb_Temp_Validated");
        }

        private void Cmb_Temp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Cmb_Temp_SelectionChangeCommitted");
        }

        //通常情况下我们都是从数据库中获取数据表（或者数据集），然后绑定到DataGridView中的，这里我们为了避免连接数据库，手中构造一个数据库表
        private void BindData()
        {
            dtData = new DataTable();
            dtData.Columns.Add("ID");
            dtData.Columns.Add("Name");
            dtData.Columns.Add("Sex");
            //dtData.Columns.Add("SexName");
            DataRow drData;
            drData = dtData.NewRow();
            drData[0] = 1;
            drData[1] = "张三";
            drData[2] = "0";
            //drData[3] = dtSex.Select($"Value = \'{drData[2]}'").FirstOrDefault()[1];
            dtData.Rows.Add(drData);
            drData = dtData.NewRow();
            drData[0] = 2;
            drData[1] = "李四";
            drData[2] = "1";
            //drData[3] = dtSex.Select($"Value = \'{drData[2]}'").FirstOrDefault()[1];
            dtData.Rows.Add(drData);
            drData = dtData.NewRow();
            drData[0] = 3;
            drData[1] = "王五";
            drData[2] = "1";
            //drData[3] = dtSex.Select($"Value = \'{drData[2]}'").FirstOrDefault()[1];
            dtData.Rows.Add(drData);
            drData = dtData.NewRow();
            drData[0] = 4;
            drData[1] = "小芳";
            drData[2] = "4";
            //drData[3] = dtSex.Select($"Value = \'{drData[2]}'").FirstOrDefault()[1];
            dtData.Rows.Add(drData);
            drData = dtData.NewRow();
            drData[0] = 5;
            drData[1] = "小娟";
            drData[2] = "3";
            //drData[3] = dtSex.Select($"Value = \'{drData[2]}'").FirstOrDefault()[1];
            dtData.Rows.Add(drData);
            drData = dtData.NewRow();
            drData[0] = 6;
            drData[1] = "赵六";
            drData[2] = "2";
            //drData[3] = dtSex.Select($"Value = \'{drData[2]}'").FirstOrDefault()[1];
            dtData.Rows.Add(drData);
            this.dgv_User.DataSource = dtData;

            InitComboBoxColumn();
        }

        public void InitComboBoxColumn()
        {
            System.Diagnostics.Debug.WriteLine("+++++++++");
            for (int i = 0; i < this.dgv_User.Rows.Count; i++)
            {
                if (dgv_User.Rows[i].Cells[2].Value != null && dgv_User.Rows[i].Cells[2].ColumnIndex == 2)
                {
                    dgv_User.Rows[i].Cells[2].Tag = dgv_User.Rows[i].Cells[2].Value.ToString();

                    var displayValue = GetDisplayValueBy(i);
                    if (displayValue != null)
                    {                       
                        dgv_User.Rows[i].Cells[2].Value = displayValue?.ToString();
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("displayValue == null ******");
                    }
                        
                }
            }
        }

        private void dgv_User_Scroll(object sender, ScrollEventArgs e)
        {
            this.cmb_Temp.Visible = false;
        }

        //当用户选择下拉列表框时改变DataGridView单元格的内容
        private void dgv_User_CurrentCellChanged_(object sender, EventArgs e)
        {
        }

        //当用户选择的单元格移动到性别这一列时，我们要显示下拉列表框，添加如下事件
        private void cmb_Temp_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"cmb_Temp_SelectedIndexChanged");
            //if (s.SelectedItem == null)
            //{
            //    return;
            //}
            //dgv_User.CurrentCell.Tag = (s.SelectedItem as DataRowView).Row.ItemArray[0];  // value 
            //dgv_User.CurrentCell.Value = (s.SelectedItem as DataRowView).Row.ItemArray[1];  // name 显示的值

            //var s = cmb_Temp;

            //if (s == null) return;
            //var dt = s.DataSource as DataTable;
            //var t = dt.Select($"Name = \'{s.Text}\'").AsEnumerable().FirstOrDefault()?["Value"];
            //if (t != null)
            //{
            //    dgv_User.CurrentCell.Tag = t;
            //    dgv_User.CurrentCell.Value = s.Text;
            //}

            //if (((ComboBox)sender).Text == "男")
            //{
            //    dgv_User.CurrentCell.Value = "男";
            //    dgv_User.CurrentCell.Tag = "1";
            //}
            //else
            //{
            //    dgv_User.CurrentCell.Value = "女";
            //    dgv_User.CurrentCell.Tag = "0";
            //}
        }
        
        private void dgv_User_CurrentCellChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"dgv_User_CellValidating");
        }

        private void SetInitValueComboBox(int defaultIndex)
        {
            cmb_Temp.Text = "";//defaultIndex;
        }

        //绑定数据表后将性别列中的每一单元格的Value和Tag属性（Tag为值文本，Value为显示文本）  // 为表格加载初始值
        private void dgv_User_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("+++++++++");
            //for (int i = 0; i < this.dgv_User.Rows.Count; i++)
            //{
            //    if (dgv_User.Rows[i].Cells[2].Value != null && dgv_User.Rows[i].Cells[2].ColumnIndex == 2)
            //    {
            //        dgv_User.Rows[i].Cells[2].Tag = dgv_User.Rows[i].Cells[2].Value.ToString();
                                 
            //        var displayValue = GetDisplayValueBy(i);
            //        if(displayValue != null)
            //            dgv_User.Rows[i].Cells[2].Value = displayValue?.ToString();
            //    }
            //}
        }

        //当需要将一个不为DataTable的可迭代的对象绑定到DataGridView时， 需要用到BindingSource.
        //如果这个可迭代对象是DataTable类型的，则不需要使用BingdingSource
        public object GetDisplayValueBy(int currentRowIndex )
        {
            //var srcDt = cmb_Temp.DataSource as DataTable;
            var valueId = dgv_User.Rows[currentRowIndex].Cells["Sex"].Value;
            var displayValue = dtSex.Select($"Value = \'{valueId}\'").FirstOrDefault()?["Name"];
            return displayValue;
        }

        private void dgv_User_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"dgv_User_CellEndEdit_R:{e.RowIndex}_C:{e.ColumnIndex}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_User_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"dgv_User_CellEnter_R:{e.RowIndex}_C:{e.ColumnIndex}");
            EditComboBox();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_User_CellLeave(object sender, DataGridViewCellEventArgs e)
        {     
            System.Diagnostics.Debug.WriteLine($"dgv_User_CellLeave_R:{e.RowIndex}_C:{e.ColumnIndex}");
            EndEditComboBox();
        }

        private void dgv_User_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"dgv_User_CellValidating_R:{e.RowIndex}_C:{e.ColumnIndex}");
        }

        private void dgv_User_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"dgv_User_CellPushed_R:{e.RowIndex}_C:{e.ColumnIndex}");
        }

        private void dgv_User_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"dgv_User_CellNeeded_R:{e.RowIndex}_C:{e.ColumnIndex}");
        }

        private void dgv_User_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"dgv_User_CellValidated_R:{e.RowIndex}_C:{e.ColumnIndex}");
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"comboBox1_Validated");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_User_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"########dgv_User_CellBeginEdit_R:{e.RowIndex}_C:{e.ColumnIndex}");
            //EditComboBox();
        }

        /// <summary>
        /// 
        /// </summary>
        private void EditComboBox()
        {
            try
            {
                if (this.dgv_User.CurrentCell?.ColumnIndex == 2)
                {
                    Rectangle rect = dgv_User.GetCellDisplayRectangle(dgv_User.CurrentCell.ColumnIndex, dgv_User.CurrentCell.RowIndex, false);
                    if (dgv_User.CurrentCell.Tag == null || dgv_User.CurrentCell.Value == null)
                    {
                        return;
                    }
                    string sexValue = dgv_User.CurrentCell.Value.ToString();
                    string sexTag = dgv_User.CurrentCell.Tag.ToString();

                    cmb_Temp.Text = sexValue;//defaultIndex;
                    cmb_Temp.SelectedValue = sexTag;

                    cmb_Temp.Left = rect.Left;
                    cmb_Temp.Top = rect.Top;
                    cmb_Temp.Width = rect.Width;
                    cmb_Temp.Height = rect.Height;
                    cmb_Temp.Visible = true;
                    
                    //cmb_Temp.Font = dgv_User.CurrentCell.Style.Font; //new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    ////cmb_Temp.Font = new System.Drawing.Font("宋体", System.Drawing.FontStyle.Regular);
                    //this.cmb_Temp.FormattingEnabled = true;
                    ////this.comboBox1.Location = new System.Drawing.Point(240, 395);
                    //this.cmb_Temp.Margin = new System.Windows.Forms.Padding(0);
                    ////this.comboBox1.Name = "comboBox1";
                    //this.cmb_Temp.Size = new System.Drawing.Size(rect.Width, rect.Height);
                }
                else
                {
                    try
                    {
                        cmb_Temp.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"cmb_Temp.Visible: {ex.Message}");
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void EndEditComboBox()
        {
            if (this.dgv_User.CurrentCell?.ColumnIndex == 2)
            {
                var s = cmb_Temp;
                if (s == null) return;
                var dt = s.DataSource as DataTable;
                var t = dt.Select($"Name = \'{s.Text}\'").AsEnumerable().FirstOrDefault()?["Value"];
                if (t != null)
                {
                    dgv_User.CurrentCell.Tag = t;
                    dgv_User.CurrentCell.Value = s.Text;
                }
            }
        }

        //无法调整高度
        private void dgv_User_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            this.cmb_Temp.Visible = false;
            System.Diagnostics.Debug.WriteLine($"dgv_User_RowHeightChanged");            
            EditComboBox();
        }

        //当滚动DataGridView或者改变DataGridView列宽时将下拉列表框设为不可见
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_User_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.cmb_Temp.Visible = false;
            System.Diagnostics.Debug.WriteLine($"dgv_User_ColumnWidthChanged");
            EditComboBox();
        }
    }
}
