using System;
using System.Collections.Generic;
using Wildlife.Model;

namespace Wildlife
{
    class Program
    {
        public static void Main()
        {
           Animal zebra = new Animal("Tony", "Zebra", "1/12/20", true, false, "Male");
           Animal giraffe = new Animal("Geraldine", "Giraffe", "6/4/20", false, true, "Female");
           Animal penguin = new Animal("Pauly", "Penguin", "2/2/20", true, true, "Male");
           Animal shark = new Animal("Shirley", "Shark", "2/9/19", true, true, "Female");

        List<Animal> Animals = new List<Animal>() {zebra, giraffe, penguin, shark};

           

        }
    }
}
