using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mammoth;


namespace word_to_html
{
    public partial class Form1 : Form
    {
        public string sborkaYoutube;
        public string html;
        public string nazvYtb;
        public string YtbZagolovok;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MS Word 2016 (*.docx)|*.docx";
            dialog.Title = "Выберите документ для загрузки данных";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
                var converter = new DocumentConverter();
                var result = converter.ConvertToHtml(dialog.FileName);
                html = result.Value; // The generated HTML

                string br1 = "<br /><br /><br />";
                string br2 = "<br />\n< br /> ";
                string br3 = "<br /></h2>";
                string br4 = "<br /><br />";
                string br5 = "<br />";
                html = html.Replace("</li>", "</li>\n").Replace("<ul>", "<ul>\n").Replace("<ol>", "<ol>\n").Replace("</p>", "\n\n").Replace("<p>", "").Replace("</ul>", "</ul>\n\n").Replace("</ol>", "</ol>\n\n").Replace("< br />", "").Replace("< br />", "").Replace("тысячей", "тысяч").Replace("привёдшее", "приведшее").Replace("</strong>: <strong>", ": ").Replace("<strong> </strong>", " ");
                if (chIfMfc.Checked == true)
                {
                    html = html.Replace("<strong>", "<h2>").Replace("</strong>", "</h2>\n\n").Replace("</h3>", "</h3>\n\n").Replace("</h1>", "\n\n").Replace("<h1>", "").Replace("</h2>", "</h2>\n\n").Replace("< br />", "");
                }
                else
                {
                    html = html.Replace("<strong>", "<h2>").Replace("</strong>", "</h2>\n\n").Replace(br1, " ").Replace(br4, "\n\n").Replace(br2, "\n\n").Replace(br3, "</h2>").Replace(br5, "");
                }

                html = html.Replace("<strong> </strong>", " ");

                //Блок Ютьюб
                string[] words = html.Split(' ');
                string s0 = words[1];
                string sCont = "href";
                bool b = s0.Contains(sCont);
                if (b)
                {
                    s0 = s0.Replace("<strong>", "").Replace("</strong>", "");
                }
                else
                {
                    s0 = html.Remove(html.IndexOf("\n"), html.Length - html.IndexOf("\n"));
                }
                //Search.q = html.Remove(html.IndexOf("\n"), html.Length - html.IndexOf("\n"));
                Search.q = s0;
                Search.YTBsearch();


                rtbYTBlist.Text = Search.listUrl;
                YtbZagolovok = $"<h3 style=\"text-align: center;\">{nazvYtb}</h3>\n";
                html += YtbZagolovok;
                html += sborkaYoutube;

                
             

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
            rtbYTBlist.Text = String.Empty;
            html = String.Empty;
            Search.q = String.Empty;
            YtbZagolovok = String.Empty;
            sborkaYoutube = String.Empty;
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void btnYtbIdAdd_Click(object sender, EventArgs e)
        {
            if (rbId1.Checked == true)
            {
                nazvYtb = Search.nazvSplit[0];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[0]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId2.Checked == true)
            {
                nazvYtb = Search.nazvSplit[1];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[1]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId3.Checked == true)
            {
                nazvYtb = Search.nazvSplit[2];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[2]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId4.Checked == true)
            {
                nazvYtb = Search.nazvSplit[3];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[3]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId5.Checked == true)
            {
                nazvYtb = Search.nazvSplit[4];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[4]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId6.Checked == true)
            {
                nazvYtb = Search.nazvSplit[5];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[5]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId7.Checked == true)
            {
                nazvYtb = Search.nazvSplit[6];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[6]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId8.Checked == true)
            {
                nazvYtb = Search.nazvSplit[7];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[7]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId9.Checked == true)
            {
                nazvYtb = Search.nazvSplit[8];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[8]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else if (rbId10.Checked == true)
            {
                nazvYtb = Search.nazvSplit[9];
                sborkaYoutube =
                    $"<iframe width=\"700\" height=\"400\" src=\"https://www.youtube.com/embed/{Search.idSplit[9]}\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>";
            }
            else
            {
                sborkaYoutube = null;
            }
            richTextBox1.Text = html;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
           //Блок Ютьюб
            string[] words = html.Split(' ');
            string s0 = words[1];
            string sCont = "href";
            bool b = s0.Contains(sCont);
            if (b)
            {
                s0 = s0.Replace("<strong>", "").Replace("</strong>", "");
            }
            else
            {
                s0 = html.Remove(html.IndexOf("\n"), html.Length - html.IndexOf("\n"));
            }
            //Search.q = html.Remove(html.IndexOf("\n"), html.Length - html.IndexOf("\n"));
            Search.q = s0;
            Search.YTBsearch();

            rtbYTBlist.Text = Search.listUrl;
            //string YtbZagolovok = $"<h3 style=\"text-align: center;\">{nazvYtb}</h3>\n";
            //html += YtbZagolovok;
            //html += sborkaYoutube;

            rtbYTBlist.Text = Search.listUrl;
            richTextBox1.Text = html;
        }
    }
}
