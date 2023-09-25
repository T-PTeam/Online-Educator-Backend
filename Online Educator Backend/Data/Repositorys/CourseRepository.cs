using Microsoft.EntityFrameworkCore;
using Online_Educator_Backend.Model;
using Online_Educator_Backend.Model.Enums;

namespace Online_Educator_Backend.Data.Repositorys
{
    public class CourseRepository : ICourseRepository
    {

        public CourseRepository()
        {
            using (var context = new UserContext())
            {

                var courses = new List<Course>
                {
                new Course
                {
                    InstructorProfiles = new List<User>
                    {
                        new User
                {
                    Name = "user",
                    Email = "TTT@gmail.com",
                    Password = "password",
                    Id = 1,
                }
                    },
                    RequirementsJson = new List<string>
                {
                    "TTT"
                },
                    
                    Title = "string",
                    Subtitle = "string",
                        Id = 0,
    localization = 0,
    SomeListStringJson = new List<string>
                {
                    "TTT"
                },
    IntendedJson = new List<string>
                {
                    "TTT"
                },
    Description = "string",
    Category = "string",
    Level = "string",
    Subcategory = "string",
    MainSubject = "string",
    Image = "string",
    PromotionalVideo = "string",
    Greetings = "string",
    Congratulation = "string",
    ChapterList = new List<string>
                {
                    "TTT"
                },
    Price = new Price
    {
        Id = 1,
        Currency= Currency.AFN,PriceCourse = 13333m
    },
    CurriculumJson = new List<Section>
                {
                    new Section
                    {
                        Id =1,
                        TasksJson = new List<Model.Task>{ new Model.Task
                        {
                            Id = 1
                        } 
                        },
                        TestsJson =new List<Model.Test>{ new Model.Test
                        {
                            Id = 1
                        },
                        },ExercisesJson =new List<Model.Exercises>{ new Model.Exercises
                        {
                            Id = 1
                        },
                        }, LecturesJson = new List<Model.Lecture>{ new Model.Lecture
                        {
                            Id = 1,Title= "TTTT"
                        },
                        }

                    }
                },
                }
                };
                context.Courses.AddRange(courses);
                context.SaveChanges();
            }
        }

        public async Task<Course> GetByIdAsync(int id)
        {
            using (var context = new UserContext())
            {
                return await context.Courses.FindAsync(id);
            }
        }

        public async Task<List<Course>> GetAllAsync()
        {
            using (var context = new UserContext())
            {


                Console.Write(await context.Courses.ToListAsync());

                return await context.Courses.ToListAsync();

            }
            
        }

        public async System.Threading.Tasks.Task CreateAsync(Course course)
        {
            using (var context = new UserContext())
            {
                context.Courses.Add(course);
                await context.SaveChangesAsync();
            }
            

        }

        public async System.Threading.Tasks.Task UpdateAsync(Course course)
        {
            using (var context = new UserContext())
            {
                context.Courses.Update(course);
                await context.SaveChangesAsync();
            }
           
        }

        public async System.Threading.Tasks.Task DeleteAsync(int id)
        {
            using (var context = new UserContext())
            {
                var course = await context.Courses.FindAsync(id);
                if (course != null)
                {
                    context.Courses.Remove(course);
                    await context.SaveChangesAsync();
                }
            }
            
        }
    }

}
