using System;
using System.Text;
namespace DataType
{
    public class _INT
    {
        private int data;
         
        public _INT()
        {
            data = 0;
        }
        public _INT(int data)
        {
            this.data = data;
        }
        public void setData(int data)
        {
            this.data = data;
        }
        public float ToFloat()
        {
            return (float)(this.data);
        }
        public String _ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.data);
            return str.ToString();
        }

        public int addition(_INT a, _INT b)
        {
            return (a.data + b.data);
        }

        public int substraction(_INT a, _INT b)
        {
            return (a.data - b.data);
        }

        public void display()
        {
            Console.WriteLine(data);
        }
    }

    public class _FLOAT
    {
        private float data;
        public _FLOAT()
        {
            data = 0;
        }
        public _FLOAT(int data)
        {
            this.data = data;
        }
        public void setData(int data)
        {
            this.data = data;
        }

        public float ToInt()
        {
            return (float)this.data;
        }
        public String _ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.data);
            return str.ToString();
        }

        public float addition(_FLOAT a, _FLOAT b)
        {
            return (a.data + b.data);
        }
        public float substraction(_FLOAT a, _FLOAT b)
        {
            return (a.data - b.data);
        }
        public void display()
        {
            Console.WriteLine(data);
        }
    }
}