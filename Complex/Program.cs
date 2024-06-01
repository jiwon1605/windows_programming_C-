namespace Complex
{
    class Complex
    {
        private double realPart;
        private double imagePart;

        public static Complex operator +(Complex left, Complex right)
        {
            Complex result = new Complex();
            result.realPart = left.realPart + right.realPart;
            result.imagePart = left.imagePart + right.imagePart;
            return result;
        }

        public static Complex operator -(Complex left, Complex right)
        {
            Complex result = new Complex();
            result.realPart = left.realPart - right.realPart;
            result.imagePart = left.imagePart - right.imagePart;
            return result;
        }

        public static Complex operator *(Complex left, Complex right)
        {
            Complex result = new Complex();
            result.realPart = (left.realPart * right.realPart)
                - (left.imagePart * right.imagePart);
            result.imagePart = (left.realPart * right.imagePart)
                + (left.imagePart * right.realPart);
            return result;
        }

        public static Complex operator /(Complex left, Complex right)
        {
            Complex result = new Complex();
            result.realPart = ((left.realPart * right.realPart) + (left.imagePart * right.imagePart))
                / ((Math.Pow(right.realPart, 2) + (Math.Pow(right.imagePart, 2))));

            result.imagePart = ((left.imagePart * right.realPart) - (left.realPart * right.imagePart))
                / ((Math.Pow(right.realPart, 2) + (Math.Pow(right.imagePart, 2))));
            return result;
        }

        public double RealPart //프로퍼티 작성
        {
            get { return realPart; }
            set { realPart = value; }
        }

        public double ImagePart
        {
            get { return imagePart; }
            set { imagePart = value; }
        }

        public override string ToString()
        {
            if (imagePart < 0)
                return ("(" + realPart + imagePart + "i" + ")");
            return ("(" + realPart + "+" + imagePart + "i" + ")");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex l = new Complex();
            l.RealPart = 2;
            l.ImagePart = 3;

            Complex r = new Complex();
            r.RealPart = 1;
            r.ImagePart = 2;

            Console.WriteLine(l + " + " + r + " = " + (l + r).ToString());
            Console.WriteLine(l + " - " + r + " = " + (l - r).ToString());
            Console.WriteLine(l + " * " + r + " = " + (l * r).ToString());
            Console.WriteLine(l + " / " + r + " = " + (l / r).ToString());
        }
    }
}