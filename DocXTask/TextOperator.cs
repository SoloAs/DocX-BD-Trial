using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Novacode;

namespace DocXTask
{
    public class TextOperator
    {
        public string FileName { get; set; }
        public DocX Doc { get; set; }
        public Dictionary<string, string> Words { get; set; }
        public Person Head { get; set; }

        public TextOperator()
        {
            Words = new Dictionary<string, string>();
            Head = new Person();
        }


        /// <summary>
        /// Замена шаблонов на значения
        /// </summary>
        public void Replace()
        {
            
            Doc = DocX.Load(FileName);
            foreach (var word in Words)
            {
                Doc.ReplaceText('%' + word.Key + '%', word.Value, false, RegexOptions.IgnoreCase);
            }

            Doc.ReplaceText("%date%", System.DateTime.Now.ToShortDateString(), false, RegexOptions.IgnoreCase);

            Doc.ReplaceText("%head%", Head.Name, false, RegexOptions.IgnoreCase);
            Doc.ReplaceText("%head_position%", Head.PositionId, false, RegexOptions.IgnoreCase);

            Doc.ReplaceText("%head_phone%", Head.Phone, false, RegexOptions.IgnoreCase);

            FileName = FileName.Insert(FileName.Length - 5, "_updated");
            Doc.SaveAs(FileName);
            Doc.SaveAs("LastDocCopy"); 

            Process.Start("WINWORD.EXE", "LastDocCopy");
        }



    }
}
