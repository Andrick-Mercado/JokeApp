using System.Diagnostics;

namespace NotieTaker.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public string NoteFront { get; set; }
        public string NoteBack { get; set; }

        public Notes()
        {
            
        }
    }
}