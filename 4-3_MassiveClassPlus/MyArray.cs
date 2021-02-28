using System;
using System.IO;
using System.Threading;

    class MyArray
    {
        int[] a;

        public MyArray(int n)
        {
            a = new int[n];
        }       

        public int Get(int i)
        {
        	return a[i];
        }

        public void Set(int i, int value)
        {
        	a[i] = value;
        }

        public int this[int i]
        {
        	get { return a[i]; }
        	set { a[i] = value; }
        }

        public int Sum(int n)
        {
       		int Sum = 0;

            for(int i=0;i<n;i++)
            {
                Sum = Sum + a[i];
            }

            return Sum;
        }

        public int Length()
        {
      		int Ln = a.Length;
      		return Ln;
        }

        public int MaxCount()
        {
        	int MaxCount = a.Length;
        	int max = a[0];
        	for(int i=0;i<a.Length;i++)
        	{
        		if(max < a[i])
        		{
        			max = a[i]; MaxCount--;
        		}
        	}
        	return MaxCount;
        }

        public MyArray Reverse(MyArray array)
        {
        	int n = array.Length();
         	MyArray array2 = new MyArray(n);

         	for(int i=0;i<n;i++)
            {
            	array2.Set(i,-array.Get(i));
            }

            return array2;
        }

        public MyArray Multi(MyArray array, int x)
        {
            int n = array.Length();
            for(int i=0;i<n;i++)
            {
            	array[i] = array[i]*x;
            }
            return array;
        }

    }