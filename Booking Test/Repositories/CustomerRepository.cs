using Booking_Test.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Test.Repositories
{
    public class CustomerRepository : RepositoryBase, ICustomerRepository
    {
        public void Add(CustomerModel customer)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into [Customer] (first_name,last_name, title, phone, email, street, city, state, country, postal_code) values (@first_name, @last_name, @title, @phone, @email, @street, @city, @state, @country, @postal_code)";
                command.Parameters.Add("@first_name", SqlDbType.NVarChar, 50).Value = customer.First_name;
                command.Parameters.Add("@last_name", SqlDbType.NVarChar, 50).Value = customer.Last_name;
                command.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value = customer.Title;
                command.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = customer.Phone;
                command.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = customer.Email;
                command.Parameters.Add("@street", SqlDbType.NVarChar, 50).Value = customer.Street;
                command.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = customer.City;
                command.Parameters.Add("@state", SqlDbType.NVarChar, 50).Value = customer.State;
                command.Parameters.Add("@country", SqlDbType.NVarChar, 50).Value = customer.Country;
                command.Parameters.Add("@postal_code", SqlDbType.NVarChar, 50).Value = customer.Postal_code;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public ObservableCollection<CustomerModel> Clear()
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomerModel customer)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update [Customer] set first_name = @first_name,last_name = @last_name, title = @title, phone = @phone, email = @email, street = @street, city = @city, state = @state, country = @country, postal_code = @postal_code where id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;
                command.Parameters.Add("@first_name", SqlDbType.NVarChar, 50).Value = customer.First_name;
                command.Parameters.Add("@last_name", SqlDbType.NVarChar, 50).Value = customer.Last_name;
                command.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value = customer.Title;
                command.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = customer.Phone;
                command.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = customer.Email;
                command.Parameters.Add("@street", SqlDbType.NVarChar, 50).Value = customer.Street;
                command.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = customer.City;
                command.Parameters.Add("@state", SqlDbType.NVarChar, 50).Value = customer.State;
                command.Parameters.Add("@country", SqlDbType.NVarChar, 50).Value = customer.Country;
                command.Parameters.Add("@postal_code", SqlDbType.NVarChar, 50).Value = customer.Postal_code;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CustomerModel> GetAll(ObservableCollection<CustomerModel> customers)
        {
            CustomerModel customer = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from [Customer] ORDER BY Id";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customer = new CustomerModel()
                        {
                            Id = reader[0].GetHashCode(),
                            First_name = reader[1].ToString(),
                            Last_name = reader[2].ToString(),
                            Email = reader[3].ToString(),
                            Phone = reader[4].ToString(),
                            Title = reader[5].ToString(),
                            Street = reader[6].ToString(),
                            City = reader[7].ToString(),
                            State = reader[8].ToString(),
                            Country = reader[9].ToString(),
                            Postal_code = reader[10].ToString(),
                        };

                        Console.WriteLine(customer);

                        customers.Add(customer);
                    }
                }
                connection.Close();
            }
            return customers;
        }

        public CustomerModel GetByCustomerId(int id)
        {
            CustomerModel customer = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from [Customer] where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new CustomerModel()
                        {
                            Id = reader[0].GetHashCode(),
                            First_name = reader[1].ToString(),
                            Last_name = reader[2].ToString(),
                            Email = reader[3].ToString(),
                            Phone = reader[4].ToString(),
                            Title = reader[5].ToString(),
                            Street = reader[6].ToString(),
                            City = reader[7].ToString(),
                            State = reader[8].ToString(),
                            Country = reader[9].ToString(),
                            Postal_code = reader[10].ToString(),
                        };
                    }
                }
            }
            return customer;
        }

        public ObservableCollection<CustomerModel> GetByCustomerName(string name)
        {
            CustomerModel customer = null;
            ObservableCollection<CustomerModel> customers = new ObservableCollection<CustomerModel>();
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from [Customer] where first_name=@name or last_name = @name";
                command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new CustomerModel()
                        {
                            Id = reader[0].GetHashCode(),
                            First_name = reader[1].ToString(),
                            Last_name = reader[2].ToString(),
                            Email = reader[3].ToString(),
                            Phone = reader[4].ToString(),
                            Title = reader[5].ToString(),
                            Street = reader[6].ToString(),
                            City = reader[7].ToString(),
                            State = reader[8].ToString(),
                            Country = reader[9].ToString(),
                            Postal_code = reader[10].ToString(),
                        };
                    }
                }
            }
            return customers;
        }

        public void Remove(int id)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Delete [Customer] where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
