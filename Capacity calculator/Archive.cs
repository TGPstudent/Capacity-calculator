using System;
using System.Drawing;

namespace Capacity_calculator
{
    public class Archive
    {
            public Image eskiz;
            public string date;
            public string inbox;
            public string outbox;
            public Boolean chek;
            //конструктор без параметрів
            public Archive()
            {

            }
            //конструктор з параметрами
            public Archive(Image Im, string In, string Out)
            {
                Eskiz = Im;
                Date = (DateTime.Now).ToString(new System.Globalization.CultureInfo("uk-UA"));
                Inbox = In;
                Outbox = Out;
                Chek = false;
            }
            //Властивості
            public Image Eskiz
            {
                get { return eskiz; }
                set { eskiz = value; }
            }

            public string Inbox
            {
                get { return inbox; }
                set { inbox = value; }
            }
            public string Outbox
            {
                get { return outbox; }
                set { outbox = value; }
            }
            public string Date
            {
                get { return date; }
                set { date = value; }
            }
            public Boolean Chek
            {
                get { return chek; }
                set { chek = value; }
            }
    }
}
