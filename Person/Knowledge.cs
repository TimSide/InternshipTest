namespace internshiptest.Person
{
    public abstract class Knowledge
    {
        
        private int _knowledge;
        
        // Constructor
        protected Knowledge(int level)
        {
            _knowledge = level;
        }

        // Setters

        public void SetKnowledge(int level)
        {
            _knowledge = level;
        }
        
        // Getters

        public int GetKnowledge()
        {
            return _knowledge;
        }
    }
}
