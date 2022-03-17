namespace Interfaces
{
    public interface IBrowser<T>
    {
        T CurrentObject { get; }
        void SetObjects(T[] objects);
        void Forward();
        void Back();
    }
}
