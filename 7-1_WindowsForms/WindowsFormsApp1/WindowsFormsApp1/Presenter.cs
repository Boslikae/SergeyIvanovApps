using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Presenter
    {
        Model model;
        IView view;
        public int m = 2; // множитель числа
        public int b = 1; // слагаемое числа
        public int s = 1; // стартовое число
        public Stack<int> numbers = new Stack<int>();

        public Presenter(IView view)
        {
            this.view = view;
            model = new Model();
            numbers.Push(s);
        }

        public void WriteHistory(int x)
        {
            numbers.Push(x);
           // Victory();
        }

        public int ReWriteHistory()
        {
            numbers.Pop();
            return ReadHistory();
        }

        public int ReadHistory()
        {
            return numbers.Peek();
        }

        protected bool CheckHistory()
        {
            if (numbers.Count == 1)
            { return false; }
            else { return true;  } 
        }

        public void Sum()
        {
            model.S = view.Numb;
            int x = model.Sum(b);
            view.Result = $"{x}";
            WriteHistory(x);
        }
        
        public void Reset()
        {
            view.Result = $"{model.Reset(s)}";
            numbers.Clear();
        }

        public void Mult()
        {
            model.S = view.Numb;
            int x = model.Mult(m);
            view.Result = $"{x}";
            WriteHistory(x);
        }

        public void Counter()
        {
            model.C = view.Counter;
            view.Counter = $"{model.Counter()}";
        }

        public void ResetCounter()
        {
            view.Counter = $"{model.ResetCounter()}";
        }

        public void CancelTurn()
        {
            bool check = CheckHistory();
            if (check == true)
            {
                
                model.S = view.Numb;
                model.C = view.Counter;

                int h = ReWriteHistory();
                int x = model.Cancel(h);

                view.Result = $"{x}";
                view.Counter = $"{model.CounterDown()}";

            }
        }

        public void Victory()
        {
           // int x = ReadHistory();
           // int X = int.Parse(view.Task);
           // if (x == X) { view.Victory = true; }

        }
    }

}
