using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace tamrin_seri_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operations with Vector class \n");
            Vector<double> v1 = new Vector<double>(4) { 10.5, 8.56, 92.23,45 };
            Vector<int> v2 = new Vector<int>(5) { 5, 10, 15, 20, 25 };
            Vector<int> v3 = new Vector<int>(5) { 5, 10, 15, 20, 25 };
            Console.WriteLine(v1.ToString());
            Console.WriteLine((v2 + v3).ToString());
            Console.WriteLine(v1.Equals(v3));
            Console.WriteLine("Operations with Matris class \n");
            Matrix<double> m1 = new Matrix<double>(3, 4)
            {
                new Vector<double>(3){1.1,2.2,3.4,7.1 },
                new Vector<double>(3){4.1,5.2,3.4,5.4 }
            };
            Matrix<int> m2 = new Matrix<int>(2, 3)
            {
                new Vector<int>(3){1,2,3 },
                new Vector<int>(3){4,5,3 }
            };
            Matrix<int> m3 = new Matrix<int>(2, 3)
            {
                new Vector<int>(3){1,2,3 },
                new Vector<int>(3){4,5,3 }
            };
            Console.WriteLine(m1.ToString());
            Console.WriteLine((m3 + m2).ToString());
            Console.WriteLine(m2 == m3);
            Console.ReadKey();
        }
    }

    class Vector<T> : IEnumerable<T>, IEquatable<Vector<T>> where T : IComparable<T>
    {
        public List<T> mainlist;
        public Vector(int number) { mainlist = new List<T>(number); }

        public void AddItem(T obj) { mainlist.Add(obj); }         
        public void Add(T obj) { mainlist.Add(obj); }
        public override string ToString()
        {
            string result = null;
            result += "[";
            foreach(var i in mainlist)
            {
                if (mainlist.IndexOf(i) != mainlist.Count - 1) { result  = result + i; }
                else { result = result + i; }
            }
            result += "]";
            return result;
        }
        public static bool operator ==(Vector<T> v1, Vector<T> v2)
        {
            bool valid=true;
            try
            {
                if (v1.mainlist.Count != v2.mainlist.Count)
                    return false;
                else
                {
                    for (int i = 0; i < v1.mainlist.Count; i++)
                    {
                        if (v1.mainlist[i].CompareTo(v2.mainlist[i]) != 0)
                        {
                            valid = false;
                        }
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sth is mistake,check it again");
                Console.ResetColor();
            }
            return valid;
        }
        public static bool operator !=(Vector<T> v1, Vector<T> v2)
        {
            bool valid = false;
            try
            {
                if (v1.mainlist.Count != v2.mainlist.Count)
                    return true;
                else
                {
                    for (int i = 0; i < v1.mainlist.Count; i++)
                    {
                        if (v1.mainlist[i].CompareTo(v2.mainlist[i]) != 0)
                                valid = true;
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sth is mistake,check it again");
                Console.ResetColor();
            }
            return valid;
        }
        public static Vector<T> operator +(Vector<T> v1, Vector<T> v2)
        {
            Vector<T> FinalVector = new Vector<T>(0);
            int? num = null;
            try
            {
                if (v1.mainlist.Count > v2.mainlist.Count)
                    num = v1.mainlist.Count;
                else
                    num = v2.mainlist.Count;

                for (int i = 0; i < num; i++)
                {
                    if (i < v1.mainlist.Count && i < v2.mainlist.Count)
                    {
                        dynamic v1prime = v1.mainlist[i];
                        dynamic v2prime = v2.mainlist[i];
                        FinalVector.AddItem(v1prime + v2prime);
                    }
                    else if (i >= v1.mainlist.Count && i < v2.mainlist.Count)
                    {
                        FinalVector.AddItem(v2.mainlist[i]);
                    }
                    else if (i < v1.mainlist.Count && i >= v2.mainlist.Count)
                    {
                        FinalVector.AddItem(v1.mainlist[i]);
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sth is mistake,check it again");
                Console.ResetColor();
            }
            return FinalVector;
        }

        public static Vector<T> operator *(Vector<T> v1, Vector<T> v2)
        {
            Vector<T> FinalVector = new Vector<T>(0);
            int num = 0;
            try
            {
                if (v1.mainlist.Count > v2.mainlist.Count)
                    num = v2.mainlist.Count;
                else
                    num = v1.mainlist.Count;

                for (int i = 0; i < num; i++)
                {
                    if (i < v1.mainlist.Count && i < v2.mainlist.Count)
                    {
                        dynamic v1i = v1.mainlist[i];
                        dynamic v2i = v2.mainlist[i];
                        FinalVector.AddItem(v1i * v2i);
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sth is mistake,check it again");
                Console.ResetColor();
            }
            return FinalVector;
        }

        public bool Equals(Vector<T> other)
        {
            if (other == this)
                return true;
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var x in mainlist) { yield return x; }
        }

        IEnumerator IEnumerable.GetEnumerator() { throw new NotImplementedException(); }

    }

    class Matrix<T> : IEnumerable<Vector<T>>, IEnumerable, IEquatable<Matrix<T>> where T : IComparable<T>
    {
        public List<Vector<T>> VectorList;
        public int number;
        public Matrix(int n, int m)
        {
            number = m;
            VectorList = new List<Vector<T>>(n);
        }
        public void Add(Vector<T> item)
        {
            VectorList.Add(item);
        }
        public override string ToString()
        {
            string result = null;
            result += "[\n";
            foreach (var vector in VectorList)
            {
                foreach (var i in vector)
                {
                    if( vector.mainlist.IndexOf(i) == 0) { result  = result + i; }
                    else
                    {
                        if (vector.mainlist.IndexOf(i) != vector.mainlist.Count - 1) { result  = result + i; }
                        else { result  = result + i; }
                    }
                }
                if(VectorList.IndexOf(vector) !=VectorList.Count-1)
                    result += "],\n";
                else
                    result += "]\n";
            }
            result += "]\n";
            return result;
        }
        public static bool operator ==(Matrix<T> m1, Matrix<T> m2)
        {
            bool valid = true;
            try
            {
                if (m2.VectorList.Count != m2.VectorList.Count)
                    valid = false;
                else
                {
                    for (int i = 0; i < m1.VectorList.Count; i++)
                    {
                        if (m1.VectorList[i] != (m2.VectorList[i]))
                        {
                            valid = false;
                        }
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sth is mistake,check it again");
                Console.ResetColor();
            }
            return valid;
        }
        public static bool operator !=(Matrix<T> m1, Matrix<T> m2)
        {
            bool valid = false;
            try
            {
                if (m2.VectorList.Count != m2.VectorList.Count)
                    valid = true;
                else
                {
                    for (int i = 0; i < m1.VectorList.Count; i++)
                    {
                        if (m1.VectorList[i] != (m2.VectorList[i]))
                        {
                            valid = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return valid;
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> FinalMatrix = new Matrix<T>(0, 0);
            if (m1.number > m2.number)
                FinalMatrix = new Matrix<T>(0, m1.number);
            else
                FinalMatrix = new Matrix<T>(0, m2.number);
            int? num = null;
            try
            {
                if (m1.VectorList.Count > m2.VectorList.Count)
                    num = m1.VectorList.Count;
                else
                    num = m2.VectorList.Count;

                for (int i = 0; i < num; i++)
                {
                    if (i < m1.VectorList.Count && i < m2.VectorList.Count)
                    {
                        dynamic m1prime = m1.VectorList[i];
                        dynamic m2prime = m2.VectorList[i];
                        FinalMatrix.Add(m1.VectorList[i] + m2.VectorList[i]);
                    }
                    else if (i >= m1.VectorList.Count && i < m2.VectorList.Count)
                    {
                        FinalMatrix.Add(m2.VectorList[i]);
                    }
                    else if (i < m1.VectorList.Count && i >= m2.VectorList.Count)
                    {
                        FinalMatrix.Add(m1.VectorList[i]);
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sth is mistake,check it again");
                Console.ResetColor();
            }
            return FinalMatrix;
        }
        public bool Equals(Matrix<T> other)
        {
            if (other == this)
                return true;
            else
                return false;
        }
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            foreach (var x in VectorList)
            {
                yield return x;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
