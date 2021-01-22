using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing is available in the pro version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Old format save, new format save is available in the pro version");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Old format save, new format save is available in the Expert version");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in the new format");
        }
    }
}
