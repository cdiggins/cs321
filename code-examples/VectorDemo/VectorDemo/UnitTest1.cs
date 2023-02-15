using System.Security.Cryptography.X509Certificates;

namespace VectorDemo
{
    /// <summary>
    /// A class that represent 2D coordinate or vectors. 
    /// </summary>
    public class Vector2 : System.Object
    {
        // The X Component field
        private double _x;

        // The Y Component field
        private double _y;

        /// <summary>
        /// A constructor that accepts two values 
        /// </summary>
        public Vector2(double x, double y)
        {
            _x = x; 
            _y = y;
        }

        /// <summary>
        /// An overloaded constructor that accepts an array 
        /// </summary>
        public Vector2(double[] values)
        {
            _x = values[0];
            _y = values[1];
        }

        /// <summary>
        /// The X property, in short-hand form 
        /// </summary>
        public double X => _x;

        /// <summary>
        /// THe Y property, in short-hand formt
        /// </summary>
        public double Y => _y;

        /// <summary>
        /// The number of components 
        /// </summary>
        public int Count => 2;

        /// <summary>
        /// Indexing operator, allows the class to be treated like an array 
        /// </summary>
        public double this[int n]
        {
            get
            {
                if (n == 0) return X;
                if (n == 1) return Y;
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Returns the s malles value of the components 
        /// </summary>
        public double GetMinComponent()
        {
            return X <= Y ? X : Y;
        }

        /// <summary>
        /// Returns the largest value of the components 
        /// </summary>
        public double GetMaxComponent()
        {
            return this.X >= this.Y ? this.X : this.Y;
        }

        /// <summary>
        /// This is an example of a computed property 
        /// </summary>
        public double Length
        {
            get 
            { 
                return Math.Sqrt(this.X * this.X + this.Y * this.Y); 
            }
        }

        /// <summary>
        /// Overload of the addition operator
        /// </summary>
        public static Vector2 operator+(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }

        /// <summary>
        /// Override the "Object.ToString()" method.
        /// Because ToString() is virtual 
        /// if we cast the vector to an object, and call "ToString()"
        /// on that object, this implementation gets called.
        /// </summary>
        public override string ToString()
        {
            return $"X = {this.X}, Y = {this.Y}";
        }

        /// <summary>
        /// Override the "Object.Equals(object)" method.
        /// Because Equals() is virtual 
        /// if we cast the vector to an object, and call "Equals()"
        /// on that object, this implementation gets called.
        /// </summary>
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Vector2 v))
                return false;
            return v.X == X && v.Y == Y;
        }

        /// <summary>
        /// This is an iterator method that returns values one by one. 
        /// </summary>
        public IEnumerable<double> GetValues()
        {
            for (var i=0; i < Count;i++)
            {
                yield return this[i];
            }
        }

        /// <summary>
        /// Performs an implicit cast from a double to a vector2 
        /// </summary>
        public static implicit operator Vector2(double d)
        {
            return new Vector2(d, d);
        }
    }

    public class Tests
    {
        [Test]
        public void Test1()
        {
            var v1 = new Vector2(3, 4);
            var v2 = new Vector2(5, 4);

            Assert.AreEqual(v1.Y, v2.Y);
            
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.ToString());

            var v3 = v1 + v2;

            Console.WriteLine(v3);
        }

        [Test]
        public void TestIndexer()
        {
            var v = new Vector2(1, 2);
            Assert.AreEqual(2, v[1]);
        }

        [Test]
        public void TestMinComponent() 
        {
            var v = new Vector2(99, 2);
            Assert.AreEqual(2, v.GetMinComponent());
        }

        [Test]
        public void TestIteratorMethod()
        {
            var v = new Vector2(3, 4);
            foreach (var d in v.GetValues())
            {
                Console.WriteLine(d.ToString());
            }
        }

        [Test]
        public void TestImplicitCast()
        {
            double d = 3.14;
            Vector2 v = d; 
            Assert.AreEqual(d, v.X, 0.0001);
            Assert.AreEqual(d, v.Y, 0.0001);
        }
    }
}