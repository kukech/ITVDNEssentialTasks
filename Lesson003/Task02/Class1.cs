using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class ClassRoom
    {
        Pupil[] pupil = new Pupil[4];
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length <= this.pupil.Length)
                for (int i = 0; i < pupil.Length; i++)
                    if (i < pupils.Length) this.pupil[i] = pupils[i];
                    else this.pupil[i] = new Pupil();
            else
                for (int i = 0; i < this.pupil.Length; i++)
                    this.pupil[i] = new Pupil();
        }
        public void ShowAll()
        {
            foreach (Pupil p in pupil)
                p.Study();
            foreach (Pupil p in pupil)
                p.Read();
            foreach (Pupil p in pupil)
                p.Write();
            foreach (Pupil p in pupil)
                p.Relax();        }
    }
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Not have a rating");
        }
        public virtual void Read()
        {
            Console.WriteLine("Not have a rating");
        }
        public virtual void Write()
        {
            Console.WriteLine("Not have a rating");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Not have a rating");
        }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good");
        }
        public override void Read()
        {
            Console.WriteLine("Good");
        }
        public override void Write()
        {
            Console.WriteLine("Good");
        }
        public override void Relax()
        {
            Console.WriteLine("Good");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad");
        }
        public override void Read()
        {
            Console.WriteLine("Bad");
        }
        public override void Write()
        {
            Console.WriteLine("Bad");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad");
        }
    }
}
