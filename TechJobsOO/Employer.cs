using System;
namespace TechJobsOO
{
    public class Employer: JobField
    {
        

        public Employer () : base()
        {
        }

        public Employer(string value) : base(value)
        {
        }




        public override string ToString()
        {
            return Value;
        }
    }
}

