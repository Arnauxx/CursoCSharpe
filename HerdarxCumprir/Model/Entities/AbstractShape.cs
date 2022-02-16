using HerdarxCumprir.Model.Enums;

namespace HerdarxCumprir.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color{ get; set; }

        public abstract double Area();
    }
}
