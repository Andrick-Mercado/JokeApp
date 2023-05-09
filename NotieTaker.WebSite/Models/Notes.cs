using System.ComponentModel;
using System.Diagnostics;

namespace NotieTaker.Models
{
    public class Notes
    {
        public int Id { get; set; }
        [DisplayName("Front of Note")]
        public string NoteFront { get; set; }
        [DisplayName("Back of Note")]
        public string NoteBack { get; set; }

        public Notes()
        {
            
        }
    }
}