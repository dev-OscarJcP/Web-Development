using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using DevFreela.Models;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll(string query);
        ProjectDetailViewModel GetById(int id);
        int Create(NewProjectInputModel inputModel);
        void Update(UpdateProjectInputModel inputModel);
        void Delete(int id);
        void CreateComment(CreateCommentModel inputModel);
        void Start(int id);
        void Finish(int id);

    }
}
