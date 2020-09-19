namespace Piranha.Extend.Fields
{
    [FieldType(Name = "Color", Shorthand = "Color", Component = "color-field")]
    public class ColorField: SimpleField<string>
    {
        public static implicit operator ColorField(string date)
        {
            return new ColorField { Value = date };
        }
    }
}