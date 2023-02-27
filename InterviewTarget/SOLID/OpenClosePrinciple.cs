using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTarget.SOLID
{
    public enum Color
    {
        Red,Green,Blue
    }

    public enum Size
    {
        Small, Medium, Large, Hue
    }

    public class Product
    {
        public string Name;
        public Color Color; 
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products,
            Size size)
        {
            foreach (var p in products)            
               if (p.Size == size)
                  yield return p;            
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products,
            Color color)
        {
            foreach (var p in products)            
                if (p.Color == color)
                    yield return p;            
        }

        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, 
            Size size, Color color)
        {
            foreach (var p in products)            
               if (p.Color == color && p.Size == size)
                   yield return p;            
        }

    }

    //  Applying Open Close Principle
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;
        public ColorSpecification(Color color)
        {
            this._color= color;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Color == _color;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size _size;
        public SizeSpecification(Size size)
        {
            this._size= size;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Size == _size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }
        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
        {
            foreach (var p in products)
               if (spec.IsSatisfied(p))
                   yield return p;            
        }
    }
}
