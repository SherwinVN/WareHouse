using System;
using System.ComponentModel;
using System.Drawing;

namespace Develover.Utilities
{
    public class Record
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool State { get; set; }
        public Image Image { get; set; }
    }
    public class DataHelper
    {
        public static BindingList<Record> GetData(int count)
        {
            BindingList<Record> records = new BindingList<Record>();
            for (int i = 0; i < count; i++)
                records.Add(new Record()
                {
                    Id = i,
                    Text = string.Format("Text {0}", i),
                    Date = DateTime.Now.AddDays(i),
                    State = i % 2 == 0,
                    Image = i % 2 == 0 ? SystemIcons.Information.ToBitmap() : SystemIcons.Question.ToBitmap(),
                });
            return records;
        }
    }
}
