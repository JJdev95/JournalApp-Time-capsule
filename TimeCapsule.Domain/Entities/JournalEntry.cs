namespace TimeCapsule.Domain.Entities
{
    public class JournalEntry : BaseEntity
    {
        public string Title { get; set; }
        public DateTime EntryDate { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public int JournalTypeId { get; set; }
       
        public JournalEntry(string title, DateTime entryDate, string text, int userId, int journalTypeId)
        {
            Title = title;
            EntryDate = entryDate;
            Text = text;
            UserId = userId;
            JournalTypeId = journalTypeId;
        }
    }
    
}