using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Hunter_Rise___PR_Tracker
{
    class RunRecord
    {
        string m_QuestName;
        Weapon m_Weapon;
        RunStyle m_Rules;
        int m_Minutes;
        int m_Seconds;
        int m_Milliseconds;

        public string QuestName { get { return m_QuestName; } }
        public Weapon weapon { get { return m_Weapon; } }
        public RunStyle Rule { get { return m_Rules; } }
        public int Minutes { get { return m_Minutes; } }
        public int Seconds { get { return m_Seconds; } }
        public int Milliseconds { get { return m_Milliseconds; } }
        public string Time { get { return m_Minutes + "\'" + (m_Seconds <= 9 ? "0" : string.Empty) + m_Seconds.ToString() + "\"" + (m_Milliseconds <= 9 ? "0" : string.Empty) + m_Milliseconds.ToString(); } }

        public RunRecord(string aQuestName, Weapon aWeapon, RunStyle aRuleset, int aMinute, int aSecond, int aMillisecond)
        {
            m_QuestName = aQuestName;
            m_Weapon = aWeapon;
            m_Rules = aRuleset;
            m_Minutes = aMinute;
            m_Seconds = aSecond;
            m_Milliseconds = aMillisecond;
        }

        public RunRecord(string aRecord)
        {
            string[] info = aRecord.Split(",");

            if (info.Length == 6)
            {
                try
                {
                    m_QuestName = info[0];
                    m_Weapon = (Weapon)Enum.Parse(typeof(Weapon), info[1]);
                    m_Rules = (RunStyle)Enum.Parse(typeof(RunStyle), info[2]);
                    m_Minutes = int.Parse(info[3]);
                    m_Seconds = int.Parse(info[4]);
                    m_Milliseconds = int.Parse(info[5]);
                }
                catch { }
            }
        }

        public int CompareTime
        {
            get
            {
                string minutes = m_Minutes.ToString();
                string seconds = (m_Seconds <= 9 ? "0" : string.Empty) + m_Seconds.ToString();
                string milli = (m_Milliseconds <= 9 ? "0" : string.Empty) + m_Milliseconds.ToString();

                return int.Parse(minutes + seconds + milli);
            }
        }
    }
}
