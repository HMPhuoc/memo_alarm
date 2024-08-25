using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memo.Class
{
    
    class MemoW
    {
        public string memoName { get; set; }
        public DateTime memoTime { get; set; }

        public MemoW() { }
        public MemoW(string name, DateTime time)
        {
            memoName = name;
            memoTime = time;
        }

        public List<MemoW> memos()
        {
            List<MemoW> list = new List<MemoW>();
            list.Add(new MemoW("wake", DateTime.Now.AddSeconds(30)));
            list.Add(new MemoW("Brush", DateTime.Now.AddMinutes(1)));

            return list;
        }

        public void RunAtTime(string work, DateTime alertTime)
        {
            MessageBox.Show(alertTime.ToString());
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = alertTime - now;
            //MessageBox.Show(timeSpan.ToString());
            if (timeSpan < TimeSpan.Zero)
            {
                MessageBox.Show("Time Passed");
            }
            else
            {
                System.Threading.Timer timer = new System.Threading.Timer((x) => { MessageBox.Show("OK " + work + " at " + timeSpan.ToString()); }, null, timeSpan, Timeout.InfiniteTimeSpan);
            }
        }
    }
}
