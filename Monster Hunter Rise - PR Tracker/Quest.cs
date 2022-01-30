namespace Monster_Hunter_Rise___PR_Tracker
{
    class Quest
    {
        string          m_QuestName;
        LargeMonster[]  m_Monster;
        QuestType       m_Type;
        byte            m_Level;

        public string QuestName         { get { return m_QuestName; } }
        public LargeMonster[] Monster   { get { return m_Monster;   } }
        public QuestType Type           { get { return m_Type;      } }
        public byte Level               { get { return m_Level;     } }

        public Quest(string aQuestName, LargeMonster[] aMonster, QuestType aType, byte aLevel)
        {
            m_QuestName     = aQuestName;
            m_Monster       = aMonster;
            m_Type          = aType;
            m_Level         = aLevel;
        }
    }
}
