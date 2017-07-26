using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Calc
    {
        protected double A;
        protected double B;
        protected string Operation;

      

        public void setExpr(double a, double b, string oper)
        {
            A = a;
            B = b;
            Operation = oper;

            
            
        }
            

        private double Sum()
        {
            return A + B;
        }

        private double Sub()
        {
            return A - B;
        }

        protected double Result;

        public double GetResult()
        {
            return Result;
        }
             
        protected virtual bool Validate()
        {
           
            
            if(Operation != "-" && Operation != "+")
            {
                
                return false;
            }
            
            return true;
            
            
        }
        
        public virtual void Calculate()
        {
            if (Validate())
            {
                if (Operation == "+")
                {
                    Result = Sum();
                    
                }
                else if(Operation == "-")
                {
                    Result = Sub();
                    
                }
            }




        }

        public Calc()
        {
            
        } 
    }

    class ExtendedCalc : Calc
    {
        private double Mult()
        {
            return A * B;
        }


        protected override bool Validate()
        {
            if (!base.Validate())
            {
                if (Operation == "*") return true;
                else return false;
            }
            else
            {
                return base.Validate();
            }
        }

        public override void Calculate()
        {
            if (Operation != "*")
            {
                base.Calculate();
            }
            else
            {
                Result = Mult();
            }

        }
        public ExtendedCalc()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc calc1 = new Calc();
            calc1.setExpr(3, 5, "+");
           
           
            calc1.Calculate();
            Console.WriteLine(calc1.GetResult());
            
        }
    }
}
