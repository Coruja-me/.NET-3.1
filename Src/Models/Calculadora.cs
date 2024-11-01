using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Models
{
    public class Calculadora
    {
        private readonly List<string> _history;

        public Calculadora()
        {
            _history = new List<string>();
        }

        public int Sum(int x, int y){
            int result = x + y;
            _history.Insert(0, "Result: "+ result);
            
            return result;
        }
        public int Sub(int x, int y){
            int result = x - y;
            _history.Insert(0, "Result: "+ result);
            return result;
        }
        public int Mult(int x, int y){
            int result = x * y;
            _history.Insert(0, "Result: "+ result);
            return result;
        }
        public int Div(int x, int y){
            int result = x / y;
            _history.Insert(0, "Result: "+ result);
            return result;
        }
        public List<string> Hist(){
            _history.RemoveRange(3, _history.Count - 3);
            return _history;
        }
    }
}