using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            B b = new B();
            b.x = 4;

            C c = new C(3);

            D d = new D(4);

            Console.WriteLine(d.GetX());
            d.SetX(7);
            Console.WriteLine(d.GetX());
            Console.ReadKey();

            Real r = new Real(43);

            r = r.sumReal(new Real(3));

            Console.WriteLine(r.GetReal());
        }
    }

    class A { }

    class B
    {
        public int x = 3;
    }

    class C
    {
        private int x;

        public C(int x)
        {
            this.x = x;
        }
    }


    class D
    {
        private int x;
        public D(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return x;
        }

        int qualquerCoisa()
        {
            return 3;
        }

        public void SetX(int x)
        {
            this.x = x;
        }
    }

    class Real
    {
        private double real;
        public Real(double real)
        {
            this.real = real;
        }

        public double GetReal()
        {
            return real;
        }

        public void SetReal(double real)
        {
            this.real = real;
        }

        public void printReal()
        {
            Console.WriteLine(real);
        }

        public Real sumReal(Real r) {
            return new Real(this.real + r.real);
        }
    }
}
