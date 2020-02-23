using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sip2Service.Utils
{
    public static class RichTextBoxExtension
    {
        public static void AppendTextColorful(this RichTextBox rtBox, string text, Color color, bool addNewLine = false)
        {
            if (addNewLine)
            {
                text += Environment.NewLine;
            }
            rtBox.SelectionStart = rtBox.TextLength;
            rtBox.SelectionLength = 0;
            rtBox.SelectionColor = color;
            rtBox.AppendText(text);
            rtBox.SelectionColor = rtBox.ForeColor;
        }
    }
}
