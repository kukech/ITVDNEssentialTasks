using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    abstract class AbstractHandler
    {
        protected string filename;
        public AbstractHandler(string filename)
        {
            this.filename = filename;
        }
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string filename)
            :base(filename)
        {

        }
        public override void Open()
        {
            Console.WriteLine("open XML");
        }
        public override void Create()
        {
            Console.WriteLine("create XML");
        }
        public override void Change()
        {
            Console.WriteLine("change XML");
        }
        public override void Save()
        {
            Console.WriteLine("save XML");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string filename)
            : base(filename)
        {

        }
        public override void Open()
        {
            Console.WriteLine("open TXT");
        }
        public override void Create()
        {
            Console.WriteLine("create TXT");
        }
        public override void Change()
        {
            Console.WriteLine("change TXT");
        }
        public override void Save()
        {
            Console.WriteLine("save TXT");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string filename)
            : base(filename)
        {

        }
        public override void Open()
        {
            Console.WriteLine("open DOC");
        }
        public override void Create()
        {
            Console.WriteLine("create DOC");
        }
        public override void Change()
        {
            Console.WriteLine("change DOC");
        }
        public override void Save()
        {
            Console.WriteLine("save DOC");
        }
    }
    class Editor
    {
        AbstractHandler secondDoc;
        public Editor(string filename)
        {
            //бла бла бла лень писать
        }
    }
}
