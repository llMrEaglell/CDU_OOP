namespace Lab5
{
    public interface IMyNumber<T> where T : IMyNumber<T>
    {
        T Add(T obj);
        T Substract(T obj);
        T Multiply(T obj);
        T Devide(T obj);
    }
}