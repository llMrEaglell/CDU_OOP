namespace Lab5
{
    public interface IMyNumber<T> where T : IMyNumber<T>
    {
        T Add(T that);
        T Substract(T that);
        T Multiply(T that);
        T Devide(T that);
    }
}