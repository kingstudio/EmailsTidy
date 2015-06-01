using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public class MySorter : System.Collections.Generic.IComparer<ListViewItem>
    {
        public SortOrder SortOrder = SortOrder.None;
        public int ColumnIndex = -1;



        #region IComparer<ListViewItem> 成员

        public int Compare(ListViewItem x, ListViewItem y)
        {
            ListViewItem hLeft = x;
            ListViewItem hRiht = y;

            if (SortOrder == SortOrder.Ascending && (ColumnIndex >= 0) && (ColumnIndex < hLeft.SubItems.Count))
            {
                string sx = hLeft.SubItems[ColumnIndex].Text;
                string sy = hRiht.SubItems[ColumnIndex].Text;
                return sx.CompareTo(sy);
            }
            if (SortOrder == SortOrder.Descending && (ColumnIndex >= 0) && (ColumnIndex < hLeft.SubItems.Count))
            {
                string sx = hLeft.SubItems[ColumnIndex].Text;
                string sy = hRiht.SubItems[ColumnIndex].Text;
                return sy.CompareTo(sx);
            }
            return 0;
        }

        #endregion
    }
}
