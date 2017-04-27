From: "Saved by Internet Explorer 11"
Subject: 
Date: Tue, 13 Dec 2016 19:52:54 -0000
MIME-Version: 1.0
Content-Type: text/html;
	charset="utf-8"
Content-Transfer-Encoding: quoted-printable
Content-Location: https://shuspace.shu.ac.uk/bbcswebdav/pid-6279005-dt-content-rid-12144535_2/courses/12-4304-00L-A-20167/MyDialogs.cs
X-MimeOLE: Produced By Microsoft MimeOLE V6.1.7601.23573

=EF=BB=BF<!DOCTYPE HTML>
<!DOCTYPE html PUBLIC "" ""><HTML><HEAD><META content=3D"IE=3D11.0000"=20
http-equiv=3D"X-UA-Compatible">

<META http-equiv=3D"Content-Type" content=3D"text/html; =
charset=3Dutf-8">
<META name=3D"GENERATOR" content=3D"MSHTML 11.00.9600.18525"></HEAD>
<BODY>
<PRE>using System;=0A=
using System.Collections.Generic;=0A=
using System.Linq;=0A=
using System.Text;=0A=
=0A=
using System.Windows.Forms;=0A=
using System.Drawing;=0A=
=0A=
namespace MyDialogs=0A=
{=0A=
    class My_Dialogs=0A=
    {=0A=
        public static string InputBox(string promptText)=0A=
        {=0A=
            string default_value =3D "";=0A=
=0A=
            return InputBox("", promptText, ref default_value);=0A=
        }=0A=
        public static string InputBox(string title, string promptText)=0A=
        {=0A=
            string default_value =3D "";=0A=
=0A=
            return InputBox(title, promptText, ref default_value);=0A=
        }=0A=
        public static string InputBox(string title, string promptText, =
ref string value)=0A=
        {=0A=
            Form form =3D new Form();=0A=
            Label label =3D new Label();=0A=
            TextBox textBox =3D new TextBox();=0A=
            Button buttonOk =3D new Button();=0A=
            Button buttonCancel =3D new Button();=0A=
=0A=
            form.Text =3D title;=0A=
            label.Text =3D promptText;=0A=
            textBox.Text =3D value;=0A=
=0A=
            buttonOk.Text =3D "OK";=0A=
            buttonCancel.Text =3D "Cancel";=0A=
            buttonOk.DialogResult =3D DialogResult.OK;=0A=
            buttonCancel.DialogResult =3D DialogResult.Cancel;=0A=
=0A=
            label.SetBounds(9, 20, 372, 13);=0A=
            textBox.SetBounds(12, 36, 372, 20);=0A=
            buttonOk.SetBounds(228, 72, 75, 23);=0A=
            buttonCancel.SetBounds(309, 72, 75, 23);=0A=
=0A=
            label.AutoSize =3D true;=0A=
            textBox.Anchor =3D textBox.Anchor | AnchorStyles.Right;=0A=
            buttonOk.Anchor =3D AnchorStyles.Bottom | AnchorStyles.Right;=0A=
            buttonCancel.Anchor =3D AnchorStyles.Bottom | =
AnchorStyles.Right;=0A=
=0A=
            form.ClientSize =3D new Size(396, 107);=0A=
            form.Controls.AddRange(new Control[] { label, textBox, =
buttonOk, buttonCancel });=0A=
            form.ClientSize =3D new Size(Math.Max(300, label.Right + =
10), form.ClientSize.Height);=0A=
            form.FormBorderStyle =3D FormBorderStyle.FixedDialog;=0A=
            form.StartPosition =3D FormStartPosition.CenterScreen;=0A=
            form.MinimizeBox =3D false;=0A=
            form.MaximizeBox =3D false;=0A=
            form.AcceptButton =3D buttonOk;=0A=
            form.CancelButton =3D buttonCancel;=0A=
=0A=
            if (form.ShowDialog() =3D=3D DialogResult.Cancel)=0A=
            {=0A=
                textBox.Text =3D "";=0A=
            }=0A=
            return textBox.Text;=0A=
        }=0A=
    }=0A=
}=0A=
</PRE></BODY></HTML>
