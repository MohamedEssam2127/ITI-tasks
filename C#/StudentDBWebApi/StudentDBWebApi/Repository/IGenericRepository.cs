namespace StudentDBWebApi.Repository
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> GetAll();
        T? GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Save();
    }
}
