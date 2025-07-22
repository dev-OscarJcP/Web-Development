using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using DevFreela.Models;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public int Create(NewProjectInputModel inputModel)
        {
            throw new NotImplementedException();
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);
            _dbContext.Projects.Add(project);
            return project.Id;
        }

        public void CreateComment(CreateCommentModel inputModel)
        {
            throw new NotImplementedException();
            var comment = new ProjectComment(inputModel.ContentComment,inputModel.IdProject,inputModel.IdUserComment);
            _dbContext.ProjectComments.Add(comment);
        }   

        public void Delete(int id)
        {
            throw new NotImplementedException();
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.CancelledProject();
        }

        public void Finish(int id)
        {
            throw new NotImplementedException();
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            return project.FinishProject();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            throw new NotImplementedException();
            var projects = _dbContext.Projects;
            var projectViewModels = projects
                .Select(p => new ProjectViewModel(p.Title, p.CreatedAt))
                .ToList();
            return projectViewModels;

        }

        public ProjectDetailViewModel GetById(int id)
        {
            throw new NotImplementedException();
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            var projectDetailViewModel = new ProjectDetailViewModel(
                    project.Id,
                    project.Title,
                    project.Description,
                    project.IdClient,
                    project.TotalCost,
                    project.StartedAt,
                    project.FinishedAt);

        }

        public void Start(int id)
        {
            throw new NotImplementedException();
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.StartProject();
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            throw new NotImplementedException();
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == inputModel.Id);
            project.Update(inputModel.Title, inputModel.Description, inputModel.TotalCost);
           

        }
    }
}
