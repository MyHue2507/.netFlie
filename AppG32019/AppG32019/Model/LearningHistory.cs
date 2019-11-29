using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG32019.Model
{
    public class LearningHistory
    {
        public string Id { get; set; }
        public int YearFrom { get; set; }
        public int YearEnd { get; set; }
        public string Address { get; set; }
        public string IdStudent { get; set; }
        public Student Student { get; set; }
    }
}
