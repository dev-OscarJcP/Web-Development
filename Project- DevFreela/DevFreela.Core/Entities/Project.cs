﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Core.Enums;

namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreelancer, decimal totalCost)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;
            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<ProjectComment>();
        }
        public string Title { get; private set; }

        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public void CancelledProject()
        {
            if (Status == ProjectStatusEnum.Created || Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Cancelled;
            }
            else
            {
                throw new InvalidOperationException("Only projects in Created or InProgress status can be cancelled.");
            }
        }
        public void FinishProject()
        {
            if (Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Finished;
                FinishedAt = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Only projects in InProgress status can be finished.");
            }
        }
        public void StartProject()
        {
            if (Status == ProjectStatusEnum.Created)
            {
                Status = ProjectStatusEnum.InProgress;
                StartedAt = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Only projects in Created status can be started.");
            }

        }
        public void Update(int Title, string description, decimal totalCost)
        {
            Title = Title;
            Description = description;
            TotalCost = totalCost;
        }
    }
}
