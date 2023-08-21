using Domain.Entities;

namespace Domain.Repositories;

public interface ICustomerRepository
{

    Customer? GetById(int id);

    void Add(Customer customer);

    void Update(Customer customer);

    void Remove(Customer customer);

}