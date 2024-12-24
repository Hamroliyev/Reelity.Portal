// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using Reelity.Portal.Web.Models.Students;
using System.Threading.Tasks;

namespace Reelity.Portal.Web.Brokers.API
{
    public partial class ApiBroker
    {
        private const string StudentsRelativeUrl = "api/students";
        public async ValueTask<Student> PostStudentAsync(Student student) =>
            await PostAsync(StudentsRelativeUrl, student);
    }
}
