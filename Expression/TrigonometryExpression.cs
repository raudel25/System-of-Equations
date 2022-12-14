namespace Expression;

public class Sin : UnaryExpression
{
    public Sin(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value) => new Cos(value);

    protected override double Evaluate(double value) => Math.Sin(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Sin(value);

    public override string ToString() => $"sin({this.Value})";

    public override bool Equals(object? obj)
    {
        Sin? unary = obj as Sin;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => this.Value.GetHashCode();
}

public class Cos : UnaryExpression
{
    public Cos(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value) =>
        new NumberExpression(-1) * new Sin(value);

    protected override double Evaluate(double value) => Math.Cos(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Cos(value);

    public override string ToString() => $"cos({this.Value})";

    public override bool Equals(object? obj)
    {
        Cos? unary = obj as Cos;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 2 * this.Value.GetHashCode();
}

public class Tan : UnaryExpression
{
    public Tan(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value) =>
        Pow.DeterminatePow(new Sec(value), new NumberExpression(2));

    protected override double Evaluate(double value) => Math.Sin(value) / Math.Cos(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Tan(value);

    public override string ToString() => $"tan({this.Value})";

    public override bool Equals(object? obj)
    {
        Tan? unary = obj as Tan;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 3 * this.Value.GetHashCode();
}

public class Cot : UnaryExpression
{
    public Cot(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value) =>
        Pow.DeterminatePow(new Csc(value), new NumberExpression(2));

    protected override double Evaluate(double value) => Math.Cos(value) / Math.Sin(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Cot(value);

    public override string ToString() => $"cot({this.Value})";

    public override bool Equals(object? obj)
    {
        Cot? unary = obj as Cot;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 4 * this.Value.GetHashCode();
}

public class Sec : UnaryExpression
{
    public Sec(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value) => new Sec(value) * new Tan(value);

    protected override double Evaluate(double value) => 1 / Math.Cos(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Sec(value);

    public override string ToString() => $"sec({this.Value})";

    public override bool Equals(object? obj)
    {
        Sec? unary = obj as Sec;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 5 * this.Value.GetHashCode();
}

public class Csc : UnaryExpression
{
    public Csc(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value) => -new Csc(value) * new Cot(value);

    protected override double Evaluate(double value) => 1 / Math.Sin(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Csc(value);

    public override string ToString() => $"csc({this.Value})";

    public override bool Equals(object? obj)
    {
        Csc? unary = obj as Csc;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 6 * this.Value.GetHashCode();
}

public class Asin : UnaryExpression
{
    public Asin(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value)
        => new NumberExpression(1) /
           Pow.DeterminatePow(
               new NumberExpression(1) -
               Pow.DeterminatePow(value, new NumberExpression(2)),
               new NumberExpression(0.5));

    protected override double Evaluate(double value) => Math.Asin(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Asin(value);

    public override string ToString() => $"arcsin({this.Value})";

    public override bool Equals(object? obj)
    {
        Asin? unary = obj as Asin;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 7 * this.Value.GetHashCode();
}

public class Acos : UnaryExpression
{
    public Acos(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value)
        => -new NumberExpression(1) /
           Pow.DeterminatePow(
               new NumberExpression(1) -
               Pow.DeterminatePow(value, new NumberExpression(2)),
               new NumberExpression(0.5));

    protected override double Evaluate(double value) => Math.Acos(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Acos(value);

    public override string ToString() => $"arccos({this.Value})";

    public override bool Equals(object? obj)
    {
        Acos? unary = obj as Acos;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 8 * this.Value.GetHashCode();
}

public class Atan : UnaryExpression
{
    public Atan(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value)
        => new NumberExpression(1) /
           (new NumberExpression(1) + Pow.DeterminatePow(value,
               new NumberExpression(2)));

    protected override double Evaluate(double value) => Math.Atan(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Atan(value);

    public override string ToString() => $"arctan({this.Value})";

    public override bool Equals(object? obj)
    {
        Atan? unary = obj as Atan;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 9 * this.Value.GetHashCode();
}

public class Acot : UnaryExpression
{
    public Acot(ExpressionType value) : base(value)
    {
    }

    protected override ExpressionType Derivative(ExpressionType value)
        => -new NumberExpression(1) /
           (new NumberExpression(1) + Pow.DeterminatePow(value,
               new NumberExpression(2)));

    protected override double Evaluate(double value) => Math.PI / 2 - Math.Atan(value);

    protected override ExpressionType EvaluateExpression(ExpressionType value) => new Acot(value);

    public override string ToString() => $"arccot({this.Value})";

    public override bool Equals(object? obj)
    {
        Acot? unary = obj as Acot;
        if (unary is null) return false;

        return this.Value.Equals(unary.Value);
    }

    public override int GetHashCode() => 10 * this.Value.GetHashCode();
}