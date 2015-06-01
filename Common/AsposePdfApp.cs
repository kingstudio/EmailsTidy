using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Pdf;
using System.Windows.Forms;

namespace Common
{
    public class AsposePdfApp
    {
        //Create pdf document
        Pdf oPdf;
        //Add a section into the pdf document
        Section oSec;

        TextInfo ti1;
        /// <summary>
        /// PDF作者
        /// </summary>
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        /// <summary>
        /// PDF主题
        /// </summary>
        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }


        public void Open()
        {
            oPdf = new Pdf();
            oSec = oPdf.Sections.Add();
            ti1 = new TextInfo();
            ti1.IsUnicode = true;
            ti1.FontName = "宋体";
            ti1.Alignment = AlignmentType.Center;
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="strFileName"></param>
        public void SaveAs(string strFileName)
        {
            oPdf.Save(strFileName);
        }

        #region 设置纸张
        public void setPaperSize(string papersize)
        {

            switch (papersize)
            {
                case "A4":
                    foreach (Section section in oPdf.Sections)
                    {
                        section.PageInfo.PageWidth = PageSize.A4Width;
                        section.PageInfo.PageHeight = PageSize.A4Height;
                        section.PageInfo.Margin.Top = float.Parse("35");
                        section.PageInfo.Margin.Bottom = float.Parse("35");
                        section.PageInfo.Margin.Left = float.Parse("35");
                        section.PageInfo.Margin.Right = float.Parse("25");
                    }
                    break;
                case "A4H"://A4横向
                    foreach (Section section in oPdf.Sections)
                    {
                        section.IsLandscape = true;
                        section.PageInfo.PageWidth = PageSize.A4Width;
                        section.PageInfo.PageHeight = PageSize.A4Height;
                        section.PageInfo.Margin.Top = float.Parse("35");
                        section.PageInfo.Margin.Bottom = float.Parse("35");
                        section.PageInfo.Margin.Left = float.Parse("35");
                        section.PageInfo.Margin.Right = float.Parse("25");
                    }
                    break;
            }
        }
        #endregion

        /// <summary>
        /// 添加内容
        /// </summary>
        /// <param name="strText"></param>
        public void InsertText(string strText, float conSize, bool conBold, string conAlign)
        {
            //Create a new text paragraph and pass the text to its constructor as argument
            Aspose.Pdf.Text t = new Aspose.Pdf.Text(strText);
            Console.WriteLine(strText);

            //Set the font size of the text in a text segment
            t.TextInfo.IsUnicode = true;
            t.TextInfo.FontName = "宋体";
            t.TextInfo.FontSize = conSize;
            t.TextInfo.IsTrueTypeFontBold = conBold;
            switch (conAlign)
            {
                case "left":
                    t.TextInfo.Alignment = AlignmentType.Left;
                    break;
                case "center":
                    t.TextInfo.Alignment = AlignmentType.Center;
                    break;
                case "right":
                    t.TextInfo.Alignment = AlignmentType.Right;
                    break;
                default:
                    t.TextInfo.Alignment = AlignmentType.Left;
                    break;
            }
            oSec.Paragraphs.Add(t);

        }
        public void insertTable(List<ListViewItem> Record)
        {
            //Instantiate a table object
            Table tab1 = new Table();

            //Add the table in paragraphs collection of the desired section
            oSec.Paragraphs.Add(tab1);

            //Set with column widths of the table
            tab1.ColumnWidths = "2cm 9cm 2cm 5cm 3cm 2cm 2cm 2.5cm";
            tab1.VerticalAlignment = VerticalAlignmentType.Center;

            //Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = new BorderInfo((int)BorderSide.All, 0.1F);

            //Set table border using another customized BorderInfo object
            tab1.Border = new BorderInfo((int)BorderSide.All, 1F);
            //Create MarginInfo object and set its left, bottom, right and top margins
            MarginInfo margin = new MarginInfo();
            margin.Top = 5f;
            margin.Left = 5f;
            margin.Right = 5f;
            margin.Bottom = 5f;
            //Set the default cell padding to the MarginInfo object
            tab1.DefaultCellPadding = margin;
            //Create rows in the table and then cells in the rows
            Row row1 = tab1.Rows.Add();
            row1.Cells.Add("ID", ti1);
            row1.Cells.Add("标题/内容", ti1);
            row1.Cells.Add("来文单位", ti1);
            row1.Cells.Add("编号", ti1);
            row1.Cells.Add("日期", ti1);
            row1.Cells.Add("处理人", ti1);
            row1.Cells.Add("数量/方式", ti1);
            row1.Cells.Add("回执签名", ti1);

            for (int i = 0; i < Record.Count; i++)
            {
                ListViewItem item = Record[i];
                writeRow(item, tab1);
            }
        }
        private void writeRow(ListViewItem item, Table tab1)
        {
            Row row1 = tab1.Rows.Add();
            row1.Cells.Add(item.SubItems[1].Text, ti1);
            row1.Cells.Add(item.SubItems[2].Text, ti1);
            row1.Cells.Add(item.SubItems[3].Text, ti1);
            row1.Cells.Add(item.SubItems[4].Text, ti1);
            row1.Cells.Add(item.SubItems[5].Text.Split(' ')[0], ti1);
            row1.Cells.Add(item.SubItems[6].Text, ti1);
            row1.Cells.Add("1邮件", ti1);
            row1.Cells.Add("", ti1);
        }

        public void SetFooter(string footerInfo)
        {

            //Instantiate HeaderFooter object and pass the Section reference in which
            //the header or footer is to be added
            HeaderFooter hf1 = new HeaderFooter(oSec);

            //Set the header of odd pages of the PDF document
            oSec.OddFooter = hf1;

            //Set the header of even pages of the PDF document
            oSec.EvenFooter = hf1;


            //Instantiate a Text paragraph that will store the content to show as header
            Aspose.Pdf.Text t = new Aspose.Pdf.Text(hf1, footerInfo + "                                     第 $p 页 / 共 $P 页");

            //Set the font size of the text in a text segment
            t.TextInfo.IsUnicode = true;
            t.TextInfo.FontName = "宋体";
            t.TextInfo.Alignment = AlignmentType.Left;
            //Add the text object to the Paragraphs collection of HeaderFooter object to
            //display header on the pages of PDF document
            hf1.Paragraphs.Add(t);

        }
    }
}
