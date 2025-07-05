using BlazorApp.Client.Shared;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorApp.Client.Client.Services
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/employees");
                response.EnsureSuccessStatusCode();

                var employees = await response.Content.ReadFromJsonAsync<IEnumerable<Employee>>(_jsonOptions);
                return employees ?? Enumerable.Empty<Employee>();
            }
            catch (HttpRequestException ex)
            {
                // TODO: Log the error (e.g., ILogger)
                Console.Error.WriteLine($"HTTP error: {ex.Message}");
                return Enumerable.Empty<Employee>();
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                Console.Error.WriteLine($"Unexpected error: {ex.Message}");
                return Enumerable.Empty<Employee>();
            }
        }

        // TODO: Implement the following methods as needed
        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
