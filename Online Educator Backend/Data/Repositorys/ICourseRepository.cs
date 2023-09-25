using Online_Educator_Backend.Model;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace Online_Educator_Backend.Data.Repositorys
{
    public interface ICourseRepository
    {
        Task<Course> GetByIdAsync(int id);
        Task<List<Course>> GetAllAsync();
        Task CreateAsync(Course course);
        Task UpdateAsync(Course course);
        Task DeleteAsync(int id);
    }
}
