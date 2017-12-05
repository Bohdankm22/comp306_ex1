using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleCloudSamples
{
    public class Pics
    {
        public string imagePizza { get; set; }
        public string cola { get; set; }
        public string beer { get; set; }
        public string pasta { get; set; }
        public string ravioli { get; set; }
        public string salad { get; set; }

        private Pics() {
            imagePizza = "https://storage.googleapis.com/comp-agnm-restaurant/pizza.jpg";
            cola = "https://storage.googleapis.com/comp-agnm-restaurant/cola.jpg";
            beer = "https://storage.googleapis.com/comp-agnm-restaurant/beer.jpg";
            pasta = "https://storage.googleapis.com/comp-agnm-restaurant/pasta.png";
            ravioli = "https://storage.googleapis.com/comp-agnm-restaurant/ravioli.jpg";
            salad = "https://storage.googleapis.com/comp-agnm-restaurant/salad.jpg";
        }

        public static Pics getInstance()
        {
            return new Pics();
        }
    }
}