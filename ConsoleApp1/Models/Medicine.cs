using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Medicine
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
        public void Sell(int count)
        {
            count--;
            Count = count;
        }
        public Medicine(string name, int count, bool isdeleted)
        {
            _id++;
            Id = _id;
            Name = name;
            Count = count;
            IsDeleted = isdeleted;
        }
        public void ShowInfo()
        {

        }
    }
}
