using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parts4U
{
    static class UIHelper
    {
        /// <summary>
        ///  methods for update of controls handled by other thread
        /// </summary>
        /// <param name="value"></param>
        /// <param name="control"></param>
        public static void ChangeText(string value, Control control)
        {
            if (control != null)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new Action<string, Control>(ChangeText), new object[] { value, control });
                    return;
                }
                control.Text = value;
            }
        }

        public static void AppendToTextBox(string value, RichTextBox tb)
        {
            if (tb.InvokeRequired)
            {
                tb.Invoke(new Action<string, RichTextBox>(AppendToTextBox), new object[] { value, tb });
                return;
            }
            tb.AppendText(value);
        }

        public static void AppendToListBox(string value, ListBox lb)
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new Action<string, ListBox>(AppendToListBox), new object[] { value, lb });
                return;
            }
            lb.Items.Add(value);
        }

        public static void ChangeFontColor(Color color, Control control)
        {
            if (control != null)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new Action<Color, Control>(ChangeFontColor), new object[] { control, color });
                    return;
                }
                control.ForeColor = color;
            }
        }

        public static void FillStockGridWithList (List<string> source, DataGridView dgv)
        {
            if (dgv.InvokeRequired)
            {
                dgv.Invoke(new Action<List<string>, DataGridView>(FillStockGridWithList), new object[] { source, dgv });
                return;
            }
            dgv.DataSource = (from d in source orderby d select new { d }).ToList();
        }

        public static void FillStockGrid(Dictionary<string, int> source, DataGridView dgv)
        {
            if (dgv.InvokeRequired)
            {
                dgv.Invoke(new Action<Dictionary<string, int>, DataGridView>(FillStockGrid), new object[] { source, dgv });
                return;
            }
            dgv.DataSource = (from d in source orderby d.Key select new { d.Key, d.Value }).ToList();
        }

        public static void FillStockGridWithTouple(Dictionary<string, Tuple<string, int>> source, DataGridView dgv)
        {
            if (dgv.InvokeRequired)
            {
                dgv.Invoke(new Action<Dictionary<string, Tuple<string, int>>, DataGridView>(FillStockGridWithTouple), new object[] { source, dgv });
                return;
            }
            dgv.DataSource = (from sts in source orderby sts.Key select new { sts.Key, sts.Value.Item1, sts.Value.Item2}).ToList();
        }
    }
}
